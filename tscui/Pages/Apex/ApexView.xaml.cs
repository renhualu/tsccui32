using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apex.MVVM;
using tscui.ViewModels;
using Apex.Behaviours;
using System.Collections.ObjectModel;
using System.Timers;
using tscui.Models;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using tscui.Service;
using Apex;
using tscui.Views;

namespace tscui.Pages.Apex
{
    /// <summary>
    /// Interaction logic for ApexView.xaml
    /// </summary>
    [View(typeof(ApexViewModel))]
    public partial class ApexView : UserControl, IView
    {
        ListView myListView = null;
        GridView myGridView = null;
        UdpClient recevieUdpClient = null;
        List<TscInfo> listTscInfo = null;
        Thread ReceiveMessageThread;
        private delegate void ShowMsgCallBack(TscInfo tscInfo);
        private ShowMsgCallBack showMsgCallBack;

        TscInfo currentTI = null;


        public ApexView()
        {
            InitializeComponent();
            
            
        }
        // 显示消息回调方法
        private void ShowMsg(TscInfo tscInfo)
        {
            myListView.Items.Add(tscInfo);
        }
        /// <summary>
        /// 系统启动后，
        /// 系统自动会将在线的信号机进行搜索。并将数据填写到列表中
        /// 这个方法是处理：选中后，以后的配置的信号机都是选中的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TscInfo ti = (TscInfo)myListView.SelectedItem;
            Application.Current.Properties[Define.TSC_INFO] = ti;
            if (ti == null)
            {
                return;
            }
            InitTscData(ti);
        }
        public void InitTscData(TscInfo ti)
        {
            TscData td = new TscData();
            Node node = new Node(ti.Ip, ti.Name, ti.Version, ti.Port);
            td.Node = node;
            Application.Current.Properties[Define.TSC_DATA] = td;
            try
            {
                td.ListSchedule = TscDataUtils.GetSchedule();
                td.ListPlan = TscDataUtils.GetPlan();
                td.ListModule = TscDataUtils.GetModule();
                td.ListPhase = TscDataUtils.GetPhase();
                try
                {
                    td.ListCollision = TscDataUtils.GetCollision();
                    td.Node.sProtocol = "GBT_V32";
                }
                catch(Exception ex)
                {
                    td.ListCollision = TscDataUtils.GetCollision16();
                    td.Node.sProtocol = "GBT_V16";
                }
                
                td.ListDetector = TscDataUtils.GetDetector();
                td.ListChannel = TscDataUtils.GetChannel();
                td.ListEventLog = TscDataUtils.GetEventLog();
                td.ListPattern = TscDataUtils.GetPattern();
                try
                {
                    td.ListStagePattern = TscDataUtils.GetStagePattern();
                }
                catch(Exception ex)
                {
                    td.ListStagePattern = TscDataUtils.GetStagePattern16();
                }
                
                td.ListOverlapPhase = TscDataUtils.GetOverlapPhase();
                
                td.ListPhaseToDirec = TscDataUtils.GetPhaseToDirec();
                td.ListLampCheck = TscDataUtils.GetLampCheck();
                currentTI = null;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("信号机为16相位，协议无法匹配！");
            }
            
        }
        public void RunThreadRecevie()
        {
            try
            {
                // 创建并实例化IP终端结点
                IPEndPoint ipEndPoint =
                    new IPEndPoint(IPAddress.Any, Define.BROADCAST_PORT);
                // 实例化UDP客户端（可用于实名发送和接收）
                if (recevieUdpClient == null)
                {
                    recevieUdpClient = new UdpClient(ipEndPoint);
                }
                ThreadPool.QueueUserWorkItem(AddListViewTscData);
                
                //if (ReceiveMessageThread != null)
                //{
                //    ReceiveMessageThread.Abort();
                //}
                //ReceiveMessageThread = new Thread(AddListViewTscData);
                //ReceiveMessageThread.IsBackground = true;
                ////ReceiveMessageThread.SetApartmentState(ApartmentState.STA);
                //ReceiveMessageThread.Start();
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("网络出现问题，请处理！"+ex.Message);
            }
            
        }

