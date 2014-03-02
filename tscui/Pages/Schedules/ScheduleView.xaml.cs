using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using tscui.Service;
using tscui.Models;
using System.Collections;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace tscui.Pages.Schedules
{
    public enum OrderStatus { None, New, Processing, Shipped, Received };
        
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(ScheduleViewModel))]
    public partial class ScheduleView : UserControl,IView
    {
       


        public ScheduleView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //throw new NotImplementedException();
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }
        /// <summary>
        /// 得到eventid不为0 的第一条数据 的ScheduleId数据
        /// 并赋予sldScheduleID
        /// </summary>
        /// <param name="ls"></param>
        private void initSldScheduleId(List<Schedule> ls)
        {
            foreach (Schedule s in ls)
            {
                if (s.ucEventId != 0)
                {
                    sldScheduleId.Value = s.ucId;
                    break;

                }
            }
        }
        /// <summary>
        /// 返回EventId不为0 的数据。
        /// 主要是EventId为0的数据不是合法的数据
        /// </summary>
        /// <param name="ls"></param>
        /// <returns></returns>
        private List<Schedule> initSchedule2DataGrid(List<Schedule> ls)
        {
            List<Schedule> newLs = new List<Schedule>();
            foreach (Schedule s in ls)
            {
                if(s.ucId == sldScheduleId.Value)
                {
                    newLs.Add(s);
                }
            }
            return newLs;
        }
        TscData t ;
        private delegate void DelegateInitSchedule();
        private void DispatcherInitSchedule(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitSchedule(InitSchedule));
        }
        private void InitSchedule()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                return;
            }
            List<Schedule> ls = t.ListSchedule;
            //scheduleDataGrid.ItemsSource = ls;
            initSldScheduleId(ls);      //
            // t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<ScheduleCtrl> lsc = new List<ScheduleCtrl>();
            lsc.Add(new ScheduleCtrl() { name = "自主控制", value = (byte)0 });
            lsc.Add(new ScheduleCtrl() { name = "关灯", value = (byte)1 });
            lsc.Add(new ScheduleCtrl() { name = "闪光", value = 2 });
            lsc.Add(new ScheduleCtrl() { name = "全红", value = 3 });
            lsc.Add(new ScheduleCtrl() { name = "感应", value = 6 });
            lsc.Add(new ScheduleCtrl() { name = "单点优化", value = 8 });
            lsc.Add(new ScheduleCtrl() { name = "主从线控", value = 11 });
            lsc.Add(new ScheduleCtrl() { name = "系统优化", value = 12 });
            lsc.Add(new ScheduleCtrl() { name = "干预控制", value = 13 });
            cbxucCtrl.ItemsSource = lsc;

            List<Pattern> lp = t.ListPattern;
            ucTimePatternId.ItemsSource = lp;

            List<ScheduleAuxOut> lsao = new List<ScheduleAuxOut>();
            lsao.Add(new ScheduleAuxOut() { name = "辉度控制", value = 8 });
            lsao.Add(new ScheduleAuxOut() { name = "无功能", value = 0 });

            List<ScheduleSpecialOut> lsso = new List<ScheduleSpecialOut>();
            lsso.Add(new ScheduleSpecialOut() { name = "无特殊功能", value = 0 });
            
        }
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(t == null)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(DispatcherInitSchedule);
        }

        private void tbkScheduleId_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Schedule> ls = t.ListSchedule;
            
        }

        private void sldScheduleId_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            scheduleDataGrid.ItemsSource = initSchedule2DataGrid(t.ListSchedule);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TscDataUtils.SetSchedule(t.ListSchedule);
        }

        private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            { 
            ThreadPool.QueueUserWorkItem(SaveSchedule);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Schedule: " + ex.ToString());
            }
        }

        private void SaveSchedule(object state)
        {
            TscDataUtils.SetSchedule(t.ListSchedule);
        }
    }
    public class ScheduleCtrl
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
    public class ScheduleAuxOut
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
    public class ScheduleSpecialOut
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
    public class TimePatternId
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
}
