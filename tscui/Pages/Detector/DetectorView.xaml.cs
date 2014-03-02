using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using Apex;
using tscui.Popups;
using Apex.Shells;
using System.Windows;
using tscui.Models;
using tscui.Service;
using System.Threading;
using System.Windows.Threading;

namespace tscui.Pages.Detector
{
    /// <summary>
    /// Interaction logic for DetectorView.xaml
    /// </summary>
    [View(typeof(DetectorViewModel))]
    public partial class DetectorView : UserControl,IView
    {
        public DetectorView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            SlideFadeInBehaviour.DoSlideFadeIn(this);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector1.Executed += new CommandEventHandler(ShowPopupCommandDetector1_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector2.Executed += new CommandEventHandler(ShowPopupCommandDetector2_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector3.Executed += new CommandEventHandler(ShowPopupCommandDetector3_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector4.Executed += new CommandEventHandler(ShowPopupCommandDetector4_Executed);
        }

        void ShowPopupCommandDetector4_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        void ShowPopupCommandDetector3_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        void ShowPopupCommandDetector2_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        void ShowPopupCommandDetector1_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        public void OnDeactivated()
        {
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector1.Executed -= new CommandEventHandler(ShowPopupCommandDetector1_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector2.Executed -= new CommandEventHandler(ShowPopupCommandDetector2_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector3.Executed -= new CommandEventHandler(ShowPopupCommandDetector3_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector4.Executed -= new CommandEventHandler(ShowPopupCommandDetector4_Executed);
        }

        private void image19_ImageFailed(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {

        }

        private void image1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        private void image21_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        private void image20_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northOtherDetector3_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northOtherDetector1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            IShell theShell = ApexBroker.GetShell();
            theShell.ShowPopup(new DetectorPopup());
            //theShell.
            //theShell.
        }

        private void tbkD1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tbkd = sender as TextBlock;
            DragDrop.DoDragDrop(tbkd, tbkd, DragDropEffects.Move);
        }

        private void tbkD2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tbkd = sender as TextBlock;
            DragDrop.DoDragDrop(tbkd, tbkd, DragDropEffects.Move);
        }

        private void canvasNorthOtherDetector1_Drop(object sender, System.Windows.DragEventArgs e)
        {
            e.Data.GetFormats();
            if(e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                Canvas cv = sender as Canvas;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                WrapPanel wp = tbkd.Parent as WrapPanel;
                wp.Children.Remove(tbkd);
                cv.Children.Add(tbkd);
            }
            
            Console.WriteLine(e.Data);
        }

        private void canvasNorthOtherDetector2_Drop(object sender, System.Windows.DragEventArgs e)
        {
            e.Data.GetFormats();
            if (e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                TextBlock cv = sender as TextBlock;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                cv.Text = tbkd.Text;
                tbkd.Text = "";
                Console.WriteLine(cv.Text);
            }
        }

        private void t_Drop(object sender, DragEventArgs e)
        {
            e.Data.GetFormats();
            if (e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                TextBlock cv = sender as TextBlock;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                cv.Text = tbkd.Text;
                tbkd.Text = "";
                Console.WriteLine(cv.Text);
            }
        }

        private void tbkD1_Drop(object sender, DragEventArgs e)
        {
            e.Data.GetFormats();
            if (e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                TextBlock cv = sender as TextBlock;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                cv.Text = tbkd.Text;
                tbkd.Text = "";
                Console.WriteLine(cv.Text);
            }
        }
        TscData t;
        public byte GetPhaseIdByDirec(byte direc)
        {
            byte result = new byte();
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach(PhaseToDirec ptd in lptd)
            {
                if(ptd.ucId == direc)
                {
                    result =  ptd.ucPhase;
                }
            }
            return result;
        }
        public byte GetOptionByCheckbox()
        {
            byte re = new byte();
            if(cbxCarType.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x01);
            }
            if(cbxKeyRoad.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x02);
            }
            if(cbxFlow.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x04);
            }
            if (cbxOccupancy.IsChecked ==true)
            {
                re = Convert.ToByte(re | 0x08);
            }
            if (cbxSpeed.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x10);
            }
            if(cbxQueun.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x20);
            }
            return re;
        }
        private byte GetDirecByte(byte direc)
        {
            byte result = new byte();
            if (direc >= Define.NORTH_TURN_AROUND && direc <= Define.NORTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x01;
            }
            else if (direc >= Define.EAST_NORTH_TURN_AROUND && direc <=Define.EAST_NORTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x02;
            }
            else if (direc >= Define.EAST_TURN_AROUND && direc <= Define.EAST_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x04;
            }
            else if (direc >= Define.EAST_SOUTH_TURN_AROUND && direc <= Define.EAST_SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x08;
            }
            else if (direc >= Define.SOUTH_TURN_AROUND && direc <= Define.SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x10;
            }
            else if (direc >= Define.WEST_SOUTH_TURN_AROUND && direc <= Define.WEST_SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x20;
            }
            else if (direc >= Define.WEST_TURN_AROUND && direc <= Define.WEST_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x40;
            }
            else if (direc >= Define.WEST_NORTH_TURN_AROUND && direc <= Define.WEST_NORTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x80;
            }
            return result;
        }
        public byte GetDetFlag(int type,byte direc)
        {
            byte result = new byte();
           if(direc == Define.NORTH_OTHER || direc == Define.WEST_OTHER || direc == Define.EAST_OTHER || direc == Define.SOUTH_OTHER)
           {
               if (type == 1)
               {
                   result = Define.DETECTOR_TYPE_STATEGY_BUS;
               }
               else if (type == 2)
               {
                   result = Define.DETECTOR_TYPE_REACTION_BUS;
               }
               else if (type == 3)
               {
                   result = Define.DETECTOR_TYPE_TACTICS_BUS;
               }
               else if (type == 4)
               {
                   result = Define.DETECTOR_TYPE_REQUEST_BUS;
               }
           }
           else if (direc == Define.NORTH_PEDESTRAIN_ONE || direc == Define.NORTH_PEDESTRAIN_TWO || direc == Define.EAST_PEDESTRAIN_ONE || direc == Define.EAST_PEDESTRAIN_TWO || direc == Define.SOUTH_PEDESTRAIN_ONE || direc == Define.SOUTH_PEDESTRAIN_TWO || direc == Define.WEST_PEDESTRAIN_ONE || direc == Define.WEST_PEDESTRAIN_TWO)
           {
               if (type == 1)
               {
                   result = Define.DETECTOR_TYPE_STATEGY_HUMAN;
               }
               else if (type == 2)
               {
                   result = Define.DETECTOR_TYPE_REACTION_HUMAN;
               }
               else if (type == 3)
               {
                   result = Define.DETECTOR_TYPE_TACTICS_HUMAN;
               }
               else if (type == 4)
               {
                   result = Define.DETECTOR_TYPE_REQUEST_HUMAN;
               }
           }
           else
           {
               if (type == 1)
               {
                   result = Define.DETECTOR_TYPE_STATEGY_CAR;
               }
               else if (type == 2)
               {
                   result = Define.DETECTOR_TYPE_REACTION_CAR;
               }
               else if (type == 3)
               {
                   result = Define.DETECTOR_TYPE_TACTICS_CAR;
               }
               else if (type == 4)
               {
                   result = Define.DETECTOR_TYPE_REQUEST_CAR;
               }
           }
            
            return result;
        }
        /// <summary>
        /// 设置检测器，在哪个位置都有不同的定义 
        /// 1、路口最外面的是 战略
        /// 2、路口外到内 第二个是感应
        /// 3、路口外到内 第三个是战术
        /// 4、路口 外到内第四个是请求
        /// </summary>
        /// <param name="i"></param>
        /// <param name="direc"></param>
        /// <param name="type"></param>
        public void SetDetector(int i ,byte direc,int type)
        {
            tscui.Models.Detector d = new Models.Detector();
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            bool newDetector = true;
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector det in ld)
            {
                if (det.ucDetectorId == i)
                {
                    det.ucDetectorId = Convert.ToByte(i);
                    //det.ucDetFlag = GetDetFlag(type,direc);
                    det.ucDirect = GetDirecByte(direc);
                    //det.ucOptionFlag = GetOptionByCheckbox();
                    det.ucPhaseId = GetPhaseIdByDirec(direc);
                    // det.ucSaturationOccupy = d.ucSaturationOccupy;
                    //det.ucValidTime = Convert.ToByte(tbkVaildTime.Text);
                    //det.usSaturationFlow = d.usSaturationFlow;
                    newDetector = false;
                    break;
                }
            }
            if (newDetector == true)
            {
                d.ucDetectorId = Convert.ToByte(i);
                d.ucPhaseId = GetPhaseIdByDirec(direc);
                d.ucDetFlag = GetDetFlag(type,direc);
                d.ucDirect = GetDirecByte(direc);
                d.ucValidTime = Convert.ToByte(tbkVaildTime.Text);
                d.ucOptionFlag = GetOptionByCheckbox();
                d.usSaturationFlow = 0;
                d.ucSaturationOccupy = 0;
                newDetector = true;
               
                ld.Add(d);
            }
        }
        public List<TextBlock> allDetecotr = new List<TextBlock>();
        /// <summary>
        /// 显示表单数据到界面上
        /// </summary>
        /// <param name="id"></param>
        public void displayOneDetector(int id)
        {
           
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            foreach(Models.Detector d in ld)
            {
                if(id == d.ucDetectorId)
                {
                    tbkPhaseId.Text = Convert.ToString(d.ucPhaseId);
                    byte detf = d.ucDetFlag;
                    if ((detf & 0x10) == 0x10)
                    {
                        rbnStategy.IsChecked = true;
                    }
                    if ((detf & 0x40) == 0x40)
                    {
                        rbnReaction.IsChecked = true;
                    }
                    if ((detf & 0x80) == 0x80)
                    {
                        rbnRequest.IsChecked = true;
                    }
                    if ((detf & 0x20) == 0x20)
                    {
                        rbnTactics.IsChecked = true;
                    }
                    if ((detf & 0x01) == 0x01)
                    {
                        rbnCar.IsChecked = true;
                    }
                    if ((detf & 0x02) == 0x02)
                    {
                        rbnBike.IsChecked = true;
                    }
                    if ((detf & 0x04) == 0x04)
                    {
                        rbnBus.IsChecked = true;
                    }
                    if ((detf & 0x08) == 0x08)
                    {
                        rbnPedestrain.IsChecked = true;
                    }

                    tbkVaildTime.Text = Convert.ToString(d.ucValidTime);
                    tbxFlow.Text = Convert.ToString(d.usSaturationFlow);
                    tbxOccupany.Text = Convert.ToString(d.ucSaturationOccupy);
                    byte opt = d.ucOptionFlag;
                    if ((opt & 0x01) == 0x01)
                    {
                        cbxCarType.IsChecked = true;
                    }
                    else
                    {
                        cbxCarType.IsChecked = false;
                    }
                    if ((opt & 0x02) == 0x02)
                    {
                        cbxKeyRoad.IsChecked = true;
                    }
                    else
                    {
                        cbxKeyRoad.IsChecked = false;
                    }
                    if ((opt & 0x04) == 0x04)
                    {

                        cbxFlow.IsChecked = true;
                    }
                    else
                    {
                        cbxFlow.IsChecked = false;
                    }
                    if ((opt & 0x08) == 0x08)
                    {
                        cbxOccupancy.IsChecked = true;
                    }
                    else
                    {
                        cbxOccupancy.IsChecked = false;
                    }
                    if ((opt & 0x10) == 0x10)
                    {
                        cbxSpeed.IsChecked = true;
                    }
                    else
                    {
                        cbxSpeed.IsChecked = false;
                    }
                    if ((opt & 0x20) == 0x20)
                    {
                        cbxQueun.IsChecked = true;
                    }
                    else
                    {
                        cbxQueun.IsChecked = false;
                    }
                }
                
            }
        }
        /// <summary>
        /// 清空配置当前检测器在其它方向位置上的数字显示
        /// 并显示在当前配置的位置上。
        /// </summary>
        /// <param name="id"></param>
        public void ClearDetectorId(int id)
        {
            //清空之前放到的textblock
            foreach (TextBlock tb in allDetecotr)
            {
                if (!tb.Text.Equals(""))
                {
                    if (id == Convert.ToInt32(tb.Text))
                    {
                        tb.Text = "";
                    }
                }

            }
        }
        private void detectorNorthOther1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_OTHER, 1);
            displayOneDetector(i);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            { 
            ThreadPool.QueueUserWorkItem(SaveDetector);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BaseTime: " + ex.ToString());
            }
        }

        private void SaveDetector(object state)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();

            Message m = TscDataUtils.SetDetector(t.ListDetector);
        }
        private delegate void DelegateInitAllDetector();
        private void DispatcherInitAllDetector(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitAllDetector(InitAllDetector));
        }
        private void InitAllDetector()
        {
            allDetecotr.Add(this.detectorEastLeft1);
            allDetecotr.Add(this.detectorEastLeft2);
            allDetecotr.Add(this.detectorEastLeft3);
            allDetecotr.Add(this.detectorEastLeft4);
            allDetecotr.Add(this.detectorEastOther1);
            allDetecotr.Add(this.detectorEastOther2);
            allDetecotr.Add(this.detectorEastOther3);
            allDetecotr.Add(this.detectorEastOther4);
            allDetecotr.Add(this.detectorEastRight1);
            allDetecotr.Add(this.detectorEastRight2);
            allDetecotr.Add(this.detectorEastRight3);
            allDetecotr.Add(this.detectorEastRight4);
            allDetecotr.Add(this.detectorEastStraight1);
            allDetecotr.Add(this.detectorEastStraight2);
            allDetecotr.Add(this.detectorEastStraight3);
            allDetecotr.Add(this.detectorEastStraight4);
            allDetecotr.Add(this.detectorNorthLeft1);
            allDetecotr.Add(this.detectorNorthLeft2);
            allDetecotr.Add(this.detectorNorthLeft3);
            allDetecotr.Add(this.detectorNorthLeft4);
            allDetecotr.Add(this.detectorNorthOther1);
            allDetecotr.Add(this.detectorNorthOther2);
            allDetecotr.Add(this.detectorNorthOther3);
            allDetecotr.Add(this.detectorNorthOther4);
            allDetecotr.Add(this.detectorNorthRight1);
            allDetecotr.Add(this.detectorNorthRight2);
            allDetecotr.Add(this.detectorNorthRight3);
            allDetecotr.Add(this.detectorNorthRight4);
            allDetecotr.Add(this.detectorNorthStraight1);
            allDetecotr.Add(this.detectorNorthStraight2);
            allDetecotr.Add(this.detectorNorthStraight3);
            allDetecotr.Add(this.detectorNorthStraight4);
            allDetecotr.Add(this.detectorSouthLeft1);
            allDetecotr.Add(this.detectorSouthLeft2);
            allDetecotr.Add(this.detectorSouthLeft3);
            allDetecotr.Add(this.detectorSouthLeft4);
            allDetecotr.Add(this.detectorSouthOther1);
            allDetecotr.Add(this.detectorSouthOther2);
            allDetecotr.Add(this.detectorSouthOther3);
            allDetecotr.Add(this.detectorSouthOther4);
            allDetecotr.Add(this.detectorSouthRight);
            allDetecotr.Add(this.detectorSouthRight1);
            allDetecotr.Add(this.detectorSouthRight3);
            allDetecotr.Add(this.detectorSouthRight4);
            allDetecotr.Add(this.detectorSouthStraight1);
            allDetecotr.Add(this.detectorSouthStraight2);
            allDetecotr.Add(this.detectorSouthStraight3);
            allDetecotr.Add(this.detectorSouthStraight4);
            allDetecotr.Add(this.detectorWestLeft1);
            allDetecotr.Add(this.detectorWestLeft2);
            allDetecotr.Add(this.detectorWestLeft3);
            allDetecotr.Add(this.detectorWestLeft4);
            allDetecotr.Add(this.detectorWestOther1);
            allDetecotr.Add(this.detectorWestOther2);
            allDetecotr.Add(this.detectorWestOther3);
            allDetecotr.Add(this.detectorWestOther4);
            allDetecotr.Add(this.detectorWestRight1);
            allDetecotr.Add(this.detectorWestRight2);
            allDetecotr.Add(this.detectorWestRight3);
            allDetecotr.Add(this.detectorWestRight4);
            allDetecotr.Add(this.detectorWestStraight1);
            allDetecotr.Add(this.detectorWestStraight2);
            allDetecotr.Add(this.detectorWestStraight3);
            allDetecotr.Add(this.detectorWestStraight4);
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(t == null)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(DispatcherInitAllDetector);
            //Thread tDispatcherInitAllDetector = new Thread(DispatcherInitAllDetector);
            //tDispatcherInitAllDetector.IsBackground = true;
            //tDispatcherInitAllDetector.Start();
           // Console.WriteLine(111);
        }

        private void detectorNorthOther2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_OTHER, 2);
            displayOneDetector(i);
        }

        private void detectorNorthOther3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_OTHER, 3);
            displayOneDetector(i);
        }

        private void detectorNorthOther4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_OTHER, 4);
            displayOneDetector(i);

        }

        private void detectorNorthRight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_RIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorNorthRight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_RIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorNorthRight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_RIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorNorthRight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_RIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorNorthStraight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_STRAIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorNorthStraight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_STRAIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorNorthStraight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_STRAIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorNorthStraight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_STRAIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorNorthLeft1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_LEFT, 1);
            displayOneDetector(i);
        }

        private void detectorNorthLeft2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_LEFT, 2);
            displayOneDetector(i);
        }

        private void detectorNorthLeft3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_LEFT, 3);
            displayOneDetector(i);
        }

        private void detectorNorthLeft4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_LEFT, 4);
            displayOneDetector(i);
        }

        private void detectorWestLeft1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_LEFT, 1);
            displayOneDetector(i);
        }

        private void detectorWestLeft2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_LEFT, 2);
            displayOneDetector(i);
        }

        private void detectorWestLeft3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_LEFT, 3);
            displayOneDetector(i);
        }

        private void detectorWestLeft4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_LEFT, 4);
            displayOneDetector(i);
        }

        private void detectorWestStraight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_STRAIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorWestStraight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector(); 
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_STRAIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorWestStraight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_STRAIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorWestStraight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_STRAIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorWestRight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_RIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorWestRight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_RIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorWestRight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_RIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorWestRight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_RIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorWestOther1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_OTHER, 1);
            displayOneDetector(i);
        }

        private void detectorWestOther2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_OTHER, 2);
            displayOneDetector(i);
        }

        private void detectorWestOther3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_OTHER, 3);
            displayOneDetector(i);
        }

        private void detectorWestOther4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.WEST_OTHER, 4);
            displayOneDetector(i);
        }

        private void detectorEastOther1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_OTHER, 1);
            displayOneDetector(i);
        }

        private void detectorEastOther2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_OTHER, 2);
            displayOneDetector(i);
        }

        private void detectorEastOther3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_OTHER, 3);
            displayOneDetector(i);
        }

        private void detectorEastOther4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_OTHER, 4);
            displayOneDetector(i);
        }

        private void detectorEastRight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_RIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorEastRight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_RIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorEastRight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_RIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorEastRight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_RIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorEastStraight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_STRAIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorEastStraight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_STRAIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorEastStraight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_STRAIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorEastStraight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_STRAIGHT,4);
            displayOneDetector(i);
        }

        private void detectorEastLeft1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_LEFT, 1);
            displayOneDetector(i);
        }

        private void detectorEastLeft2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_LEFT, 2);
            displayOneDetector(i);
        }

        private void detectorEastLeft3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_LEFT, 3);
            displayOneDetector(i);
        }

        private void detectorEastLeft4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.EAST_LEFT, 4);
            displayOneDetector(i);
        }

        private void detectorSouthOther1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_OTHER, 1);
            displayOneDetector(i);
        }

        private void detectorSouthOther2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_OTHER, 2);
            displayOneDetector(i);
        }

        private void detectorSouthOther3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_OTHER, 3);
            displayOneDetector(i);
        }

        private void detectorSouthOther4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_OTHER, 4);
            displayOneDetector(i);
        }

        private void detectorSouthRight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_RIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorSouthRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_RIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorSouthRight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_RIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorSouthRight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_RIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorSouthStraight1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_STRAIGHT, 1);
            displayOneDetector(i);
        }

        private void detectorSouthStraight2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_STRAIGHT, 2);
            displayOneDetector(i);
        }

        private void detectorSouthStraight3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_STRAIGHT, 3);
            displayOneDetector(i);
        }

        private void detectorSouthStraight4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_STRAIGHT, 4);
            displayOneDetector(i);
        }

        private void detectorSouthLeft1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_LEFT, 1);
            displayOneDetector(i);
        }

        private void detectorSouthLeft2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_LEFT, 2);
            displayOneDetector(i);
        }

        private void detectorSouthLeft3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_LEFT, 3);
            displayOneDetector(i);
        }

        private void detectorSouthLeft4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.SOUTH_LEFT, 4);
            displayOneDetector(i);
        }

        private void detectorNorthOther1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach(Models.Detector d in ld)
            {
                if(d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthOther2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthOther3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthOther4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthRight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthRight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthRight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthRight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthStraight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthStraight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthStraight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthStraight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthLeft1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthLeft2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthLeft3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorNorthLeft4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastOther4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastOther3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastOther2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastOther1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastRight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastRight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastRight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastRight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastStraight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastStraight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastStraight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastStraight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastLeft4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastLeft3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastLeft2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorEastLeft1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthOther4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthOther3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthOther2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthOther1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthRight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthRight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthRight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthStraight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthStraight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthStraight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthStraight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthLeft4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthLeft3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthLeft2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorSouthLeft1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestLeft4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestLeft3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestLeft2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestLeft1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestStraight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestStraight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestStraight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestStraight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestRight4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestRight3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestRight2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestRight1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestOther4_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestOther3_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestOther2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void detectorWestOther1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (tb.Text.Equals(""))
            {
                return;
            }
            byte id = Convert.ToByte(tb.Text);
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == id)
                {
                    d.ucPhaseId = 0x00;
                    tb.Text = "";
                }
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();


            List<Models.Detector> ld = t.ListDetector;

            foreach(Models.Detector d in ld)
            {
                Console.WriteLine(d.ToString());
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();

            Message m = TscDataUtils.SetDetector(t.ListDetector);
          //  MessageBox.Show(m.msg);

        }

        private void cbxCarType_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte( Utils.Utils.GetSelectedDetector());
            foreach(Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x01);
                }
            }
        }

        private void cbxCarType_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xfe);
                }
            }
        }

        private void cbxKeyRoad_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xfd);
                }
            }
        }

        private void cbxKeyRoad_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0x02);
                }
            }
        }

        private void cbxFlow_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x04);
                }
            }
        }

        private void cbxOccupancy_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xf7);
                }
            }
        }

        private void cbxFlow_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xfb);
                }
            }
        }

        private void cbxSpeed_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xef);
                }
            }
        }

        private void cbxQueun_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xdf);
                }
            }
        }

        private void cbxOccupancy_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x08);
                }
            }
        }

        private void cbxSpeed_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x10);
                }
            }
        }

        private void cbxQueun_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x20);
                }
            }
        }

        private void tbxFlow_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.usSaturationFlow = Convert.ToInt16(tbxFlow.Text);
                }
            }
        }

        private void tbxOccupany_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucSaturationOccupy = Convert.ToByte(tbxOccupany.Text);
                }
            }
        }

        private void tbkVaildTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucValidTime = Convert.ToByte(tbkVaildTime.Text);
                }
            }
        }

     


    }
}
