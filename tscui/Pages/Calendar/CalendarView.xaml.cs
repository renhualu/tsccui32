using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Windows;
using tscui.Service;
using System.Windows.Documents;
using System.Windows.Media;
using System.Threading;

namespace tscui.Pages.Calendar
{
    /// <summary>
    /// Interaction logic for CalendarView.xaml
    /// </summary>
    [View(typeof(CalendarViewModel))]
    public partial class CalendarView : UserControl,IView
    {
        public CalendarView()
        {
            InitializeComponent();

        }

        public void OnActivated()
        {
           // throw new NotImplementedException();
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
           // throw new NotImplementedException();
        }
        TscData t;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                {
                    return;
                }
                //t.ListPlan;
                List<Schedule> ls = t.ListSchedule;
                List<int> li = new List<int>();
                foreach (Schedule s in ls)
                {
                    if (!li.Contains(s.ucId) && s.ucId != 0)
                        li.Add(s.ucId);
                }

                cbxScheduleId.ItemsSource = li;
                List<Plan> lp = t.ListPlan;
                foreach (Plan p in lp)
                {
                    if (p.ucId >= 1 && p.ucId <= 20)
                    {
                        sldPlanId.Value = p.ucId;
                        cbxScheduleId.SelectedItem = Convert.ToInt32(p.ucScheduleId);
                        ushort month = p.usMonthFlag;
                        uint day = p.ulDayFlag;
                        DateTime datetime = DateTime.Now;
                        //for (int i = 1; i <= 12; i++)
                        //{
                        //    if (((month >> i) & 0x01) == 0x01)
                        //    {
                        //        for (int j = 1; j <= 31; j++)
                        //        {
                        //            if (((day >> j) & 0x01) == 0x01)
                        //            {
                        //                try
                        //                {
                        //                    calendar.SelectedDates.Add(new DateTime(datetime.Year, i, j));
                        //                }
                        //                catch (Exception ex)
                        //                {
                        //                    continue;
                        //                }

                        //            }
                        //        }
                        //    }
                        //}
                        //break;
                    }
                }
            }
            catch(Exception ex )
            {

            }
            
        }
      
        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedDatesCollection sdc = calendar.SelectedDates;
            List<Plan> lp = t.ListPlan;
            Plan pt = new Plan();
            foreach (Plan p in lp)
            {
                if(p.ucId == sldPlanId.Value)
                {
                    p.ucId = Convert.ToByte(sldPlanId.Value);
                    p.ucWeekFlag = 0xfe;
                    uint d = 0;
                    ushort m = 0;
                    p.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                    foreach (DateTime dt in sdc)
                    {
                        int month = dt.Month;
                        int day = dt.Day;

                        d = (uint)((1 << day) | d);
                        m = (ushort)((1 << month) | m);
                        p.usMonthFlag = m;
                        p.ulDayFlag = d;
                    }
                }
                else
                {
                    if (p.ucId >= 1 && p.ucId <= 20)
                    {
                        pt.ucId = Convert.ToByte(sldPlanId.Value);
                        pt.ucWeekFlag = 0xfe;
                        uint d = 0;
                        ushort m = 0;
                        pt.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                        foreach (DateTime dt in sdc)
                        {
                            int month = dt.Month;
                            int day = dt.Day;

                            d = (uint)((1 << day) | d);
                            m = (ushort)((1 << month) | m);
                            pt.usMonthFlag = m;
                            pt.ulDayFlag = d;
                        }
                    }
                    
                    break;
                }
            }
            if(pt.ucId == Convert.ToByte(sldPlanId.Value))
            {
                lp.Add(pt);
            }
            
        }

        private void tbkPlanId_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            Console.WriteLine(lp.ToString());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            TscDataUtils.SetPlanByCalendar(t.ListPlan);

        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            foreach (Plan p in t.ListPlan)
            {
                Console.WriteLine(p.ucId + " " + p.usMonthFlag + " " + p.ulDayFlag);
            }
        }
        private string descMonth2String(ushort month, uint day)
        {
            string str = "";
            for (int i = 1; i <= 12; i++)
            {
                if (((month >> i) & 0x01) == 0x01)
                {
                    string sday = "";
                    for (int j = 1; j <= 31; j++)
                    {
                        if (((day >> j) & 0x01) == 0x01)
                        {
                            sday = sday + " " + j;
                        }
                    }
                    str = "月份：【" + i + "】 - 日子：【" + sday + "】";
                }
            }
            return str;
        }
        private void sldPlanId_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //tbkMessage.Inlines.Add(new Run("这是测试1"));
            //tbkMessage.Inlines.Add(new LineBreak());
            
            tbkMessage.Foreground = new SolidColorBrush(Colors.RoyalBlue);
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Plan> lp = t.ListPlan;
            foreach(Plan p in lp)
            {
                if(p.ucId >=1 &&　p.ucId <=20)
                {
                    ushort month = p.usMonthFlag;
                    uint day = p.ulDayFlag;
                    for (int i = 1; i <= 12; i++)
                    {
                        if (((month >> i) & 0x01) == 0x01)
                        {
                            string sday = "";
                            for (int j = 1; j <= 31; j++)
                            {
                                if (((day >> j) & 0x01) == 0x01)
                                {
                                    sday = sday + " " + j;
                                }
                            }
                            // str = "月份：【" + i + "】 - 日子：【" + sday + "】";
                            tbkMessage.Inlines.Add(new Run("编号：【" + p.ucId + "】 " + "月份：【" + i + "】 - 日子：【" + sday + "】" + " 时段：【" + p.ucScheduleId + "】"));
                            tbkMessage.Inlines.Add(new LineBreak());
                        }
                    }
                }
                
                
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            { 
            ThreadPool.QueueUserWorkItem(SavePlanCalendar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calendar: " + ex.ToString());
            }
            tbkMessage.Text = "";
        }

        private void SavePlanCalendar(object state)
        {
            TscDataUtils.SetPlanByCalendar(t.ListPlan);
        }

        private void tbkMessage_Unloaded(object sender, RoutedEventArgs e)
        {
            tbkMessage.Text = "";
        }

    }
}
