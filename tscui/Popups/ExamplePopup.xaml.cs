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
using Apex;
using Xceed.Wpf.Toolkit;
using tscui.Models;
using tscui.Service;
using System.Windows.Threading;
using System.Threading;

namespace tscui.Views
{
    public delegate void RadioSelectedHandler();
    /// <summary>
    /// Interaction logic for ExamplePopup.xaml
    /// </summary>
    public partial class ExamplePopup : UserControl
    {
      //  public event RadioSelectedHandler RadioSelectedEvent;

        public ExamplePopup()
        {
            InitializeComponent();
        }
        private delegate void DelegateSavePhase();
        private void DispatcherSavePhase()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateSavePhase(SavePhase));
        }
        private void SavePhase()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE)
            {
                foreach (Phase p in t.ListPhase)
                {
                    if (p.ucId == currentPhaseId)
                    {
                        //Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP_TYPE] = Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE;
                        Utils.Utils.SetPhaseByCurrent(p);
                    }
                }
            }
            else if (Utils.Utils.GetPhaseOverlapPhaseType() == Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE)
            {
                foreach (OverlapPhase op in t.ListOverlapPhase)
                {
                    if (op.ucId == currentOverlapPhase)
                    {
                        Utils.Utils.SetOverLapPhaseByCurrent(op);
                    }
                }
            }
        }
        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            Thread tDispatcherSavePhase = new Thread(DispatcherSavePhase);
            tDispatcherSavePhase.IsBackground = true;
            tDispatcherSavePhase.Start();
            
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //foreach(Phase p in t.ListPhase)
            //{
            //    Console.WriteLine(p.ucId);
            //}
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void rbnOverlapPhase1_Click(object sender, RoutedEventArgs e)
        {

            //splOverlapPhase.Visibility = Visibility.Visible;
           // splPhase.Visibility = Visibility.Hidden;
        }

        private void rbnPhase1_Click(object sender, RoutedEventArgs e)
        {
            //splPhase.Visibility = Visibility.Visible;
            //splOverlapPhase.Visibility = Visibility.Hidden;
        }

        private void rbnPhase1_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
        private delegate void DelegateInitPhaseType();
        private void DispatcherInitPhaseType()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitPhaseType(InitPhaseType));
        }
        private void InitPhaseType()
        {
            List<PhaseType> lpt = new List<PhaseType>();
            lpt.Add(new PhaseType() { typeName = "固定相位", ucType = 0x80 });
            lpt.Add(new PhaseType() { typeName = "特定相位", ucType = 0x40 });
            lpt.Add(new PhaseType() { typeName = "弹性相位", ucType = 0x20 });
            lpt.Add(new PhaseType() { typeName = "关键相位", ucType = 0x10 });
            cbxPhaseType.ItemsSource = lpt;
        }
        private delegate void DelegatePhaseOption();
        private void DispatcherPhaseOption()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegatePhaseOption(InitPhaseOption));
        }
        private void InitPhaseOption()
        {
            List<PhaseOption> lpo = new List<PhaseOption>();
            lpo.Add(new PhaseOption() { optionName = "同阶放行", ucOption = 0x10 });
            lpo.Add(new PhaseOption() { optionName = "人车放行", ucOption = 0x08 });
            lpo.Add(new PhaseOption() { optionName = "特定相位出现", ucOption = 0x04 });
            lpo.Add(new PhaseOption() { optionName = "人行过街相位", ucOption = 0x02 });
            lpo.Add(new PhaseOption() { optionName = "相位启用", ucOption = 0x01 });
            cbxPhaseOption.ItemsSource = lpo;
        }

        private delegate void DelegateOverlapPhaseType();
        private void DispatcherOverlapPhaseType()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateOverlapPhaseType(InitOverlapPhaseType));
        }
        private void InitOverlapPhaseType()
        {
            List<OverlapPhaseType> lopt = new List<OverlapPhaseType>();
            lopt.Add(new OverlapPhaseType() { name = "其它", value = 1 });
            lopt.Add(new OverlapPhaseType() { name = "正常", value = 2 });
            lopt.Add(new OverlapPhaseType() { name = "最小绿灯黄灯", value = 3 });
            cbxOperateType.ItemsSource = lopt;

        }
        private delegate void DelegateOverlap();
        private void DispatcherOverlap()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateOverlap(InitOverlap));
        }
        private void InitOverlap()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();

            List<Phase> lp = t.ListPhase;
            ccbIncludePhase1.ItemsSource = lp;
            ccbIncludePhase2.ItemsSource = lp;
            ccbIncludePhase3.ItemsSource = lp;
            ccbIncludePhase4.ItemsSource = lp;
            ccbIncludePhase5.ItemsSource = lp;
            ccbIncludePhase6.ItemsSource = lp;
            ccbIncludePhase7.ItemsSource = lp;
            ccbIncludePhase8.ItemsSource = lp;
            ccbIncludePhase9.ItemsSource = lp;
            ccbIncludePhase10.ItemsSource = lp;
            ccbIncludePhase11.ItemsSource = lp;
            ccbIncludePhase12.ItemsSource = lp;
            ccbIncludePhase13.ItemsSource = lp;
            ccbIncludePhase14.ItemsSource = lp;
            ccbIncludePhase15.ItemsSource = lp;
            ccbIncludePhase16.ItemsSource = lp;
            ccbCorrectPhase.ItemsSource = lp;
            ccbCorrectPhase2.ItemsSource = lp;
            ccbCorrectPhase3.ItemsSource = lp;
            ccbCorrectPhase4.ItemsSource = lp;
            ccbCorrectPhase5.ItemsSource = lp;
            ccbCorrectPhase6.ItemsSource = lp;
            ccbCorrectPhase7.ItemsSource = lp;
            ccbCorrectPhase8.ItemsSource = lp;
            ccbCorrectPhase9.ItemsSource = lp;
            ccbCorrectPhase10.ItemsSource = lp;
            ccbCorrectPhase11.ItemsSource = lp;
            ccbCorrectPhase12.ItemsSource = lp;
            ccbCorrectPhase13.ItemsSource = lp;
            ccbCorrectPhase14.ItemsSource = lp;
            ccbCorrectPhase15.ItemsSource = lp;
            ccbCorrectPhase16.ItemsSource = lp;

            cbxOverlapPhaseChannel1.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel2.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel3.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel4.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel5.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel6.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel7.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel8.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel9.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel10.ItemsSource = t.ListChannel;

            cbxOverlapPhaseChannel11.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel12.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel13.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel14.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel15.ItemsSource = t.ListChannel;
            cbxOverlapPhaseChannel16.ItemsSource = t.ListChannel;

          

        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                return;
            }
            Thread tDispatcherOverlap = new Thread(DispatcherOverlap);
            tDispatcherOverlap.IsBackground = true;
            tDispatcherOverlap.Start();
            Thread tDispatcherOverlapPhaseType = new Thread(DispatcherOverlapPhaseType);
            tDispatcherOverlapPhaseType.IsBackground = true;
            tDispatcherOverlapPhaseType.Start();
            Thread tDispatcherPhaseOption = new Thread(DispatcherPhaseOption);
            tDispatcherPhaseOption.IsBackground = true;
            tDispatcherPhaseOption.Start();
            Thread tDispatcherInitPhaseType = new Thread(DispatcherInitPhaseType);
            tDispatcherInitPhaseType.IsBackground = true;
            tDispatcherInitPhaseType.Start();
        }
        
        private void PedestrainClearTime_Spin(object sender, Xceed.Wpf.Toolkit.SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        
        }

        private void PedestrainCrossTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrGreenTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrYellowTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrRedTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }
        TscData t;

        private void displayPhase(int pid, List<Phase> lp)
        {
            foreach (Phase p in lp)
            {
                if (p.ucId == pid)
                {
                    cbxPhaseType.SelectedItem = p.ucType;
                    cbxPhaseOption.SelectedItem = p.ucOption;
                    TextBox tbpc = (TextBox)bsrPedestrainCrossTime.Content;
                    tbpc.Text = Convert.ToString(p.ucPedestrianGreen);
                    TextBox tbpct = (TextBox)bsrPedestrainClearTime.Content;
                    tbpct.Text = Convert.ToString(p.ucPedestrianClear);
                    TextBox tbGreenFlash = (TextBox)bsrGreenFlash.Content;
                    tbGreenFlash.Text = Convert.ToString(p.ucGreenFlash);
                    TextBox tbMax2Time = (TextBox)bsrMax2Time.Content;
                    tbMax2Time.Text = Convert.ToString(p.ucMaxGreen2);
                    TextBox tbMax1Time = (TextBox)bsrMax1Time.Content;
                    tbMax1Time.Text = Convert.ToString(p.ucMaxGreen1);
                    TextBox tbUintDelayTime = (TextBox)bsrUintDelayTime.Content;
                    tbUintDelayTime.Text = Convert.ToString(p.ucGreenDelayUnit);
                    TextBox tbFixedGreenTime = (TextBox)bsrFixedGreenTime.Content;
                    tbFixedGreenTime.Text = Convert.ToString(p.ucFixedGreen);
                    TextBox tbMinGreenTime = (TextBox)bsrMinGreenTime.Content;
                    tbMinGreenTime.Text = Convert.ToString(p.ucMinGreen);


                }
            }
        }


        private void bsrMax2Time_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrMax1Time_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrUintDelayTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrFixedGreenTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrMinGreenTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrGreenFlash_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }
        private void p29_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(29, lp);
            currentPhaseId = 29;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }
        private void p30_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(30, lp);
            currentPhaseId = 30;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p31_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(31, lp);
            currentPhaseId = 31;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p32_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(32, lp);
            currentPhaseId = 32;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p25_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(25, lp);
            currentPhaseId = 25;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p26_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(26, lp);
            currentPhaseId = 26;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p27_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(27, lp);
            currentPhaseId = 27;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p28_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(28, lp);
            currentPhaseId = 28;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p21_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(21, lp);
            currentPhaseId = 21;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p22_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(22, lp);
            currentPhaseId = 22;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p23_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(23, lp);
            currentPhaseId = 23;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p24_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(24, lp);
            currentPhaseId = 24;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p17_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(17, lp);
            currentPhaseId = 17;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p18_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(18, lp);
            currentPhaseId = 18;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p19_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(19, lp);
            currentPhaseId = 19;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p20_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(20, lp);
            currentPhaseId = 20;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p13_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(13, lp);
            currentPhaseId = 13;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p14_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(14, lp);
            currentPhaseId = 14;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p15_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(15, lp);
            currentPhaseId = 15;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p16_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(16, lp);
            currentPhaseId = 16;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p9_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(9, lp);
            currentPhaseId = 9;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p10_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(10, lp);
            currentPhaseId = 10;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p11_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(11, lp);
            currentPhaseId = 11;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p12_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(12, lp);
            currentPhaseId = 12;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p5_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(5, lp);
            currentPhaseId = 5;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p6_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(6, lp);
            currentPhaseId = 6;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p7_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(7, lp);
            currentPhaseId = 7;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p8_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(8, lp);
            currentPhaseId = 8;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p1_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(1, lp);
            currentPhaseId = 1;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p2_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(2, lp);
            currentPhaseId = 2;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p3_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(3, lp);
            currentPhaseId = 3;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }

        private void p4_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            displayPhase(4, lp);
            currentPhaseId = 4;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
        }
        int currentPhaseId = 0;
        private void cbxPhaseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            ComboBox cb = sender as ComboBox;
            PhaseType pt = (PhaseType)cb.SelectedValue;
            foreach(Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucType = Convert.ToByte(pt.ucType);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach(Phase p in lp)
            {
                if(p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }

        }

        private void tbxPedestrainCrossTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxGreenFlash_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxMax2Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxMax1Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxUintDelayTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxFixedGreenTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxMinGreenTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void cbxPhaseOption_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Phase> lp = t.ListPhase;
            ComboBox cb = sender as ComboBox;
            PhaseOption po = (PhaseOption)cb.SelectedValue;
            foreach (Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucType = Convert.ToByte(po.ucOption);
                }
            }
        }
        private void SetIncludePhaseToOverlapPhase(CheckComboBox ccb,int pUcId)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == pUcId)
                {
                    List<byte> lb = new List<byte>();
                    foreach (Object o in ccb.SelectedItems)
                    {
                        Phase po = (Phase)o;
                        lb.Add(po.ucId);//po.ucId
                    }
                    op.ucIncludePhase = lb.ToArray<byte>();
                }
            }
        }
        private void SetCorrectPhaseToOverlapPhase(CheckComboBox ccb,int opUcId)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == opUcId)
                {
                    List<byte> lb = new List<byte>();
                    foreach (Object o in ccb.SelectedItems)
                    {
                        Phase po = (Phase)o;
                        lb.Add(po.ucId);//po.ucId
                    }
                    op.ucCorrectPhase = lb.ToArray<byte>();
                }
            }
        }
        private void ccbIncludePhase1_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,1);
        }

        private void ccbCorrectPhase_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,1);
        }

        private void ccbIncludePhase2_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,2);
        }

        private void ccbIncludePhase3_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,3);
        }

        private void ccbIncludePhase4_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,4);
        }

        private void ccbIncludePhase5_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,5);
        }

        private void ccbIncludePhase6_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,6);
        }

        private void ccbIncludePhase7_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,7);
        }

        private void ccbIncludePhase8_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,8);
        }

        private void ccbIncludePhase9_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,9);
        }

        private void ccbIncludePhase10_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,10);
        }

        private void ccbIncludePhase11_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,11);
        }

        private void ccbIncludePhase12_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,12);
        }

        private void ccbIncludePhase13_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,13);
        }

        private void ccbIncludePhase14_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,14);
        }

        private void ccbIncludePhase15_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,15);
        }

        private void ccbIncludePhase16_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetIncludePhaseToOverlapPhase(ccb,16);
        }

        private void ccbCorrectPhase2_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,2);
        }

        private void ccbCorrectPhase3_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,3);
        }

        private void ccbCorrectPhase4_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,4);
        }

        private void ccbCorrectPhase5_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,5);
        }

        private void ccbCorrectPhase6_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,6);
        }

        private void ccbCorrectPhase7_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,7);
        }

        private void ccbCorrectPhase8_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,8);
        }

        private void ccbCorrectPhase9_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,9);
        }

        private void ccbCorrectPhase10_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,10);
        }

        private void ccbCorrectPhase11_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,11);
        }

        private void ccbCorrectPhase12_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,12);
        }

        private void ccbCorrectPhase13_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,13);
        }

        private void ccbCorrectPhase14_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,14);
        }

        private void ccbCorrectPhase15_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,15);
        }

        private void ccbCorrectPhase16_ItemSelectionChanged(object sender, Xceed.Wpf.Toolkit.Primitives.ItemSelectionChangedEventArgs e)
        {
            CheckComboBox ccb = sender as CheckComboBox;
            SetCorrectPhaseToOverlapPhase(ccb,16);
        }
        private void SetOverlapPhaseToChannel(ComboBox cb,byte id)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Channel cc= (Channel)cb.SelectedValue;
            byte cId = Convert.ToByte(cc.ucId);
            List<Channel> lc = t.ListChannel;
            foreach (Channel c in lc)
            {
                if (c.ucId == cId)
                {
                    c.ucSourcePhase = id;
                }
            }
        }
        private void cbxOverlapPhaseChannel1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            //string v = (string)cb.SelectedValue;
            //string v1 = (string)cb.SelectedItem;
            //int v2 = cb.SelectedIndex;
            //string v11 = (string)cb.Text;
            SetOverlapPhaseToChannel(cb, 1);
           
        }

        private void cbxOverlapPhaseChannel2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 2);
        }

        private void cbxOverlapPhaseChannel3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 3);
        }

        private void cbxOverlapPhaseChannel4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 4);
        }

        private void cbxOverlapPhaseChannel5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 5);
        }

        private void cbxOverlapPhaseChannel6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 6);
        }

        private void cbxOverlapPhaseChannel7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 7);
        }

        private void cbxOverlapPhaseChannel8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 8);
        }

        private void cbxOverlapPhaseChannel9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 9);
        }

        private void cbxOverlapPhaseChannel10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 10);
        }

        private void cbxOverlapPhaseChannel11_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 11);
        }

        private void cbxOverlapPhaseChannel12_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 12);
        }

        private void cbxOverlapPhaseChannel13_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 13);
        }

        private void cbxOverlapPhaseChannel14_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 14);
        }

        private void cbxOverlapPhaseChannel15_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 15);
        }

        private void cbxOverlapPhaseChannel16_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 16);
        }
        private byte currentOverlapPhase = 0;
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach(OverlapPhase op in t.ListOverlapPhase)
            {
                if(op.ucId == currentOverlapPhase)
                {
                    op.ucTailGreen = Convert.ToByte(tb.Text);
                }
            }
        }

        private void TextBox_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailYellow = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxTailRed_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailRed = Convert.ToByte(tb.Text);
                }
            }
        }

        private void cbxOperateType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            OverlapPhaseType opt = (OverlapPhaseType)cb.SelectedValue;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailRed = Convert.ToByte(opt.value);
                }
            }
        }
        private void DisplayOverlapPhase(RadioButton rb ,List<OverlapPhase> lop)
        {
            foreach(OverlapPhase op in lop)
            {
                if(op.ucId == Convert.ToByte(rb.Content))
                {
                    tbxTailGreen.Text = Convert.ToString(op.ucTailGreen);
                    tbxYellowTime.Text = Convert.ToString(op.ucTailYellow);
                    tbxRedTime.Text = Convert.ToString(op.ucTailRed);
                    cbxOperateType.SelectedValue = op.ucOperateType;
                }
            }
        }
        private void DisplayOverlapPhase(byte id)
        {
            try
            {
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                foreach (OverlapPhase op in t.ListOverlapPhase)
                {
                    if (id == 1)
                    {
                        for (int a = 0; a < op.ucIncludePhase.Length; a++)
                        {
                            if (op.ucIncludePhase[a] != 0)
                            {
                                ccbIncludePhase1.Items.Add(op.ucIncludePhase[a]);
                            }
                        }
                        for (int a = 0; a < op.ucCorrectPhase.Length; a++)
                        {
                            if (op.ucCorrectPhase[a] != 0)
                            {
                                ccbCorrectPhase.Items.Add(op.ucCorrectPhase[a]);
                            }
                        }
                        tbxYellowTime.Text = Convert.ToString(op.ucTailYellow);
                        tbxRedTime.Text = Convert.ToString(op.ucTailRed);
                        tbxTailGreen.Text = Convert.ToString(op.ucTailGreen);
                        cbxOperateType.SelectedValue = op.ucOperateType;
                    }
                }
            }
            catch(Exception ex )
            {
                //Xceed.Wpf.Toolkit.MessageBox.Show("请重新选择一个跟随相位");
            }
            
        }
        private void rbnOverlapPhase1_Checked(object sender, RoutedEventArgs e)
        {
            
            currentOverlapPhase = 1;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(1);
        }

        private void rbnOverlapPhase2_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 2;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(2);
        }

        private void rbnOverlapPhase3_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 3;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(3);
        }

        private void rbnOverlapPhase4_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 4;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(4);
        }

        private void rbnOverlapPhase5_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 5;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(5);
        }

        private void rbnOverlapPhase6_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 6;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(6);
        }

        private void rbnOverlapPhase7_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 7;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(7);
        }

        private void rbnOverlapPhase8_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 8;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(8);
        }

        private void rbnOverlapPhase9_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 9;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(9);
        }

        private void rbnOverlapPhase10_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 10;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(10);
        }

        private void rbnOverlapPhase11_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 11;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(11);
        }

        private void rbnOverlapPhase12_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 12;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(12);
        }

        private void rbnOverlapPhase13_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 13;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(13);
        }

        private void rbnOverlapPhase14_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 14;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(14);
        }

        private void rbnOverlapPhase15_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 15;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(15);
        }

        private void rbnOverlapPhase16_Checked(object sender, RoutedEventArgs e)
        {
            currentOverlapPhase = 16;
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            DisplayOverlapPhase(16);
        }

  
    }
    public class OverlapPhaseType
    {
        public string name { set; get; }
        public byte value { set; get; }
    }
    public class PhaseType
    {
        public string typeName { set; get; }
        public byte ucType { set; get; }
    }
    public class PhaseOption
    {
        public string optionName { set; get; }
        public byte ucOption { set; get; }
    }
}
