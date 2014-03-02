using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Pages.Log;
using System.Collections.Generic;
using tscui.Models;
using System.Windows.Data;
using System.Windows;

namespace tscui.Pages.Log
{
    /// <summary>
    /// Interaction logic for ThePagesView.xaml
    /// </summary>
    [View(typeof(LogsViewModel))]
    public partial class LogsView : UserControl, IView
    {
        //private List<EventLog> listEventLog;
        private ListView myListView;
        private GridView myGridView;
        public LogsView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }

        private void splLog_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //<SnippetListViewView>
            myListView = new ListView();
            //<SnippetGridViewColumn>

            //<SnippetGridViewAllowsColumnReorder>
            myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;
            myGridView.ColumnHeaderToolTip = "日志信息";
            //</SnippetGridViewAllowsColumnReorder>

            //<SnippetGridViewColumnProperties>
            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("ucEventId");
            gvc1.Header = "日志编号";
            gvc1.Width = 30;
            //</SnippetGridViewColumnProperties>
            myGridView.Columns.Add(gvc1);
            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("sEventType");
            gvc2.Header = "日志类型";
            gvc2.Width = 100;
            myGridView.Columns.Add(gvc2);
            //<SnippetAddToColumns>
            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("ulEventTime");
            gvc3.Header = "日期时间";
            gvc3.Width = 120;
            myGridView.Columns.Add(gvc3);

            GridViewColumn gvc4 = new GridViewColumn();
            gvc4.DisplayMemberBinding = new Binding("sEventDesc");
            gvc4.Header = "日志内容";
            gvc4.Width = 700;
            myGridView.Columns.Add(gvc4);
            //</SnippetAddToColumns>

            //</SnippetGridViewColumn>
            //ItemsSource is ObservableCollection of EmployeeInfo objects
            //myListView.ItemsSource = new myTscs();
            //Thread thread = new Thread();
            myListView.View = myGridView;
            myListView.Height = 550;
            // myListView.
            splLog.Children.Add(myListView);
            TscData td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            if (td == null)
            {
                MessageBox.Show("请选择一台信号机后，打开此界面！");

            }
            else
            {
                myListView.ItemsSource = td.ListEventLog;
            }
        }
    }
}
