using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using System.Windows;
using tscui.Models;
using System.Collections;
using Apex;
using tscui.Views;
using tscui.Service;
using System.Threading;

namespace tscui.Pages.BaseTime
{
    /// <summary>
    /// Interaction logic for SeasonTimeView.xaml
    /// </summary>
    [View(typeof(SeasonTimeViewModel))]
    public partial class SeasonTimeView : UserControl
    {
        public SeasonTimeView()
        {
            InitializeComponent();
        }

        private void Allday_IsEnabledChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {

        }

        private void Allday_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
           
            Monday.IsChecked = true;
            Thursday.IsChecked = true;
            Tuesday.IsChecked = true;
            Wednesday.IsChecked = true;
            Friday.IsChecked = true;
            Saturday.IsChecked = true;
            Sunday.IsChecked = true;
        }

        private void Allday_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            Monday.IsChecked = false;
            Thursday.IsChecked = false;
            Tuesday.IsChecked = false;
            Wednesday.IsChecked = false;
            Friday.IsChecked = false;
            Saturday.IsChecked = false;
            Sunday.IsChecked = false;
        }
        TscData td;

        private void initWeekdayDisplay(byte weekday)
        {
            //byte weekday = p.ucWeekFlag;
            for (int i = 1; i <= 7; i++)
            {
                if (((weekday >> i) & 0x01) == 0x01)
                {
                    if (i == 1)
                    {
                        Monday.IsChecked = true;
                    }
                    else if (i == 2)
                    {
                        Tuesday.IsChecked = true;
                    }
                    else if (i == 3)
                    {
                        Wednesday.IsChecked = true;
                    }
                    else if (i == 4)
                    {
                        Thursday.IsChecked = true;
                    }
                    else if (i == 5)
                    {
                        Friday.IsChecked = true;
                    }
                    else if (i == 6)
                    {
                        Saturday.IsChecked = true;
                    }
                    else if (i == 7)
                    {
                        Sunday.IsChecked = true;
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        Monday.IsChecked = false;
                    }
                    else if (i == 2)
                    {
                        Tuesday.IsChecked = false;
                    }
                    else if (i == 3)
                    {
                        Wednesday.IsChecked = false;
                    }
                    else if (i == 4)
                    {
                        Thursday.IsChecked = false;
                    }
                    else if (i == 5)
                    {
                        Friday.IsChecked = false;
                    }
                    else if (i == 6)
                    {
                        Saturday.IsChecked = false;
                    }
                    else if (i == 7)
                    {
                        Sunday.IsChecked = false;
                    }
                }
            }
        }
        private void initScheduleId()
        {
            List<tscui.Models.Schedule> ls = td.ListSchedule;
            List<byte> li = new List<byte>();
            foreach (Schedule s in ls)
            {
                if (!li.Contains(s.ucId) && s.ucId != 0)
                {
                    li.Add(s.ucId);
                }
            }
            cbxScheduleId.ItemsSource = li;
        }
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                td = (TscData)Application.Current.Properties[Define.TSC_DATA];
                initScheduleId();
                if (td == null)
                {
                    return;
                }
                List<Plan> lp = td.ListPlan;
                foreach(Plan p in lp)
                {
                    //如果没有数据不会进入
                    if (p.ucId>=21 && p.ucId <=30)
                    {
                        ///Summer.IsChecked = true;
                        lbxPlanId.Items.Add(p.ucId);
                        //initWeekdayDisplay(p.ucWeekFlag);

                    }
                    
                }


                cbxScheduleId.SelectedItem = (byte)1;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //ApexBroker.GetShell().ShowPopup(new FailePopup());
            }
        }

        private void lbxPlanId_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            Plan p1 = new Plan();
            foreach(Plan p in lp)
            {
                for (int i = 21; i <= 30;i++ )
                {
                    if (!(p.ucId == i) && !lbxPlanId.Items.Contains(Convert.ToByte(i)))
                    {
                        
                        p1.ucId = Convert.ToByte(i);
                        p1.ucScheduleId = 1;
                        p1.usMonthFlag = 0;
                        p1.ucWeekFlag = 0;
                        p1.ulDayFlag = 0;
                        break;
                    }
                }
                break;    
            }
            if (p1.ucId <= 30 && p1.ucId >=21)
            {
                lbxPlanId.Items.Add(p1.ucId);
                lp.Add(p1);
            }
            
        }


        private void lbxPlanId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            byte id = Convert.ToByte(lbxPlanId.SelectedItem);
            List<Plan> lp = td.ListPlan;
            foreach(Plan p in lp) 
            {
                if (p.ucId == id)
                {
                    cbxScheduleId.SelectedItem = p.ucScheduleId;
                    byte weekday =p.ucWeekFlag;
                    initWeekdayDisplay(weekday);
                    //Allday.IsChecked = false;
                }
            }
        }

        private void cbxScheduleId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    p.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                }
            }
        }

        private void Monday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if(p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x02);
                }
            }
        }

        private void Monday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0xfc);
                }
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach(Plan p in lp)
            {
                Console.WriteLine(p.ucWeekFlag);
            }
        }

        private void Tuesday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x04);
                }
            }
        }

        private void Wednesday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x08);
                }
            }
        }

        private void Thursday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x10);
                }
            }
        }

        private void Friday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x20);
                }
            }
        }

        private void Saturday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x40);
                }
            }
        }

        private void Sunday_Checked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag | 0x80);
                }
            }
        }

        private void Tuesday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0xfa);
                }
            }
        }

        private void Wednesday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0xf6);
                }
            }
        }

        private void Thursday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0xee);
                }
            }
        }

        private void Friday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0xde);
                }
            }
        }

        private void Saturday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0xbe);
                }
            }
        }

        private void Sunday_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.ucWeekFlag = (byte)(p.ucWeekFlag & 0x7e);
                }
            }
        }
        private void SavePlan()
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId >= 21 && p.ucId <= 30)
                {
                    p.usMonthFlag = 8190;
                    p.ulDayFlag = 4294967294;
                }
            }
            
            TscDataUtils.SetPlanByWeekend(td.Node.sIpAddress, td.Node.iPort, lp);
        }
        /// <summary>
        /// 多线程
        /// </summary>
        /// <param name="state"></param>
        private void SavePlan(object state)
        {
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId >= 21 && p.ucId <= 30)
                {
                    p.usMonthFlag = 8190;
                    p.ulDayFlag = 4294967294;
                }
            }

            TscDataUtils.SetPlanByWeekend(td.Node.sIpAddress, td.Node.iPort, lp);
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SavePlan();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            { 
            ThreadPool.QueueUserWorkItem(SavePlan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SeasonTime: " + ex.ToString());
            }
            //SavePlan();
        }
    }
}
