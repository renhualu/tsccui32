using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using tscui.Service;
using System.Threading;
using System.Windows;

namespace tscui.Pages.BaseTime
{
    /// <summary>
    /// Interaction logic for BaseTimeView.xaml
    /// </summary>
    [View(typeof(BaseTimeViewModel))]
    public partial class BaseTimeView : UserControl,IView
    {
        public BaseTimeView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //throw new NotImplementedException();
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

        private void btnRead_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach(Plan p in lp)
            {
                Console.WriteLine(p.usMonthFlag);
            }
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TscDataUtils.SetPlanByCalendar(t.ListPlan);
        }
        TscData t;
        private void initMonth(ushort month)
        {
            //ushort month = p.usMonthFlag;
            for (int i = 1; i <= 12; i++)
            {
                if (((month >> i) & 0x01) == 0x01)
                {
                    if(i ==1)
                    {
                        cbxJanuary.IsChecked = true;
                    }
                    if (i ==2)
                    {
                        cbxFebruary.IsChecked = true;
                    }
                    if(i == 3)
                    {
                        cbxMarch.IsChecked = true;
                    }
                    if(i ==4)
                    {
                        cbxApril.IsChecked = true;
                    }
                    if(i ==5 )
                    {
                        cbxMay.IsChecked = true;
                    }
                    if(i==6)
                    {
                        cbxJune.IsChecked = true;
                    }
                    if(i==7)
                    {
                        cbxJuly.IsChecked = true;
                    }
                    if(i ==8)
                    {
                        cbxAugust.IsChecked = true;
                    }
                    if(i == 9)
                    {
                        cbxSeptember.IsChecked = true;
                    }
                    if(i==10)
                    {
                        cbxOctober.IsChecked = true;
                    }
                    if(i==11)
                    {
                        cbxNovember.IsChecked = true;
                    }
                    if(i==12)
                    {
                        cbxDecember.IsChecked = true;
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        cbxJanuary.IsChecked = false;
                    }
                    if (i == 2)
                    {
                        cbxFebruary.IsChecked = false;
                    }
                    if (i == 3)
                    {
                        cbxMarch.IsChecked = false;
                    }
                    if (i == 4)
                    {
                        cbxApril.IsChecked = false;
                    }
                    if (i == 5)
                    {
                        cbxMay.IsChecked = false;
                    }
                    if (i == 6)
                    {
                        cbxJune.IsChecked = false;
                    }
                    if (i == 7)
                    {
                        cbxJuly.IsChecked = false;
                    }
                    if (i == 8)
                    {
                        cbxAugust.IsChecked = false;
                    }
                    if (i == 9)
                    {
                        cbxSeptember.IsChecked = false;
                    }
                    if (i == 10)
                    {
                        cbxOctober.IsChecked = false;
                    }
                    if (i == 11)
                    {
                        cbxNovember.IsChecked = false;
                    }
                    if (i == 12)
                    {
                        cbxDecember.IsChecked = false;
                    }
                }
            }
        }
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                this._loading.Visibility = System.Windows.Visibility.Visible;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if(t == null)
                {
                    return;
                }
                List<Plan> lp = t.ListPlan;
                List<Schedule> ls = t.ListSchedule;
                List<byte> lb = new List<byte>();
                foreach (Schedule s in ls)
                {
                    if (!lb.Contains(s.ucId) && s.ucEventId != 0)
                    {
                        lb.Add(s.ucId);
                    }
                }
                cbxScheduleId.ItemsSource = lb;
                foreach (Plan p in lp)
                {
                    if (p.ucId >= 31 && p.ucId <= 40)
                    {
                        lbxPlanId.Items.Add(p.ucId);
                        cbxScheduleId.SelectedItem = p.ucScheduleId;
                        initMonth(p.usMonthFlag);
                        break;
                    }
                }
                this._loading.Visibility = System.Windows.Visibility.Collapsed;
            }
            catch(Exception ex)
            {

            }
            
        }

        private void lbxPlanId_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            Plan pt = new Plan();
            foreach(Plan p in lp)
            {
                    for(byte i=31; i<=40;i++)
                    {
                        if (!lbxPlanId.Items.Contains(i) && !(p.ucId == i))
                        {
                            
                             pt.ucId = i;
                             pt.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                             pt.ucWeekFlag = 254;
                             pt.ulDayFlag = 4294967294;
                             pt.usMonthFlag = 0;
                             break;
                         }
                    }
                    break;
            }
             if(pt.ucId >=31 && pt.ucId <= 40)
                {
                    lbxPlanId.Items.Add(pt.ucId);
                    lp.Add(pt);
                }
        }

        private void lbxPlanId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            byte id = Convert.ToByte(lbxPlanId.SelectedItem);
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == id)
                {
                    cbxScheduleId.SelectedItem = p.ucScheduleId;
                    ushort month = p.usMonthFlag;
                    initMonth(month);
                    //Allday.IsChecked = false;
                }
            }
        }

        private void cbxScheduleId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    p.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                }
            }
        }

        private void cbxJanuary_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8188);
                }
            }
        }

        private void cbxJanuary_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 0x02);
                }
            }
        }

        private void cbxFebruary_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 0x04);
                }
            }
        }

        private void cbxMarch_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 0x08);
                }
            }
        }

        private void cbxApril_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 0x10);
                }
            }
        }

        private void cbxMay_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 32);
                }
            }
        }

        private void cbxJune_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 64);
                }
            }
        }

        private void cbxJuly_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 128);
                }
            }
        }

        private void cbxAugust_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 256);
                }
            }
        }

        private void cbxSeptember_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 512);
                }
            }
        }

        private void cbxOctober_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 1024);
                }
            }
        }

        private void cbxNovember_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 2048);
                }
            }
        }

        private void cbxDecember_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag | 4096);
                }
            }
        }

        private void cbxFebruary_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8186);
                }
            }
        }

        private void cbxMarch_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8182);
                }
            }
        }

        private void cbxApril_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8174);
                }
            }
        }

        private void cbxMay_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8158);
                }
            }
        }

        private void cbxJune_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8126);
                }
            }
        }

        private void cbxJuly_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 8062);
                }
            }
        }

        private void cbxAugust_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 7934);
                }
            }
        }

        private void cbxSeptember_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 7678);
                }
            }
        }

        private void cbxOctober_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 7166);
                }
            }
        }

        private void cbxNovember_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 6142);
                }
            }
        }

        private void cbxDecember_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Plan> lp = t.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {

                    p.usMonthFlag = (ushort)(p.usMonthFlag & 4094);
                }
            }
        }

        private void cbxAllMonth_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            cbxJanuary.IsChecked = true;
            cbxFebruary.IsChecked = true;
            cbxMarch.IsChecked = true;
            cbxApril.IsChecked = true;
            cbxMay.IsChecked = true;
            cbxJune.IsChecked = true;
            cbxJuly.IsChecked = true;
            cbxAugust.IsChecked = true;
            cbxSeptember.IsChecked = true;
            cbxOctober.IsChecked = true;
            cbxNovember.IsChecked = true;
            cbxDecember.IsChecked = true;
        }

        private void cbxAllMonth_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            cbxJanuary.IsChecked = false;
            cbxFebruary.IsChecked = false;
            cbxMarch.IsChecked = false;
            cbxApril.IsChecked = false;
            cbxMay.IsChecked = false;
            cbxJune.IsChecked = false;
            cbxJuly.IsChecked = false;
            cbxAugust.IsChecked = false;
            cbxSeptember.IsChecked = false;
            cbxOctober.IsChecked = false;
            cbxNovember.IsChecked = false;
            cbxDecember.IsChecked = false;
        }
        private void savePlanByClaendar(object state)
        {
            TscDataUtils.SetPlanByCalendar(t.ListPlan);
        }
        private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(savePlanByClaendar);
            }catch(Exception ex)
            {
                MessageBox.Show("BaseTime: " + ex.ToString());
            }
            
        }
    }
}