        void AddListViewTscData(object state)
        {
            // 创建并实例化IP终端结点
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
            listTscInfo = new List<TscInfo>();
            // 消息接收循环
            while (true)
            {
                try
                {
                    if (recevieUdpClient == null)
                    {
                        return;
                    }
                    if (recevieUdpClient.Available > 0)
                    {
                        // 同步阻塞接收消息

                        byte[] byt = recevieUdpClient.Receive(ref ipEndPoint);
                        string msg = Encoding.Default.GetString(byt);
                        if (byt.Length > 6)
                        {
                            string pot1 = Convert.ToString(byt[6], 16);
                            string pot2 = Convert.ToString(byt[7], 16);
                            string tt = pot1 + pot2;
                            string tscId = Convert.ToString(byt[3]);
                            string tscName = byt[0] + "" + byt[1] + "" + byt[2] + "" + byt[3];
                            string tscIp = byt[0] + "." + byt[1] + "." + byt[2] + "." + byt[3];
                            int tscPort = Convert.ToInt32(tt, 16);
                            string tscVersion = Convert.ToString(byt[8], 10) + Convert.ToString(byt[9], 10) + Convert.ToString(byt[10], 10);
                            TscInfo titemp = new TscInfo(tscId, tscName, tscIp, tscVersion, tscPort);
                            if (currentTI == null)
                                currentTI = titemp;
                            myListView.Dispatcher.Invoke(showMsgCallBack, titemp);
                            //Thread.Sleep(300);
                        }
                    }
                    
                }
                catch (ThreadAbortException)
                {
                    // 人为终止线程
                    //MessageBox.Show("人为线程的中止，请联系软件厂商！");
                }
                catch (Exception ex)
                {
                    // 接收发生异常
                   // MessageBox.Show("网络出现异常，请联系软件厂商！"+ex.Message);
                }
            }
            //return listTscInfo;
        }
        public void SendBroadCastByAllTscInfo()
        {
            // 创建IP终端结点
            try
            {
                // 广播模式（由系统自动提供广播地址）
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Broadcast, Define.BROADCAST_PORT);
                // 准备发送的数据
                byte[] sendData = Encoding.Default.GetBytes("123456");
                recevieUdpClient.Send(sendData, sendData.Length, ipEndPoint);
            }
            catch (Exception ext)
            {
               // MessageBox.Show("网络出现问题，请检测网络！"+ext.Message);
            }
            
        }
      
        void atime_Elapsed(object sender, ElapsedEventArgs e)
        {

          // myListView.Items.Add()
        }
        
        public class TscInfo
        {
            private string _id;
            private string _name;
            private string _ip;
            private string _version;
            private int _port;
            public int Port
            {
                get { return _port; }
                set { _port = value; }
            }

            public string Version
            {
                get { return _version; }
                set { _version = value; }
            }
            public string Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Ip
            {
                get { return _ip; }
                set { _ip = value; }
            }

            public TscInfo(string id, string name, string ip,string version,int port)
            {
                _id = id;
                _name = name;
                _ip = ip;
                _version = version;
                _port = port;
            }
            public TscInfo()
            {
                _id = "";
                _name = "";
                _ip = "";
                _version = "";
                _port = 0;
            }
        }
 
       
        

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }

        public void RefreshGridView()
        {
            myListView.Items.Clear();
            
            RunThreadRecevie();
            SendBroadCastByAllTscInfo();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //ReceiveMessageThread.Abort();
            myListView.Items.Clear();
            SendBroadCastByAllTscInfo();
           // myListView.ItemsSource = listTscInfo;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //<SnippetListViewView>
            myListView = new ListView();
            //<SnippetGridViewColumn>

            //<SnippetGridViewAllowsColumnReorder>
            myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;
            myGridView.ColumnHeaderToolTip = "Tsc Information";
            //</SnippetGridViewAllowsColumnReorder>

            //<SnippetGridViewColumnProperties>
            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("Id");
            gvc1.Header = "信号机编号";
            gvc1.Width = 100;
            //</SnippetGridViewColumnProperties>
            myGridView.Columns.Add(gvc1);
            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("Name");
            gvc2.Header = "信号机名称";
            gvc2.Width = 100;
            myGridView.Columns.Add(gvc2);
            //<SnippetAddToColumns>
            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("Ip");
            gvc3.Header = "信号机IP地址";
            gvc3.Width = 100;
            myGridView.Columns.Add(gvc3);
            //</SnippetAddToColumns>

            //</SnippetGridViewColumn>
            //ItemsSource is ObservableCollection of EmployeeInfo objects
            //myListView.ItemsSource = new myTscs();
            //Thread thread = new Thread();
            myListView.View = myGridView;
            myListView.Height = 550;
            // myListView.
            tscPanel.Children.Add(myListView);

            
            //</SnippetListViewView>
            //myListView
            myListView.SelectionChanged += new SelectionChangedEventHandler(myListView_SelectionChanged);
            showMsgCallBack = new ShowMsgCallBack(ShowMsg);
            RefreshGridView();
            //System.Timers.Timer atime = new System.Timers.Timer(10000);
            //atime.Elapsed += new ElapsedEventHandler(atime_Elapsed);
            //atime.AutoReset = true;
            //atime.Enabled = true;
            
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {

           // ReceiveMessageThread.Abort();
            recevieUdpClient.Close();
            if(currentTI != null)
            {
                InitTscData(currentTI);
            }
            

        }

    }
}
