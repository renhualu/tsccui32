using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using System.Windows.Media.Imaging;
using System.Windows;
using tscui.Models;
using tscui.Service;
using System.Threading;
using System.Windows.Threading;

namespace tscui.Pages.Collision
{
    /// <summary>
    /// Interaction logic for CollisionView.xaml
    /// </summary>
    [View(typeof(CollisionViewModel))]
    public partial class CollisionView : UserControl,IView
    {
        public CollisionView()
        {
            InitializeComponent();
        }
        public void OnActivated()
        {
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

      
        public static CollisionItem currentCollision;
        public void BigMap4SmallMap(CollisionItem si)
        {
            //北方向
            this.northLeft.Source = si.northLeft.Source;
            this.northStraight.Source = si.northStraight.Source;
            this.northRight.Source = si.northRight.Source;
            this.northOther.Source = si.northOther.Source;
            this.northPedestrain1.Source = si.northPedestrain1.Source;
            this.northPedestrain2.Source = si.northPedestrain2.Source;

            this.southLeft.Source = si.southLeft.Source;
            this.southStraight.Source = si.southStraight.Source;
            this.southRight.Source = si.southRight.Source;
            this.southOther.Source = si.southOther.Source;
            this.southPedestrain1.Source = si.southPedestrain1.Source;
            this.southPedestrain2.Source = si.southPedestrain2.Source;

            this.eastLeft.Source = si.eastLeft.Source;
            this.eastStraight.Source = si.eastStraight.Source;
            this.eastRight.Source = si.eastRight.Source;
            this.eastOther.Source = si.eastOther.Source;
            this.eastPedestrain1.Source = si.eastPedestrain1.Source;
            this.eastPedestrain2.Source = si.eastPedestrain2.Source;

            this.westLeft.Source = si.westLeft.Source;
            this.westStraight.Source = si.westStraight.Source;
            this.westRight.Source = si.westRight.Source;
            this.westOther.Source = si.westOther.Source;
            this.westPedestrain1.Source = si.westPedestrain1.Source;
            this.westPedestrain2.Source = si.westPedestrain2.Source;
        }

        private void CollisionItem_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision1;
            BigMap4SmallMap(currentCollision);
        }

        private void collision2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision2;
            BigMap4SmallMap(currentCollision);
        }

