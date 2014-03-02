using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using System.Windows;
using Apex;
using tscui.Views;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using tscui.Service;
using tscui.Models;
using System.Windows.Threading;
using System.Threading;

namespace tscui.Pages.Phase
{
    /// <summary>
    /// Interaction logic for PhaseView.xaml
    /// </summary>
    [View(typeof(PhaseViewModel))]
    public partial class PhaseView : UserControl, IView
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer1;

        public PhaseView()
        {
            
            InitializeComponent();
            
            
        }
        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);

            //  Handle the 'show popup' executed event.ShowPopupCommandSouthRight/ShowPopupCommandSouthOther
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthLeft.Executed += ShowPopupCommandSouthLeft_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthStaight.Executed += ShowPopupCommandSouthStaight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthRight.Executed += ShowPopupCommandSouthRight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthOther.Executed += ShowPopupCommandSouthOther_Executed;
            ((PhaseViewModel)DataContext).ShowFailePopup.Executed += ShowFailePopup_Excuted;
            
            
        }
        void ShowFailePopup_Excuted(object sender, CommandEventArgs args)
        {
            FailePopup ep1 = new FailePopup();

            ApexBroker.GetShell().ShowPopup(ep1);
 
        }
        void ShowPopupCommandSouthRight_Executed(object sender, CommandEventArgs args)
        {
            //ExamplePopup ep1 = new ExamplePopup();
            //ep1.RadioSelectedEvent += new RadioSelectedHandler(ep1_RadioSelectedEvent);
            //ApexBroker.GetShell().ShowPopup(ep1);
        }
        void ShowPopupCommandSouthOther_Executed(object sender, CommandEventArgs args)
        {
            //ExamplePopup ep2 = new ExamplePopup();
            //ep2.RadioSelectedEvent += new RadioSelectedHandler(ep2_RadioSelectedEvent);
            //ApexBroker.GetShell().ShowPopup(ep2);
        }
        void ShowPopupCommandSouthStaight_Executed(object sender, CommandEventArgs args)
        {
            //ExamplePopup ep3 = new ExamplePopup();
            //ep3.RadioSelectedEvent += new RadioSelectedHandler(ep3_RadioSelectedEvent);
           
        }

        void ep1_RadioSelectedEvent()
        {
            //String strPhase = (String)Application.Current.Properties["phaseSelected"];
            //southRight.Content = strPhase;
            ////MessageBox.Show(strPhase);
            //throw new NotImplementedException();
        }
        void ep2_RadioSelectedEvent()
        {
            //String strPhase = (String)Application.Current.Properties["phaseSelected"];
            //southOther.Content = strPhase;
            //Models.Phase p = new Models.Phase();
            //p.ucId =1;
            //MessageBox.Show(""+p.ucId);
            ////throw new NotImplementedException();

        }
        void ep3_RadioSelectedEvent()
        {
            //String strPhase = (String)Application.Current.Properties["phaseSelected"];
            //southStraight.Content = strPhase;
            ////MessageBox.Show(strPhase);
            ////throw new NotImplementedException();
        }
        void ep4_RadioSelectedEvent()
        {
            //String strPhase = (String)Application.Current.Properties["phaseSelected"];
            //southLeft.Content = strPhase;
            ////MessageBox.Show(strPhase);
            //throw new NotImplementedException();
        }
        void ShowPopupCommandSouthLeft_Executed(object sender, CommandEventArgs args)
        {
            //ExamplePopup ep4 = new ExamplePopup();
            //ep4.RadioSelectedEvent += new RadioSelectedHandler(ep4_RadioSelectedEvent);
            //ApexBroker.GetShell().ShowPopup(ep4);
        }
        public void OnDeactivated()
        {
            //  Remove the handler for the 'show popup' executed event.
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthLeft.Executed -= ShowPopupCommandSouthLeft_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthStaight.Executed -= ShowPopupCommandSouthStaight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthRight.Executed -= ShowPopupCommandSouthRight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthOther.Executed -= ShowPopupCommandSouthOther_Executed;
            ((PhaseViewModel)DataContext).ShowFailePopup.Executed += ShowFailePopup_Excuted;
        }

     

  


        #region 设置相位按钮隐藏
        private void SetPhaseButtonShow(bool swichflag)
        {
            try
            {
                switch (swichflag)
                {
                    case false:
                        this.SouthLeft.Visibility = System.Windows.Visibility.Hidden;
                        this.SouthRight.Visibility = System.Windows.Visibility.Hidden;
                        this.SouthStraight.Visibility = System.Windows.Visibility.Hidden;
                        this.SouthOther.Visibility = System.Windows.Visibility.Hidden;
                        this.NorthLeft.Visibility = System.Windows.Visibility.Hidden;
                        this.NorthRight.Visibility = System.Windows.Visibility.Hidden;
                        this.NorthStraight.Visibility = System.Windows.Visibility.Hidden; ;
                        this.NorthOther.Visibility = System.Windows.Visibility.Hidden;
                        this.WestLeft.Visibility = System.Windows.Visibility.Hidden;
                        this.WestRight.Visibility = System.Windows.Visibility.Hidden;
                        this.WestStraight.Visibility = System.Windows.Visibility.Hidden;
                        this.WestOther.Visibility = System.Windows.Visibility.Hidden;
                        this.EastLeft.Visibility = System.Windows.Visibility.Hidden;
                        this.EastRight.Visibility = System.Windows.Visibility.Hidden;
                        this.EastStraight.Visibility = System.Windows.Visibility.Hidden;
                        this.EastOther.Visibility = System.Windows.Visibility.Hidden;
                        this.EastPedestrain1.Visibility = System.Windows.Visibility.Hidden;
                        this.WestPedestrain1.Visibility = System.Windows.Visibility.Hidden;
                        this.NorthPedestrain1.Visibility = System.Windows.Visibility.Hidden;
                        this.SouthPedestrain1.Visibility = System.Windows.Visibility.Hidden;

                        break;
                    case true:
                        this.SouthLeft.Visibility = System.Windows.Visibility.Visible;
                        this.SouthRight.Visibility = System.Windows.Visibility.Visible;
                        this.SouthStraight.Visibility = System.Windows.Visibility.Visible;
                        this.SouthOther.Visibility = System.Windows.Visibility.Visible;
                        this.NorthLeft.Visibility = System.Windows.Visibility.Visible;
                        this.NorthRight.Visibility = System.Windows.Visibility.Visible;
                        this.NorthStraight.Visibility = System.Windows.Visibility.Visible; ;
                        this.NorthOther.Visibility = System.Windows.Visibility.Visible;
                        this.WestLeft.Visibility = System.Windows.Visibility.Visible;
                        this.WestRight.Visibility = System.Windows.Visibility.Visible;
                        this.WestStraight.Visibility = System.Windows.Visibility.Visible;
                        this.WestOther.Visibility = System.Windows.Visibility.Visible;
                        this.EastLeft.Visibility = System.Windows.Visibility.Visible;
                        this.EastRight.Visibility = System.Windows.Visibility.Visible;
                        this.EastStraight.Visibility = System.Windows.Visibility.Visible;
                        this.EastOther.Visibility = System.Windows.Visibility.Visible;
                        this.EastPedestrain1.Visibility = System.Windows.Visibility.Visible;
                        this.WestPedestrain1.Visibility = System.Windows.Visibility.Visible;
                        this.NorthPedestrain1.Visibility = System.Windows.Visibility.Visible;
                        this.SouthPedestrain1.Visibility = System.Windows.Visibility.Visible;
                        break;

                }
            }
            catch (Exception ex)
            {

            }

        }
       
        #endregion


        #region 刷新灯组状态

       

        private void LampRhshStar()
        {

            //MessageBox.Show("LampRhshStar");
            dispatcherTimer1 = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer1.Tick += new EventHandler(dispatcherTimer1_Tick);
            dispatcherTimer1.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer1.Start();
 
        }
        int i = 1;

        private void updateRed(PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                imgNorthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                imgNorthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                imgNorthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                imgNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                imgNorthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                imgNorthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT)
            {
                imgEastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                imgEastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                imgEastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                imgEastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                imgEastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                imgEastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                imgSouthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                imgSouthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                imgSouthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                imgSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                imSouthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                imSouthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT)
            {
                imgWestLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                imgWestStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                imgWestRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                imgWestOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                imgWestPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                imgWestPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
        }

        private void updateYellow(PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                imgNorthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                imgNorthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                imgNorthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                imgNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                imgNorthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                imgNorthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT)
            {
                imgEastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                imgEastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                imgEastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                imgEastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                imgEastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                imgEastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                imgSouthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                imgSouthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                imgSouthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                imgSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                imSouthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                imSouthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT)
            {
                imgWestLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                imgWestStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                imgWestRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                imgWestOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                imgWestPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                imgWestPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
        }

        private void updateGreen(PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                imgNorthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                imgNorthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                imgNorthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                imgNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                imgNorthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                imgNorthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT)
            {
                imgEastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                imgEastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                imgEastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                imgEastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                imgEastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                imgEastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                imgSouthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                imgSouthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                imgSouthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                imgSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                imSouthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                imSouthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT)
            {
                imgWestLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                imgWestStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                imgWestRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                imgWestOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                imgWestPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                imgWestPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
        }
        private void dispatcherTimer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("dispatcherTimer1_Tick");
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Channel> lc = t.ListChannel;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<Models.Phase> lp = t.ListPhase;
            List<OverlapPhase> lop = t.ListOverlapPhase;
            if (tscui.Models.ReportTscStatus.resportSuccessFlag)
            {
               // MessageBox.Show("if");
                this.workmode_label.Content = "工作模式：" + tscui.Models.ReportTscStatus.sWorkModel.ToString();
                this.controlmode_label.Content = "控制方式：" + tscui.Models.ReportTscStatus.sControlModel.ToString();
                this.workstatus_label.Content = "工作状态：" + tscui.Models.ReportTscStatus.sWorkStatus.ToString();

                this.time_NO_label.Content = "配时方案：" + tscui.Models.ReportTscStatus.iCurrentTimePattern.ToString();
                this.run_NO_label.Content = "时段方案：" + tscui.Models.ReportTscStatus.iCurrentSchedule.ToString();
                this.lblCurrentStage.Content = "当前阶段：" + tscui.Models.ReportTscStatus.iCurrentStage.ToString();
            this.label_CycleTime.Content = "周期时长： " + tscui.Models.ReportTscStatus.iCycleTime.ToString();
            this.label_iCurrentStagePattern.Content = "阶段配时： " + tscui.Models.ReportTscStatus.iCurrentStagePattern.ToString();
            this.label_iStageCount.Content = "阶段总数： " + tscui.Models.ReportTscStatus.iStageCount.ToString();
            this.label_iStageTotalTime.Content = "阶段总时长： " + tscui.Models.ReportTscStatus.iStageTotalTime.ToString();
            this.label_iStageRunTime.Content = "阶段运行时长： " + tscui.Models.ReportTscStatus.iStageRunTime.ToString();
            List <uint> redList =   tscui.Models.ReportTscStatus.listChannelRedStatus;
            List <uint> yellowList =   tscui.Models.ReportTscStatus.listChannelYellowStatus;
            List <uint> greenList =   tscui.Models.ReportTscStatus.listChannelGreenStatus;
                //foreach()
            #region 红灯图片刷新
            for (int i = 0; i < redList.Count; i++)
            {
               
                foreach (Channel c in lc)
                {
                    if ((i+1) == c.ucId)
                    {
                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucPhase != 0)
                            {
                                if (ptd.ucPhase == c.ucSourcePhase)
                                {
                                    if (redList[i] == 1)
                                    {
                                        updateRed(ptd);
                                      //  break;
                                    }
                                }
                               /// break;
                            }
                            else
                            {
                                if (ptd.ucOverlapPhase != 0)
                                {
                                    if (ptd.ucOverlapPhase == c.ucSourcePhase)
                                    {
                                        if(redList[i] == 1)
                                        {
                                            updateRed(ptd);
                                            //break;
                                        }
                                       
                                    }
                                    
                                }
                            }
                           // break;
                        }
                       // break;
                    }
                    
                }
                
                //南行左
            
            }
            #endregion

            #region 黄灯图片刷新
            for (int i = 0; i < yellowList.Count; i++)
            {
                foreach (Channel c in lc)
                {
                    if ((i+1) == c.ucId)
                    {
                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucPhase != 0)
                            {
                                if (ptd.ucPhase == c.ucSourcePhase)
                                {
                                    if (yellowList[i] == 1)
                                    {
                                        updateYellow(ptd);
                                      ///  break;
                                    }
                                }
                            }
                            else
                            {
                                if (ptd.ucOverlapPhase != 0)
                                {
                                    if (ptd.ucOverlapPhase == c.ucSourcePhase)
                                    {
                                        if(yellowList[i] == 1)
                                        { 
                                            updateYellow(ptd);
                                            //break;
                                        }
                                    }
                                }
                            }
                        }
                       // break;
                    }

                }
            }

                #endregion

            #region 绿灯图片刷新
            for (int i = 0; i < greenList.Count; i++)
            {
                foreach (Channel c in lc)
                {
                    if ((i+1) == c.ucId)
                    {
                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucPhase != 0)
                            {
                                if (ptd.ucPhase == c.ucSourcePhase)
                                {
                                    if (greenList[i] == 1)
                                    {
                                        updateGreen(ptd);
                                        //break;
                                    }
                                    
                                }
                            }
                            else
                            {
                                if (ptd.ucOverlapPhase != 0)
                                {
                                    if (ptd.ucOverlapPhase == c.ucSourcePhase)
                                    {
                                        if (greenList[i] == 1)
                                        {
                                            updateGreen(ptd);
                                            //break;
                                        }
                                    }
                                }
                            }
                            
                        }
                        //break;
                    }

                }

            }
                #endregion

            }
            
           

           
        }
        #endregion




        private void Image_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void setLampPhase_Checked(object sender, RoutedEventArgs e)
        {
            SetPhaseButtonShow(true);

        }
        private void Image_ImageFailed(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_1(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_2(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {

        }
       
        private void setLampPhase_Unchecked(object sender, RoutedEventArgs e)
        {
            SetPhaseButtonShow(false);
        }

        private void lampRush_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show("lampRush_CheckBox_Checked");
                tscui.Models.ReportTscStatus reportTscStatus = new Models.ReportTscStatus();
                TscDataUtils.GetReportStatus();

                LampRhshStar();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        public void InitDirec()
        {
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase != 0)
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        NorthLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        NorthOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        NorthPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        NorthPedestrain2.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        NorthRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        NorthStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        EastLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        EastStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        EastRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        EastOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        EastPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        EastPedestrain2.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        SouthLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        SouthOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        SouthStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        SouthRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        SouthPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        SouthPedestrain2.Visibility = Visibility.Visible;
                    }

                    //west
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        WestLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        WestStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        WestRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        WestOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        WestPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        WestPedestrain2.Visibility = Visibility.Visible;
                    }

                }
                else
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        NorthLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        NorthOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        NorthPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        NorthPedestrain2.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        NorthRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        NorthStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        EastLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        EastStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        EastRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        EastOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        EastPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        EastPedestrain2.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        SouthLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        SouthOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        SouthStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        SouthRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        SouthPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        WestPedestrain2.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        WestPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        WestOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        WestRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        WestStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        WestLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        SouthPedestrain2.Visibility = Visibility.Hidden;
                    }

                    if (ptd.ucOverlapPhase != 0)
                    {
                        if (ptd.ucId == Define.NORTH_LEFT)
                        {
                            NorthLeft.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.NORTH_OTHER)
                        {
                            NorthOther.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                        {
                            NorthPedestrain1.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                        {
                            NorthPedestrain2.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.NORTH_RIGHT)
                        {
                            NorthRight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.NORTH_STRAIGHT)
                        {
                            NorthStraight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_LEFT)
                        {
                            EastLeft.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_STRAIGHT)
                        {
                            EastStraight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_RIGHT)
                        {
                            EastRight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_OTHER)
                        {
                            EastOther.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                        {
                            EastPedestrain1.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                        {
                            EastPedestrain2.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.SOUTH_LEFT)
                        {
                            SouthLeft.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.SOUTH_OTHER)
                        {
                            SouthOther.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.SOUTH_STRAIGHT)
                        {
                            SouthStraight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.SOUTH_RIGHT)
                        {
                            SouthRight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                        {
                            SouthPedestrain1.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                        {
                            SouthPedestrain2.Visibility = Visibility.Visible;
                        }

                        //west
                        if (ptd.ucId == Define.WEST_LEFT)
                        {
                            WestLeft.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.WEST_STRAIGHT)
                        {
                            WestStraight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.WEST_RIGHT)
                        {
                            WestRight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.WEST_OTHER)
                        {
                            WestOther.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                        {
                            WestPedestrain1.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                        {
                            WestPedestrain2.Visibility = Visibility.Visible;
                        }

                    }
                    else
                    {
                        if (ptd.ucId == Define.NORTH_LEFT)
                        {
                            NorthLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_OTHER)
                        {
                            NorthOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                        {
                            NorthPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                        {
                            NorthPedestrain2.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_RIGHT)
                        {
                            NorthRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_STRAIGHT)
                        {
                            NorthStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_LEFT)
                        {
                            EastLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_STRAIGHT)
                        {
                            EastStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_RIGHT)
                        {
                            EastRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_OTHER)
                        {
                            EastOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                        {
                            EastPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                        {
                            EastPedestrain2.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_LEFT)
                        {
                            SouthLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_OTHER)
                        {
                            SouthOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_STRAIGHT)
                        {
                            SouthStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_RIGHT)
                        {
                            SouthRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                        {
                            SouthPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                        {
                            WestPedestrain2.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                        {
                            WestPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_OTHER)
                        {
                            WestOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_RIGHT)
                        {
                            WestRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_STRAIGHT)
                        {
                            WestStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_LEFT)
                        {
                            WestLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                        {
                            SouthPedestrain2.Visibility = Visibility.Hidden;
                        }
                    }
                }

               
            }
        }
        private void InitPhaseToButtonByDirec()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach(PhaseToDirec ptd in t.ListPhaseToDirec)
            {
                if (ptd.ucPhase != 0)
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        NorthLeft.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        NorthOther.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        NorthPedestrain1.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        NorthPedestrain2.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        NorthRight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        NorthStraight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        EastLeft.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        EastStraight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        EastRight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        EastOther.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        EastPedestrain1.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        EastPedestrain2.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        SouthLeft.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        SouthOther.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        SouthStraight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        SouthRight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        SouthPedestrain1.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        SouthPedestrain2.Content = ptd.ucPhase;
                    }

                    //west
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        WestLeft.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        WestStraight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        WestRight.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        WestOther.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        WestPedestrain1.Content = ptd.ucPhase;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        WestPedestrain2.Content = ptd.ucPhase;
                    }

                }
                if (ptd.ucOverlapPhase != 0)
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        NorthLeft.Content = "O"+ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        NorthOther.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        NorthPedestrain1.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        NorthPedestrain2.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        NorthRight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        NorthStraight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        EastLeft.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        EastStraight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        EastRight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        EastOther.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        EastPedestrain1.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        EastPedestrain2.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        SouthLeft.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        SouthOther.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        SouthStraight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        SouthRight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        SouthPedestrain1.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        SouthPedestrain2.Content = "O" + ptd.ucOverlapPhase;
                    }

                    //west
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        WestLeft.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        WestStraight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        WestRight.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        WestOther.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        WestPedestrain1.Content = "O" + ptd.ucOverlapPhase;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        WestPedestrain2.Content = "O" + ptd.ucOverlapPhase;
                    }

                }
            }
        }
        TscData t;
        private delegate void DelegateInitPhaseToButtonByDirec();
        private void DispatcherInitPhaseToButtonByDirec(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitPhaseToButtonByDirec(InitPhaseToButtonByDirec));
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(t == null)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(DispatcherInitPhaseToButtonByDirec);
            //Thread tDispatcherInitPhaseToButtonByDirec = new Thread(DispatcherInitPhaseToButtonByDirec);
            //tDispatcherInitPhaseToButtonByDirec.IsBackground = true;
            //tDispatcherInitPhaseToButtonByDirec.Start();
            ////InitPhaseToButtonByDirec();
        }


        private void phase1_Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void phase4_Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void ClearButtonOverlapPhaseContent(Models.OverlapPhase op, Models.PhaseToDirec ptd)
        {
            if (op.ucId == ptd.ucOverlapPhase )
            {
                if (ptd.ucId == Define.SOUTH_LEFT)
                {
                    SouthLeft.Content = "";
                    if( ptd.ucPhase !=0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_STRAIGHT)
                {
                    SouthStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_RIGHT)
                {
                    SouthRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                {
                    SouthPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                {
                    SouthPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_OTHER)
                {
                    SouthOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_LEFT)
                {
                    NorthLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_STRAIGHT)
                {
                    NorthStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_RIGHT)
                {
                    NorthRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_OTHER)
                {
                    NorthOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                {
                    NorthPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                {
                    NorthPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_LEFT)
                {
                    EastLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_STRAIGHT)
                {
                    EastStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_RIGHT)
                {
                    EastRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_OTHER)
                {
                    EastOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                {
                    EastPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                {
                    EastPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_LEFT)
                {
                    WestLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_STRAIGHT)
                {
                    WestStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_RIGHT)
                {
                    WestRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_OTHER)
                {
                    WestOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                {
                    WestPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                {
                    WestPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }

            }
            if (0 != ptd.ucPhase)
            {
                if (ptd.ucId == Define.SOUTH_LEFT)
                {
                    SouthLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_STRAIGHT)
                {
                    SouthStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_RIGHT)
                {
                    SouthRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                {
                    SouthPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                {
                    SouthPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.SOUTH_OTHER)
                {
                    SouthOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_LEFT)
                {
                    NorthLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_STRAIGHT)
                {
                    NorthStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_RIGHT)
                {
                    NorthRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_OTHER)
                {
                    NorthOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                {
                    NorthPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                {
                    NorthPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_LEFT)
                {
                    EastLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_STRAIGHT)
                {
                    EastStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_RIGHT)
                {
                    EastRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_OTHER)
                {
                    EastOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                {
                    EastPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                {
                    EastPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_LEFT)
                {
                    WestLeft.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_STRAIGHT)
                {
                    WestStraight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_RIGHT)
                {
                    WestRight.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_OTHER)
                {
                    WestOther.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                {
                    WestPedestrain1.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }
                if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                {
                    WestPedestrain2.Content = "";
                    if (ptd.ucPhase != 0)
                    {
                        ptd.ucPhase = 0;
                    }
                    ptd.ucOverlapPhase = 0;
                }

            }
        }
        private void ClearButtonPhaseContent(Models.Phase p ,Models.PhaseToDirec ptd)
        {
            if (p.ucId == ptd.ucPhase)
            {
                if (ptd.ucId == Define.SOUTH_LEFT)
                {
                    SouthLeft.Content = "";
                    ptd.ucPhase = 0;
                    if(ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                    
                }
                if (ptd.ucId == Define.SOUTH_STRAIGHT)
                {
                    SouthStraight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.SOUTH_RIGHT)
                {
                    SouthRight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                {
                    SouthPedestrain1.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                {
                    SouthPedestrain2.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.SOUTH_OTHER)
                {
                    SouthOther.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.NORTH_LEFT)
                {
                    NorthLeft.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.NORTH_STRAIGHT)
                {
                    NorthStraight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.NORTH_RIGHT)
                {
                    NorthRight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.NORTH_OTHER)
                {
                    NorthOther.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                {
                    NorthPedestrain1.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                {
                    NorthPedestrain2.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.EAST_LEFT)
                {
                    EastLeft.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.EAST_STRAIGHT)
                {
                    EastStraight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.EAST_RIGHT)
                {
                    EastRight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.EAST_OTHER)
                {
                    EastOther.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                {
                    EastPedestrain1.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                {
                    EastPedestrain2.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.WEST_LEFT)
                {
                    WestLeft.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.WEST_STRAIGHT)
                {
                    WestStraight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.WEST_RIGHT)
                {
                    WestRight.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.WEST_OTHER)
                {
                    WestOther.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                {
                    WestPedestrain1.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                {
                    WestPedestrain2.Content = "";
                    ptd.ucPhase = 0;
                    if (ptd.ucOverlapPhase != 0)
                    {
                        ptd.ucOverlapPhase = 0;
                    }
                }
                
            }
        }

        private void southOther_Click(object sender, RoutedEventArgs e)
        {
            //ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            //Button btn = sender as Button;
            //tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
            //btn.Content = p.ucId;
            //t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
            //{
                
            //    ClearButtonPhaseContent(p, ptd);
            //    if (ptd.ucId == Define.SOUTH_OTHER)
            //    {
            //        ptd.ucPhase = p.ucId;
            //    }
            //}
        }
        private void SouthLeft_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if(Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if(Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
            
            
            
            
            
        }

        private void SouthStraight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void SouthRight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void SouthOther_Click_1(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void NorthPedestrain2_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void NorthPedestrain1_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void EastPedestrain1_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void EastPedestrain2_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void WestLeft_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void WestStraight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void WestRight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void WestOther_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                   
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void SouthPedestrain1_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void SouthPedestrain2_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void NorthLeft_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void NorthStraight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void NorthRight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void NorthOther_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void WestPedestrain1_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                   
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void WestPedestrain2_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void EastLeft_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void EastStraight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
               
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void EastRight_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
                
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void EastOther_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new ExamplePopup());
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Button btn = sender as Button;
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                tscui.Models.Phase p = Utils.Utils.GetPhaseByCurrent();
                if (p == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == p.ucId)
                {
                    return;
                }
                btn.Content = p.ucId;
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    ClearButtonPhaseContent(p, ptd);
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ptd.ucPhase = p.ucId;
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                Models.OverlapPhase op = Utils.Utils.GetOverLapPhaseByCurrent();
                if (op == null)
                {
                    return;
                }
                if (Convert.ToByte(btn.Content) == op.ucId)
                {
                    return;
                }
               
                foreach (PhaseToDirec ptd in t.ListPhaseToDirec)
                {
                    
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        ClearButtonOverlapPhaseContent(op, ptd);
                        btn.Content = "O" + op.ucId;
                        ptd.ucOverlapPhase = op.ucId;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            TscDataUtils.SetPhaseToDirec(t.ListPhaseToDirec);
            TscDataUtils.SetPhase(t.ListPhase);
            TscDataUtils.SetChannel(t.ListChannel);
            TscDataUtils.SetOverlapPhase(t.ListOverlapPhase);
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach(tscui.Models.Phase p in t.ListPhase)
            {
                Console.WriteLine(p.ucId);
            }
        }

        private void lampRush_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Udp.sendUdp(t.Node.sIpAddress, t.Node.iPort, Define.REPORT_TSC_STATUS_CANCEL);
        }

        private void savePhaseAbout(object state)
        {
            DateTime dt1 = DateTime.Now;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            TscDataUtils.SetPhaseToDirec(t.ListPhaseToDirec);
            TscDataUtils.SetPhase(t.ListPhase);
            TscDataUtils.SetChannel(t.ListChannel);
            TscDataUtils.SetOverlapPhase(t.ListOverlapPhase);
            DateTime dt2 = DateTime.Now;
            TimeSpan dt3 = dt2 - dt1;
            Console.WriteLine(dt3.TotalSeconds);
            
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(savePhaseAbout);
                
                if(echoCountDownDispatcherTimer != null)
                {
                    echoCountDownDispatcherTimer.Stop();
                }
                if(dispatcherTimer1 != null)
                {
                    dispatcherTimer1.Stop();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Phase: "+ex.ToString());
            }
            
        }

        DispatcherTimer echoCountDownDispatcherTimer;
        private void cbxEchoCountDown_Checked(object sender, RoutedEventArgs e)
        {
            TscData td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            EchoCntDowns echoCountDown = new EchoCntDowns();
            Udp.StartReceiveEchoCountDown();
            Udp.sendUdpEchoCountDown(td.Node.sIpAddress, Define.GBT_PORT, Define.ECHO_TSC_COUNT_DOWN);


            echoCountDownDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            echoCountDownDispatcherTimer.Tick += new EventHandler(CountDownDispatcherTimer_Tick);
            echoCountDownDispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            echoCountDownDispatcherTimer.Start();
        }
        private void CountDownDispatcherTimer_Tick(object sender, EventArgs e)
        {
            foreach(EhoCntDown ecd in EchoCntDowns._listEhoCntDown)
            {
                ecd.usFigure--;
                
                if(ecd.Direc == 0)
                {
                    if (ecd.Color == 0x01)
                    {
                        NorthCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        NorthCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        NorthCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }   
                    NorthCntDown.Text = "" + ecd.usFigure;
                }
                if (ecd.Direc == 1)
                {
                    if (ecd.Color == 0x01)
                    {
                        EastCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        EastCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        EastCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }
                    EastCntDown.Text = "" + ecd.usFigure;
                }
                if (ecd.Direc == 2)
                {
                    if (ecd.Color == 0x01)
                    {
                        SouthCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        SouthCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        SouthCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }
                    SouthCntDown.Text = "" + ecd.usFigure;
                }
                if (ecd.Direc == 3)
                {
                    if (ecd.Color == 0x01)
                    {
                        WestCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        WestCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        WestCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }
                    WestCntDown.Text = "" + ecd.usFigure;
                }
            }
            
        }

        private void cbxEchoCountDown_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Udp.sendUdp(t.Node.sIpAddress, t.Node.iPort, Define.ECHO_TSC_COUNT_DOWN_CANCEL);
            SouthCntDown.Text = "";
            NorthCntDown.Text = "";
            EastCntDown.Text = "";
            WestCntDown.Text = "";
        }

    }
}
