using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using System;
using System.Windows;
using System.Collections.Generic;
using tscui.Models;
using tscui.Service;

namespace tscui.Pages.Degradation
{
    /// <summary>
    /// Interaction logic for ThePagesView.xaml
    /// </summary>
    [View(typeof(DegradationViewModel))]
    public partial class DegradationView : UserControl, IView
    {
        public DegradationView()
        {
            InitializeComponent();
            viewModel.DegradationCommand.Executed += new CommandEventHandler(DegradationCommand_Executed);
        }

        void DegradationCommand_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
        }

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }

        private void Degradation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                tscui.Pages.Apex.ApexView.TscInfo ti = (tscui.Pages.Apex.ApexView.TscInfo)Application.Current.Properties[Define.TSC_INFO];
                int cbi = cbxDegradationModel.SelectedIndex;
                //
                int selectedItem = (int)cbxDegradationModel.SelectedValue;
                // String s = cbi.Content.ToString();
                if (selectedItem == 5)
                {
                    grdDegradation.Visibility = Visibility.Visible;
                    TscData td = (TscData)Application.Current.Properties[Define.TSC_DATA];
                    List<Pattern> ltp = td.ListPattern;
                    Dictionary<int, string> mydic = new Dictionary<int, string>();
                    for (int i = 1; i <= ltp.Count; i++)
                    {
                        mydic.Add(i, i.ToString());
                    }
                    

                    cbxDegradationBaseSchedule.ItemsSource = mydic;
                    cbxDegradationBaseSchedule.SelectedValuePath = "Key";
                    cbxDegradationBaseSchedule.DisplayMemberPath = "Value";
                }
                else
                {
                    grdDegradation.Visibility = Visibility.Hidden;
                    //byte[] byttmp = System.BitConverter.GetBytes(selectedItem);
                    //byte[] bbbb = { byttmp[0] };
                    //byte[] sendData = ByteUtils.concatByteArray(Define.DEGRADATION_UTC, bbbb);
                    //bool bl = Udp.sendUdp(ti.Ip, Define.GBT_PORT, sendData);
                    //if (bl)
                    //{
                    //    MessageBox.Show("联网降级数据保存成功！");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("联网降级数据保存失败！");
                    //}
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
            }

        }
        public void InitDegradation()
        {
            Dictionary<int, string> mydic = new Dictionary<int, string>() { 
            {1,"关灯"},
            {2,"闪光"},
            {3,"全红"},
            {5,"本地多时段"},
            {6,"感应"},
            {11,"主从线控"},
            {8,"单点优化"},
            {10,"手动控制"},
            {12,"系统优化"},
            {13,"干预线控"}
            
            };
            cbxDegradationModel.ItemsSource = mydic;
            cbxDegradationModel.SelectedValuePath = "Key";
            cbxDegradationModel.DisplayMemberPath = "Value";

        }
        public void InitcbxDegradationBaseSchedule()
        {
            Dictionary<int, string> mydic = new Dictionary<int, string>() { 
            {1,"1"},
            {2,"2"},
            {3,"3"},
            {4,"4"},
            {5,"5"},
            {6,"6"},
            {7,"7"},
            {8,"8"},
            {9,"9"},
            {10,"10"},
            {11,"11"},
            {12,"12"},
            {13,"13"},
            {14,"14"},
            {15,"15"},
            {16,"16"}
            };
            cbxDegradationBaseSchedule.ItemsSource = mydic;
            cbxDegradationBaseSchedule.SelectedValuePath = "Key";
            cbxDegradationBaseSchedule.DisplayMemberPath = "Value";

        }
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            if(td == null)
            {
                return;

            }
            grdDegradation.Visibility = Visibility.Hidden;
            InitDegradation();
            InitcbxDegradationBaseSchedule();
        }
        TscData td;
        private void cbxDegradationBaseSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           td = (TscData)Application.Current.Properties[Define.TSC_DATA];
           List<Pattern> ltp = td.ListPattern;
            foreach (Pattern tp in ltp)
            {
                int i =tp.ucPatternId;
                if (i == (int)cbxDegradationBaseSchedule.SelectedValue)
                {
                    lblCycle.Content = tp.ucCycleTime+"秒";
                    List<StagePattern> lsp = td.ListStagePattern;
                    int countSP = 0;
                    foreach (StagePattern sp in lsp)
                    {
                        if (tp.ucStagePatternId == sp.ucStagePatternId && sp.usAllowPhase != 0)
                        {
                            countSP++;
                        }
                    }
                    lblStage.Content = countSP+"个";
                }
            }
        }
    }
}