        private void collision3_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision3;
            BigMap4SmallMap(currentCollision);
        }

        private void collision4_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision4;
            BigMap4SmallMap(currentCollision);
        }

        private void collision5_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision5;
            BigMap4SmallMap(currentCollision);
        }

        private void collision6_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision6;
            BigMap4SmallMap(currentCollision);
        }

        private void collision7_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision7;
            BigMap4SmallMap(currentCollision);
        }

        private void collision8_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision8;
            BigMap4SmallMap(currentCollision);
        }

        private void collision9_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision9;
            BigMap4SmallMap(currentCollision);
        }

        private void collision10_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision10;
            BigMap4SmallMap(currentCollision);
        }

        private void collision11_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision11;
            BigMap4SmallMap(currentCollision);
        }

        private void collision12_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision12;
            BigMap4SmallMap(currentCollision);
        }

        private void collision13_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision13;
            BigMap4SmallMap(currentCollision);
        }

        private void collision14_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision14;
            BigMap4SmallMap(currentCollision);
        }

        private void collision15_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision15;
            BigMap4SmallMap(currentCollision);
        }

        private void collision16_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision16;
            BigMap4SmallMap(currentCollision);
        }

        private void collision17_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision17;
            BigMap4SmallMap(currentCollision);
        }

        private void collision18_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision18;
            BigMap4SmallMap(currentCollision);
        }

        private void collision19_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision19;
            BigMap4SmallMap(currentCollision);
        }

        private void collision20_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision20;
            BigMap4SmallMap(currentCollision);
        }

        private void collision21_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision21;
            BigMap4SmallMap(currentCollision);
        }

        private void collision22_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision22;
            BigMap4SmallMap(currentCollision);
        }

        private void collision23_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision23;
            BigMap4SmallMap(currentCollision);
        }

        private void collision24_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision24;
            BigMap4SmallMap(currentCollision);
        }

        private void collision25_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision25;
            BigMap4SmallMap(currentCollision);
        }

        private void collision26_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision26;
            BigMap4SmallMap(currentCollision);
        }

        private void collision27_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision27;
            BigMap4SmallMap(currentCollision);
        }

        private void collision28_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision28;
            BigMap4SmallMap(currentCollision);
        }

        private void collision29_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision29;
            BigMap4SmallMap(currentCollision);
        }

        private void collision30_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision30;
            BigMap4SmallMap(currentCollision);
        }

        private void collision31_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision31;
            BigMap4SmallMap(currentCollision);
        }

        private void collision32_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentCollision = collision32;
            BigMap4SmallMap(currentCollision);
        }
        private void collisionFlagResetPhaseBit(tscui.Models.Collision c , PhaseToDirec ptd)
        {
            if (ptd.ucPhase == 1)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_1_PHASE_0;
            }
            if (ptd.ucPhase == 2)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_2_PHASE_0;
            }
            if (ptd.ucPhase == 3)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_3_PHASE_0;
            }
            if (ptd.ucPhase == 4)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_4_PHASE_0;
            }
            if (ptd.ucPhase == 5)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_5_PHASE_0;
            }
            if (ptd.ucPhase == 6)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_6_PHASE_0;
            }
            if (ptd.ucPhase == 7)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_7_PHASE_0;
            }
            if (ptd.ucPhase == 8)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_8_PHASE_0;
            }
            if (ptd.ucPhase == 9)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_9_PHASE_0;
            }
            if (ptd.ucPhase == 10)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_10_PHASE_0;
            }
            if (ptd.ucPhase == 11)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_11_PHASE_0;
            }
            if (ptd.ucPhase == 12)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_12_PHASE_0;
            }
            if (ptd.ucPhase == 13)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_13_PHASE_0;
            }
            if (ptd.ucPhase == 14)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_14_PHASE_0;
            }
            if (ptd.ucPhase == 15)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_15_PHASE_0;
            }
            if (ptd.ucPhase == 16)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_16_PHASE_0;
            }
            if (ptd.ucPhase == 17)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_17_PHASE_0;
            }
            if (ptd.ucPhase == 18)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_18_PHASE_0;
            }
            if (ptd.ucPhase == 19)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_19_PHASE_0;
            }
            if (ptd.ucPhase == 20)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_20_PHASE_0;
            }
            if (ptd.ucPhase == 21)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_21_PHASE_0;
            }
            if (ptd.ucPhase == 22)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_22_PHASE_0;
            }
            if (ptd.ucPhase == 23)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_23_PHASE_0;
            }
            if (ptd.ucPhase == 24)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_24_PHASE_0;
            }
            if (ptd.ucPhase == 25)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_25_PHASE_0;
            }
            if (ptd.ucPhase == 26)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_26_PHASE_0;
            }
            if (ptd.ucPhase == 27)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_27_PHASE_0;
            }
            if (ptd.ucPhase == 28)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_28_PHASE_0;
            }
            if (ptd.ucPhase == 29)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_29_PHASE_0;
            }
            if (ptd.ucPhase == 30)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_30_PHASE_0;
            }
            if (ptd.ucPhase == 31)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_31_PHASE_0;
            }
            if (ptd.ucPhase == 32)
            {
                c.ucCollisionFlag = c.ucCollisionFlag & Define.COLLISION_32_PHASE_0;
            }
           
        }
        private void collisionFlagSetPhaseBit(tscui.Models.Collision c , PhaseToDirec ptd)
        {
            if (ptd.ucPhase == 1)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_1_PHASE;
            }
            if (ptd.ucPhase == 2)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_2_PHASE;
            }
            if (ptd.ucPhase == 3)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_3_PHASE;
            }
            if (ptd.ucPhase == 4)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_4_PHASE;
            }
            if (ptd.ucPhase == 5)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_5_PHASE;
            }
            if (ptd.ucPhase == 6)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_6_PHASE;
            }
            if (ptd.ucPhase == 7)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_7_PHASE;
            }
            if (ptd.ucPhase == 8)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_8_PHASE;
            }
            if (ptd.ucPhase == 9)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_9_PHASE;
            }
            if (ptd.ucPhase == 10)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_10_PHASE;
            }
            if (ptd.ucPhase == 11)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_11_PHASE;
            }
            if (ptd.ucPhase == 12)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_12_PHASE;
            }
            if (ptd.ucPhase == 13)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_13_PHASE;
            }
            if (ptd.ucPhase == 14)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_14_PHASE;
            }
            if (ptd.ucPhase == 15)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_15_PHASE;
            }
            if (ptd.ucPhase == 16)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_16_PHASE;
            }
            if (ptd.ucPhase == 17)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_17_PHASE;
            }
            if (ptd.ucPhase == 18)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_18_PHASE;
            }
            if (ptd.ucPhase == 19)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_19_PHASE;
            }
            if (ptd.ucPhase == 20)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_20_PHASE;
            }
            if (ptd.ucPhase == 21)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_21_PHASE;
            }
            if (ptd.ucPhase == 22)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_22_PHASE;
            }
            if (ptd.ucPhase == 23)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_23_PHASE;
            }
            if (ptd.ucPhase == 24)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_24_PHASE;
            }
            if (ptd.ucPhase == 25)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_25_PHASE;
            }
            if (ptd.ucPhase == 26)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_26_PHASE;
            }
            if (ptd.ucPhase == 27)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_27_PHASE;
            }
            if (ptd.ucPhase == 28)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_28_PHASE;
            }
            if (ptd.ucPhase == 29)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_29_PHASE;
            }
            if (ptd.ucPhase == 30)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_30_PHASE;
            }
            if (ptd.ucPhase == 31)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_31_PHASE;
            }
            if (ptd.ucPhase == 32)
            {
                c.ucCollisionFlag = c.ucCollisionFlag | Define.COLLISION_32_PHASE;
            }
        }
        private void southLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach(PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }
        private void southStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision != null)
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<tscui.Models.Collision> lc = t.ListCollision;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        //ptd.ucPhase;
                        byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                        foreach (tscui.Models.Collision c in lc)
                        {
                            if (collisionId == c.ucPhaseId)
                            {
                                collisionFlagSetPhaseBit(c, ptd);
                                //(c.ucCollisionFlag >> ptd.ucPhase) & 0x01;
                                Console.WriteLine(c.ucCollisionFlag);
                            }
                        }
                    }
                }
                currentCollision.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
                southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void westPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void westPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void eastPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void eastPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void southPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void northPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void northPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void eastOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.EAST_OTHER)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void eastRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.EAST_RIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void eastStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.EAST_STRAIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void eastLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
               
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.EAST_LEFT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void westLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.WEST_LEFT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void westStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.WEST_STRAIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void westRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.WEST_RIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void westOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.WEST_OTHER)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
        }

        private void northOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.NORTH_OTHER)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void northRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.NORTH_RIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void northStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.NORTH_STRAIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void northLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.NORTH_LEFT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void southLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            if (currentCollision == null)
            {
               
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.SOUTH_LEFT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void southStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.SOUTH_STRAIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void southRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.SOUTH_RIGHT)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }

        private void southOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentCollision == null)
            {
                
                MessageBox.Show("请选择一个冲突相位，以便进行设置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            List<tscui.Models.Collision> lc = t.ListCollision;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucId == Define.SOUTH_OTHER)
                {
                    //ptd.ucPhase;
                    byte collisionId = Convert.ToByte(currentCollision.lblId.Content);
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (collisionId == c.ucPhaseId)
                        {
                            collisionFlagResetPhaseBit(c, ptd);
                            Console.WriteLine(c.ucCollisionFlag);
                        }
                    }
                }
            }
            currentCollision.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
        }
        /// <summary>
        /// /4 个方向的灯组状态 ，都将其重置回原来的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////南
            //currentCollision.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            ////北
            //currentCollision.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            ////东
            //currentCollision.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            ////西
            //currentCollision.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight.png", UriKind.Relative));
            //currentCollision.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //currentCollision.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            //westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/nolight1.png", UriKind.Relative));
            List<tscui.Models.Collision> lc = t.ListCollision;
            List<PhaseToDirec> lp = t.ListPhaseToDirec;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (t == null)
            {
                MessageBox.Show("请你选择相应信号机，以便更新数据");
            }
            TscDataUtils.SetCollision(t.ListCollision);
        }
        List<CollisionItem> lci = new List<CollisionItem>();
        /// <summary>
        /// 全局变量中初始化一个CollisionItem的集合
        /// </summary>
        private void initCollisionItemList()
        {
            lci.Add(collision1);
            lci.Add(collision2);
            lci.Add(collision3);
            lci.Add(collision4);
            lci.Add(collision5);
            lci.Add(collision6);
            lci.Add(collision7);
            lci.Add(collision8);
            lci.Add(collision9);
            lci.Add(collision10);
            lci.Add(collision11);
            lci.Add(collision12);
            lci.Add(collision13);
            lci.Add(collision14);
            lci.Add(collision15);
            lci.Add(collision16);
            lci.Add(collision17);
            lci.Add(collision18);
            lci.Add(collision19);
            lci.Add(collision20);
            lci.Add(collision21);
            lci.Add(collision22);
            lci.Add(collision23);
            lci.Add(collision24);
            lci.Add(collision25);
            lci.Add(collision26);
            lci.Add(collision27);
            lci.Add(collision28);
            lci.Add(collision29);
            lci.Add(collision30);
            lci.Add(collision31);
            lci.Add(collision32);
        }

        
        /// <summary>
        /// 显示小图上的方向的箭头
        /// </summary>
        private void initDirecBigAndSmall()
        {
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase != 0)
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        northLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        northOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        northPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        northPedestrain2.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        northRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                       northStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        eastLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        eastStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        eastRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        eastOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        eastPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        eastPedestrain2.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        southLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        southOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        southStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        southRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                       southPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        southPedestrain2.Visibility = Visibility.Visible;
                    }

                    //west
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        westLeft.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        westStraight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        westRight.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        westOther.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        westPedestrain1.Visibility = Visibility.Visible;
                    }

                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        westPedestrain2.Visibility = Visibility.Visible;
                    }

                }
                else
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        northLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        northOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        northPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        northPedestrain2.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        northRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        northStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        eastLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        eastStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        eastRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        eastOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        eastPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        eastPedestrain2.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        southLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        southOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        southStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        southRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        southPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        westPedestrain2.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        westPedestrain1.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        westOther.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        westRight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        westStraight.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        westLeft.Visibility = Visibility.Hidden;
                    }
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        southPedestrain2.Visibility = Visibility.Hidden;
                    }
                }
            }
            foreach(CollisionItem ci in lci)
            {
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucPhase != 0)
                    {
                        if(ptd.ucId == Define.NORTH_LEFT)
                        {
                            ci.northLeft.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.NORTH_OTHER)
                        {
                            ci.northOther.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                        {
                            ci.northPedestrain1.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                        {
                            ci.northPedestrain2.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.NORTH_RIGHT)
                        {
                            ci.northRight.Visibility = Visibility.Visible;
                        }
                       
                        if (ptd.ucId == Define.NORTH_STRAIGHT)
                        {
                            ci.northStraight.Visibility = Visibility.Visible;
                        }

                        if (ptd.ucId == Define.EAST_LEFT)
                        {
                            ci.eastLeft.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.EAST_STRAIGHT)
                        {
                            ci.eastStraight.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.EAST_RIGHT)
                        {
                            ci.eastRight.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.EAST_OTHER)
                        {
                            ci.eastOther.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                        {
                            ci.eastPedestrain1.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                        {
                            ci.eastPedestrain2.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.SOUTH_LEFT)
                        {
                            ci.southLeft.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.SOUTH_OTHER)
                        {
                            ci.southOther.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.SOUTH_STRAIGHT)
                        {
                            ci.southStraight.Visibility = Visibility.Visible;
                        }
                       
                        if (ptd.ucId == Define.SOUTH_RIGHT)
                        {
                            ci.southRight.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                        {
                            ci.southPedestrain1.Visibility = Visibility.Visible;
                        }
                       
                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                        {
                            ci.southPedestrain2.Visibility = Visibility.Visible;
                        }
                       
                        //west
                        if (ptd.ucId == Define.WEST_LEFT)
                        {
                            ci.westLeft.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.WEST_STRAIGHT)
                        {
                            ci.westStraight.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.WEST_RIGHT)
                        {
                            ci.westRight.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.WEST_OTHER)
                        {
                            ci.westOther.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                        {
                            ci.westPedestrain1.Visibility = Visibility.Visible;
                        }
                        
                        if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                        {
                            ci.westPedestrain2.Visibility = Visibility.Visible;
                        }
                       
                    }
                    else
                    {
                        if (ptd.ucId == Define.NORTH_LEFT)
                        {
                            ci.northLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_OTHER)
                        {
                            ci.northOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                        {
                            ci.northPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                        {
                            ci.northPedestrain2.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_RIGHT)
                        {
                            ci.northRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.NORTH_STRAIGHT)
                        {
                            ci.northStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_LEFT)
                        {
                            ci.eastLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_STRAIGHT)
                        {
                            ci.eastStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_RIGHT)
                        {
                            ci.eastRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_OTHER)
                        {
                            ci.eastOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                        {
                            ci.eastPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                        {
                            ci.eastPedestrain2.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_LEFT)
                        {
                            ci.southLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_OTHER)
                        {
                            ci.southOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_STRAIGHT)
                        {
                            ci.southStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_RIGHT)
                        {
                            ci.southRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                        {
                            ci.southPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                        {
                            ci.westPedestrain2.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                        {
                            ci.westPedestrain1.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_OTHER)
                        {
                            ci.westOther.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_RIGHT)
                        {
                            ci.westRight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_STRAIGHT)
                        {
                            ci.westStraight.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.WEST_LEFT)
                        {
                            ci.westLeft.Visibility = Visibility.Hidden;
                        }
                        if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                        {
                            ci.southPedestrain2.Visibility = Visibility.Hidden;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 隐藏所有的collisionitem 小图
        /// </summary>
        private void hiddenCollision()
        {
            foreach(CollisionItem ci in lci)
            {
                ci.Visibility = Visibility.Hidden;
            }
        }

        TscData t;
        private delegate void delegateInitCollisionId();
        private delegate void delegateInitDirecBigAndSmall();
        private delegate void delegateInitDirecPhaseLight();
        private delegate void delegateInitDirecCollisionPhaseRedLight();

        private void DispatcherInitCollisionId()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new delegateInitCollisionId(initCollisionId));
        }

        private void DispatcherInitDirecBigAndSmall()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new delegateInitDirecBigAndSmall(initDirecBigAndSmall));
        }

        private void DispatcherInitDirecPhaseLight()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new delegateInitDirecPhaseLight(initDirecPhaseLight));
        }
        private void DispatcherInitDirecCollisionPhaseRedLight()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new delegateInitDirecCollisionPhaseRedLight(initDirecCollisionPhaseRedLight));
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            initCollisionItemList();     /// 这个必需放在最前面，以便将初始化collision的数组。后面的几个方法都用到了此数组
            hiddenCollision();
            //将当前collision 设置为第一个collisionItem
            currentCollision = collision1;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(t == null)
            {
                return;
            }
            Thread tCollisionId = new Thread(DispatcherInitCollisionId);
            tCollisionId.IsBackground = true;
            tCollisionId.Start();
            //initCollisionId();
            Thread tDispatcherInitDirecBigAndSmall = new Thread(DispatcherInitDirecBigAndSmall);
            tDispatcherInitDirecBigAndSmall.IsBackground = true;
            tDispatcherInitDirecBigAndSmall.Start();
            //initDirecBigAndSmall();
            Thread tDispatcherInitDirecPhaseLight = new Thread(DispatcherInitDirecPhaseLight);
            tDispatcherInitDirecPhaseLight.IsBackground = true;
            tDispatcherInitDirecPhaseLight.Start();
            //initDirecPhaseLight();
            Thread tDispatcherInitDirecCollisionPhaseRedLight = new Thread(DispatcherInitDirecCollisionPhaseRedLight);
            tDispatcherInitDirecCollisionPhaseRedLight.IsBackground = true;
            tDispatcherInitDirecCollisionPhaseRedLight.Start();
            //initDirecCollisionPhaseRedLight();
            
            
        }
        private void initGreenPhaseDirec(CollisionItem c,PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                c.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                c.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                c.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                c.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                c.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                c.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                c.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                c.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                c.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                c.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.EAST_LEFT)
            {
                c.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                c.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                c.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                c.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                c.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_LEFT)
            {
                c.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                c.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                c.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                c.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                c.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
        }
        private void initRedPhaseDirec(PhaseToDirec ptd,CollisionItem c)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                c.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                c.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                c.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                c.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                c.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                c.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                c.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                c.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                c.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                c.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.EAST_LEFT)
            {
                c.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                c.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                c.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                c.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                c.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_LEFT)
            {
                c.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                c.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                c.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                c.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                c.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
        }
        /// <summary>
        /// 将绿冲突的相关冲突相位红色显示出来
        /// </summary>
        /// <param name="lptd"></param>
        /// <param name="lc"></param>
        private void initDirecCollisionPhaseRedLight()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                return;
            }
            List<tscui.Models.Collision> lc = t.ListCollision;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            //foreach(PhaseToDirec ptd in lptd)
            //{
                foreach (tscui.Models.Collision c in lc)
                {
                    //if (c.ucPhaseId == ptd.ucPhase)
                    //{
                        foreach(CollisionItem ci in lci)
                        {
                            if (Convert.ToByte(ci.lblId.Content) == c.ucPhaseId)
                            {
                                uint cf = c.ucCollisionFlag;
                                for (int i = 0; i < 32; i++)
                                {
                                    if (((cf >> i) & 0x01) == 0x01)
                                    {
                                        foreach (PhaseToDirec ptd in lptd)
                                        {
                                            if (ptd.ucPhase == (i + 1))
                                                initRedPhaseDirec(ptd, ci);
                                        }
                                        
                                    }
                                }
                            }
                        }
                       
                            
                            //initRedPhaseDirec(ptd)
                    //}
                }
            //}

        }
        /// <summary>
        /// 将主相位在小图上，用绿色灯显示出来
        /// 每个小图，就一个主相位绿灯
        /// </summary>
        /// <param name="lptd"></param>
        /// <param name="lc"></param>
        private void initDirecPhaseLight()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                return;
            }
            List<tscui.Models.Collision> lc = t.ListCollision;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach(PhaseToDirec ptd in lptd)
            {
                foreach (tscui.Models.Collision c in lc)
                {
                    if (c.ucPhaseId == ptd.ucPhase)
                    {
                        if (c.ucPhaseId == 1)
                        {
                            initGreenPhaseDirec(collision1,ptd);
                            
                        }
                        if (c.ucPhaseId == 2)
                        {
                            initGreenPhaseDirec(collision2, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 3)
                        {
                            initGreenPhaseDirec(collision3, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 4)
                        {
                            initGreenPhaseDirec(collision4, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 5)
                        {
                            initGreenPhaseDirec(collision5, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 6)
                        {
                            initGreenPhaseDirec(collision6, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 7)
                        {
                            initGreenPhaseDirec(collision7, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 8)
                        {
                            initGreenPhaseDirec(collision8, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 9)
                        {
                            initGreenPhaseDirec(collision9, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 10)
                        {
                            initGreenPhaseDirec(collision10, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 11)
                        {
                            initGreenPhaseDirec(collision11, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 12)
                        {
                            initGreenPhaseDirec(collision12, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 13)
                        {
                            initGreenPhaseDirec(collision13, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 14)
                        {
                            initGreenPhaseDirec(collision14, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 15)
                        {
                            initGreenPhaseDirec(collision15, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 16)
                        {
                            initGreenPhaseDirec(collision16, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 17)
                        {
                            initGreenPhaseDirec(collision17, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 18)
                        {
                            initGreenPhaseDirec(collision18, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 19)
                        {
                            initGreenPhaseDirec(collision19, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 20)
                        {
                            initGreenPhaseDirec(collision20, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 21)
                        {
                            initGreenPhaseDirec(collision21, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 22)
                        {
                            initGreenPhaseDirec(collision22, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 23)
                        {
                            initGreenPhaseDirec(collision23, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 24)
                        {
                            initGreenPhaseDirec(collision24, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 25)
                        {
                            initGreenPhaseDirec(collision25, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 26)
                        {
                            initGreenPhaseDirec(collision26, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 27)
                        {
                            initGreenPhaseDirec(collision27, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 28)
                        {
                            initGreenPhaseDirec(collision28, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 29)
                        {
                            initGreenPhaseDirec(collision29, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 30)
                        {
                            initGreenPhaseDirec(collision30, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 31)
                        {
                            initGreenPhaseDirec(collision31, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                        if (c.ucPhaseId == 32)
                        {
                            initGreenPhaseDirec(collision32, ptd);
                            uint cf = c.ucCollisionFlag;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((cf >> i) & 0x01) == 0x01)
                                {
                                    if (ptd.ucPhase == (i + 1))
                                        initRedPhaseDirec(ptd, collision1);
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 初始化小图上的ID，此ID采用collision的相位ID。
        /// 并将其显示出来
        /// </summary>
        /// <param name="lc"></param>
        private void initCollisionId()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                return;
            }
            List<tscui.Models.Collision> lc = t.ListCollision;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach(PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase != 0)
                {
                    foreach (tscui.Models.Collision c in lc)
                    {
                        if (c.ucPhaseId == 1 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision1.lblId.Content = c.ucPhaseId;
                            collision1.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 2 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision2.lblId.Content = c.ucPhaseId;
                            collision2.Visibility = Visibility.Visible;
                        }

                        if (c.ucPhaseId == 3 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision3.lblId.Content = c.ucPhaseId;
                            collision3.Visibility = Visibility.Visible;
                        }

                        if (c.ucPhaseId == 4 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision4.lblId.Content = c.ucPhaseId;
                            collision4.Visibility = Visibility.Visible;
                        }

                        if (c.ucPhaseId == 5 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision5.lblId.Content = c.ucPhaseId;
                            collision5.Visibility = Visibility.Visible;
                        }

                        if (c.ucPhaseId == 6 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision6.lblId.Content = c.ucPhaseId;
                            collision6.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 7 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision7.lblId.Content = c.ucPhaseId;
                            collision7.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 8 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision8.lblId.Content = c.ucPhaseId;
                            collision8.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 9 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision9.lblId.Content = c.ucPhaseId;
                            collision9.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 10 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision10.lblId.Content = c.ucPhaseId;
                            collision10.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 11 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision11.lblId.Content = c.ucPhaseId;
                            collision11.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 12 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision12.lblId.Content = c.ucPhaseId;
                            collision12.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 13 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision13.lblId.Content = c.ucPhaseId;
                            collision13.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 14 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision14.lblId.Content = c.ucPhaseId;
                            collision14.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 15 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision15.lblId.Content = c.ucPhaseId;
                            collision15.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 16 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision16.lblId.Content = c.ucPhaseId;
                            collision16.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 17 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision17.lblId.Content = c.ucPhaseId;
                            collision17.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 18 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision18.lblId.Content = c.ucPhaseId;
                            collision18.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 19 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision19.lblId.Content = c.ucPhaseId;
                            collision19.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 20 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision20.lblId.Content = c.ucPhaseId;
                            collision20.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 21 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision21.lblId.Content = c.ucPhaseId;
                            collision21.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 22 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision22.lblId.Content = c.ucPhaseId;
                            collision22.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 23 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision23.lblId.Content = c.ucPhaseId;
                            collision23.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 24 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision24.lblId.Content = c.ucPhaseId;
                            collision24.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 25 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision25.lblId.Content = c.ucPhaseId;
                            collision25.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 26 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision26.lblId.Content = c.ucPhaseId;
                            collision26.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 27 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision27.lblId.Content = c.ucPhaseId;
                            collision27.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 28 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision28.lblId.Content = c.ucPhaseId;
                            collision28.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 29 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision29.lblId.Content = c.ucPhaseId;
                            collision29.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 30 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision30.lblId.Content = c.ucPhaseId;
                            collision30.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 31 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision31.lblId.Content = c.ucPhaseId;
                            collision31.Visibility = Visibility.Visible;
                        }
                        if (c.ucPhaseId == 32 && ptd.ucPhase == c.ucPhaseId)
                        {
                            collision32.lblId.Content = c.ucPhaseId;
                            collision32.Visibility = Visibility.Visible;
                        }
                    }
                }
            }
           
           
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
            ThreadPool.QueueUserWorkItem(SaveCollision);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BaseTime: " + ex.ToString());
            }
        }

        private void SaveCollision(object state)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            TscDataUtils.SetCollision(t.ListCollision);
        }
    }
}
