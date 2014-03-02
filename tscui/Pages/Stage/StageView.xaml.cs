using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using System.Windows;
using System.Windows.Media.Imaging;
using tscui.Models;
using tscui.Service;
using System.Threading;
using System.Windows.Threading;

namespace tscui.Pages.Stage
{
    /// <summary>
    /// Interaction logic for StageView.xaml
    /// </summary>
    [View(typeof(StageViewModel))]
    public partial class StageView : UserControl,IView
    {
        public static List<StageItem> lsi = new List<StageItem>();
        public delegate void InitStageItemToLSI();
        public delegate void DelegateInitcbxCoordination();
        public delegate void DelegateInitStageNumber();
        private void initStageItemList()
        {
            lsi.Add(stage1);
            Console.WriteLine("stageitemlist");
            lsi.Add(stage2);
            lsi.Add(stage3);
            lsi.Add(stage4);
            lsi.Add(stage5);
            lsi.Add(stage6);
            lsi.Add(stage7);
            lsi.Add(stage8);
            lsi.Add(stage9);
            lsi.Add(stage10);
            lsi.Add(stage11);
            lsi.Add(stage12);
            lsi.Add(stage13);
            lsi.Add(stage14);
            lsi.Add(stage15);
            lsi.Add(stage16);
        }
        public static StageItem currentStage ;
        public StageView()
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

        public void BigMap4SmallMap(StageItem si)
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

        private void stage1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage1;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        /// <summary>
        /// 通过点击小图，可以将数据更新给
        /// 周期
        /// 相位差
        /// 协调相位
        /// 感应
        /// 红灯时间
        /// 绿灯时间
        /// 黄灯时间
        /// </summary>
        /// <param name="currentStage"></param>
        private void smallMap4Form(StageItem currentStage)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<Pattern> lp = t.ListPattern;

            foreach (Pattern p in lp)
            {
                if (sldSchemeId.Value == p.ucPatternId)
                {
                    if (p.ucStagePatternId == sldStagePatternId.Value)
                    {
                        //sldSchemeId.Value = p.ucPatternId;
                        tbxCycle.Text = p.ucCycleTime.ToString();
                        tbxOffset.Text = p.ucOffset.ToString();
                        cbxCoordination.SelectedItem = p.ucCoorPhase;
                        cbxReaction.IsChecked = false;
                    }
                    foreach (StagePattern sp in lsp)
                    {
                        
                        if (sp.ucStageNo == Convert.ToByte(currentStage.lblNumber.Content.ToString()))
                        {
                            //sldStagePatternId.Value = sp.ucStagePatternId;
                            sldGreenTime.Value = sp.ucGreenTime;
                            sldYellowTime.Value = sp.ucYellowTime;
                            sldRedTime.Value = sp.ucRedTime;

                        }
                    }
                }
                
                
            }
            


        }

     
        private void southStraight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void southRight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void southOther_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void westPedestrain1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void westPedestrain2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void eastPedestrain1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void eastPedestrain2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northOther_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northRight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northStraight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northLeft_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void southPedestrain2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void southPedestrain1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
        }

        private void westOther_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void westRight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void westStraight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void westLeft_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northPedestrain2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northPedestrain1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
        }

        private void eastOther_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
        }

        private void eastRight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            
        }

        private void eastStraight_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            
        }

        private void eastLeft_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            
        }

        private void southLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;
                       
                            foreach(PhaseToDirec ptd in lptd )
                            {
                                if (ptd.ucId == Define.SOUTH_LEFT)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd,ap);
                                }
                            }
                    }
                }
            }
            
        }
        private uint returnUnAllowPhase(PhaseToDirec  ptd, uint ap)
        {
            uint temp = 1;
            uint c = (~(temp << (ptd.ucPhase - 1))) & ap;
            //ap = c;
            return c;
        }
        /// <summary>
        /// /返回当前 checkbox是否被选中
        /// 选中：  表示为感应阶段，0x00
        /// 不选中：表示不是感应阶段，0x01
        /// </summary>
        /// <returns></returns>
        public byte returnReactionTrueOrFalse()
        {
            if (cbxReaction.IsChecked == true)
            {
                return 0x00;
            }
            else
            {
                return 0x01;
            }
        }
        /// <summary>
        /// 将allowPhase 通过左移 phase -1 位。
        /// </summary>
        /// <param name="phase"></param>
        /// <param name="allowPhase"></param>
        /// <returns></returns>
        private uint returnAllowPhase(byte phase,uint allowPhase)
        {
            uint temp = 1;
            //uint tempint = Convert.ToUInt32(phase);
            uint c = (temp << (phase-1)) | allowPhase;
            return c;
        }
        private void setPatternAndStagePattern(List<Pattern> lp ,List<StagePattern> lsp , StageItem currentStage,PhaseToDirec ptd)
        {
            //半断是新增加stage还是，老的更新用的
            Pattern ptemp= null;
           // List<Pattern> lptemp = new List<Pattern>();
            bool newPattern = false;
            bool oldPattern = false;
            foreach(Pattern p in lp)
            {
               
                if (sldSchemeId.Value == p.ucPatternId )
                {
                    p.ucCoorPhase = Convert.ToByte(cbxCoordination.SelectedItem);
                    p.ucCycleTime = Convert.ToByte(tbxCycle.Text);
                    p.ucOffset = Convert.ToByte(tbxOffset.Text);
                    p.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    p.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    oldPattern = true;
                    //if (sldStagePatternId.Value == p.ucStagePatternId)
                    //{
                    //    p.ucCoorPhase = Convert.ToByte(cbxCoordination.SelectedItem);
                    //    p.ucCycleTime = Convert.ToByte(tbxCycle.Text);
                    //    p.ucOffset = Convert.ToByte(tbxOffset.Text);
                    //    p.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    //    p.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    //}
                    //else
                    //{
                       
                    //}
                    //p.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    //p.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    //ptemp = null;
                }
                else
                {
                    newPattern = true;
                }
            
            }
            if (!oldPattern)
            {
                if (newPattern)
                {
                    ptemp = new Pattern();
                    ptemp.ucCoorPhase = Convert.ToByte(cbxCoordination.SelectedItem);
                    ptemp.ucCycleTime = Convert.ToByte(tbxCycle.Text);
                    ptemp.ucOffset = Convert.ToByte(tbxOffset.Text);
                    ptemp.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    ptemp.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    lp.Add(ptemp);
                }
               
            }
            //if (!lp.Contains(ptemp))//这里主要 是，新的方案号需要增加。旧的方案，不用进行增加，
            //{
                
            //}
           
            

            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    
                    if (sp.ucStageNo == Convert.ToByte(currentStage.lblNumber.Content))
                    {
                        sp.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                        sp.ucStageNo = Convert.ToByte(currentStage.lblNumber.Content);
                        sp.ucGreenTime = Convert.ToByte(sldGreenTime.Value);
                        sp.ucYellowTime = Convert.ToByte(sldYellowTime.Value);
                        sp.ucRedTime = Convert.ToByte(sldRedTime.Value);
                        sp.ucOption = returnReactionTrueOrFalse();
                        sp.usAllowPhase = returnAllowPhase(ptd.ucPhase, sp.usAllowPhase);
                        Console.WriteLine(sp.usAllowPhase);
                        break;
                    }
                    else if(sp.ucStageNo == 0)
                    {
                        sp.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                        sp.ucStageNo = Convert.ToByte(currentStage.lblNumber.Content);
                        sp.ucGreenTime = Convert.ToByte(sldGreenTime.Value);
                        sp.ucYellowTime = Convert.ToByte(sldYellowTime.Value);
                        sp.ucRedTime = Convert.ToByte(sldRedTime.Value);
                        sp.ucOption = returnReactionTrueOrFalse();
                        sp.usAllowPhase = returnAllowPhase(ptd.ucPhase, sp.usAllowPhase);
                        Console.WriteLine(sp.usAllowPhase);
                        break;
                    }
                    else
                    {
                        //MessageBox.Show("研发专用，程序异常。没有进行stage，stageNo 不为0，也不为小图上的编号\n");
                    }
                }
            }
               
        }
        private void southLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach(PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_LEFT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);
                           
                        }
                          //  phaseId = ptd.ucPhase;
                    }   
                }
               
                
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }
        //public Message SaveToListStage(int phaseid)
        //{
        //    // southLeft.valu
        //    TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        //    List<StagePattern> lsp = t.ListStagePattern;
        //    if (currentStage == stage1)
        //    {
        //        foreach (StagePattern sp in lsp)
        //        {
        //            if (sp.ucStageNo == Convert.ToByte(currentStage.lblNumber.Content))
        //            {
        //                //ptd.ucPhase
        //                sp.ucStagePatternId = Convert.ToByte(sldPatternId.Value); //sldPatternId.Value;
        //                sp.ucStageNo = Convert.ToByte(currentStage.lblNumber.Content.ToString());
        //                sp.usAllowPhase = sp.usAllowPhase >> phaseid & 0x01;
        //                //sp.ucGreenTime = 
        //            }
        //        }
        //    }

        //    return new Message();
        //}
        private void southStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_STRAIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_RIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_OTHER)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_OTHER)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_RIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_STRAIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_LEFT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_LEFT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_STRAIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_RIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.WEST_OTHER)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southPedestrain2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southPedestrain1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northOther_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_OTHER)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northRight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_RIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northStraight_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_STRAIGHT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northLeft_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucId == Define.NORTH_LEFT)
                    {
                        if (ptd.ucPhase != null || ptd.ucPhase != 0)
                        {
                            setPatternAndStagePattern(lp, lsp, currentStage, ptd);

                        }
                        //  phaseId = ptd.ucPhase;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.NORTH_LEFT)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.NORTH_STRAIGHT)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.NORTH_RIGHT)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void northOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.NORTH_OTHER)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void westPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void eastPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage != null)
            {
                currentStage.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                foreach (StagePattern sp in lsp)
                {
                    if (sp.ucStagePatternId == sldStagePatternId.Value)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            uint ap = sp.usAllowPhase;

                            foreach (PhaseToDirec ptd in lptd)
                            {
                                if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                                {
                                    sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个阶段，便可以进行配置！");
            }
        }

        private void southStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.SOUTH_STRAIGHT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void southRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.SOUTH_RIGHT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void southOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.SOUTH_OTHER)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void northPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void northPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void eastOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.EAST_OTHER)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void eastRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.EAST_RIGHT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void eastStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.EAST_STRAIGHT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void eastLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.EAST_LEFT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void westLeft_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.WEST_LEFT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void westStraight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.WEST_STRAIGHT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void westRight_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.WEST_RIGHT)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void westOther_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.WEST_OTHER)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void southPedestrain2_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void southPedestrain1_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (currentStage == null)
            {
                MessageBox.Show("请选择一个阶段，以便取消相位放行！");
                return;
            }
            currentStage.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                    {
                        uint ap = sp.usAllowPhase;

                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                            {
                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                            }
                        }
                    }
                }
            }
        }

        private void stage2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage2;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        private void stage3_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage3;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        private void stage4_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage4;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        private void stage5_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage5;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        private void stage6_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage6;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        private void stage7_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage7;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
        }

        private void stage8_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage8;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage9_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage9;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage10_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage10;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage11_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage11;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage12_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage12;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage13_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage13;
            BigMap4SmallMap(currentStage); //MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage14_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage14;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage15_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage15;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
        }

        private void stage16_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage16;
            smallMap4Form(currentStage);
            BigMap4SmallMap(currentStage); //MessageBox.Show("stage1");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Message msgPattern = TscDataUtils.SetPattern(t.ListPattern);
            if (!msgPattern.flag)
            {
                MessageBox.Show("对象："+msgPattern.obj + "\n内容：" + msgPattern.msg);
            }
            Message msgStagePattern = TscDataUtils.SetStagePattern(t.ListStagePattern);
            if (!msgStagePattern.flag)
            {
                MessageBox.Show("对象：" + msgStagePattern.obj + "\n内容：" + msgStagePattern.msg);
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            
            List<StagePattern> lsp = t.ListStagePattern;
            List<Pattern> lp = t.ListPattern;
        }
        private void visiableStage(StagePattern sp)
        {
            
            if (sp.ucStageNo == 1)
            {
                stage1.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 2)
            {
                stage2.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 3)
            {
                stage3.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 4)
            {
                stage4.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 5)
            {
                stage5.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 6)
            {
                stage6.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 7)
            {
                stage7.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 8)
            {
                stage8.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 9)
            {
                stage9.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 10)
            {
                stage10.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 11)
            {
                stage11.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 12)
            {
                stage12.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 13)
            {
                stage13.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 14)
            {
                stage14.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 15)
            {
                stage15.Visibility = Visibility.Visible;
            }
            else if (sp.ucStageNo == 16)
            {
                stage16.Visibility = Visibility.Visible;
            }
                    
        }
        /// <summary>
        /// 问题代码 ，请不要调用
        /// </summary>
        /// <param name="l"></param>
        private void clearStagePatternByNoStageNu(List<StagePattern> l)
        {
            foreach(StagePattern p in l)
            {
                if (p.ucStageNo ==0 )
                {
                    l.Remove(p);
                }
            }
        }
        public void initcbxCoordination()
        {
            List<PhaseToDirec> lptd = Utils.Utils.GetTscDataByApplicationCurrentProperties().ListPhaseToDirec;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase != 0)
                {
                    cbxCoordination.Items.Add(ptd.ucPhase);
                }
            }
        }
        /// <summary>
        /// 初始化每个Stage的编号。
        /// </summary>
        public void initStageNumber()
        {
            Console.WriteLine("stageitemlist");
            stage1.lblNumber.Content = 1;
            stage2.lblNumber.Content = 2;
            stage3.lblNumber.Content = 3;
            stage4.lblNumber.Content = 4;
            stage5.lblNumber.Content = 5;
            stage6.lblNumber.Content = 6;
            stage7.lblNumber.Content = 7;
            stage8.lblNumber.Content = 8;
            stage9.lblNumber.Content = 9;
            stage10.lblNumber.Content = 10;
            stage11.lblNumber.Content = 11;
            stage12.lblNumber.Content = 12;
            stage13.lblNumber.Content = 13;
            stage14.lblNumber.Content = 14;
            stage15.lblNumber.Content = 15;
            stage16.lblNumber.Content = 16;
        }

        private void initBigMapArrow()
        {
            List<PhaseToDirec> lptd = Utils.Utils.GetTscDataByApplicationCurrentProperties().ListPhaseToDirec;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_LEFT)
                {
                    northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_LEFT_STRAIGHT)
                {
                   // northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_LEFT_STRAIGHT_RIGHT)
                {
                   // northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_OTHER)
                {
                    northOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                {
                    northPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                {
                    northPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_RIGHT)
                {
                    northRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_RIGHT_STRAIGHT)
                {
                   // northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_STRAIGHT)
                {
                    northStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                //东
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_LEFT)
                {
                    eastLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_LEFT_STRAIGHT)
                {
                    //east.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_LEFT_STRAIGHT_RIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_OTHER)
                {
                    eastOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                {
                    eastPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                {
                    eastPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_RIGHT)
                {
                    eastRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_RIGHT_STRAIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_STRAIGHT)
                {
                    eastStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                
                //东
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_LEFT)
                {
                    southLeft.Visibility = Visibility.Hidden;
                }

                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_LEFT_STRAIGHT)
                {
                    //east.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_LEFT_STRAIGHT_RIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_OTHER)
                {
                    southOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                {
                    southPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                {
                    southPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_RIGHT)
                {
                    southRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_RIGHT_STRAIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_STRAIGHT)
                {
                    southStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                //西
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_LEFT)
                {
                    westLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_LEFT_STRAIGHT)
                {
                    //east.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_LEFT_STRAIGHT_RIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_OTHER)
                {
                    westOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                {
                    westPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                {
                    westPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_RIGHT)
                {
                    westRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_RIGHT_STRAIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_STRAIGHT)
                {
                    westStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
            }
        }
        private void initStageAttriableByPatternId()
        {
            try
            {
                hiddenStageAll();
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (Pattern p in lp)
                {
                    if (p.ucPatternId == sldSchemeId.Value)
                    {
                        tbxCycle.Text = p.ucCycleTime.ToString();
                        cbxCoordination.SelectedItem = p.ucCoorPhase;
                        tbxOffset.Text = p.ucOffset.ToString();
                        sldStagePatternId.Value = p.ucStagePatternId;
                        //sldSchemeId.Value = p.ucPatternId;
                       
                    }
                    else
                    {
                        
                    }
                }
                foreach (StagePattern sp in lsp)
                {

                    if (sldStagePatternId.Value == sp.ucStagePatternId)
                    {
                        if (sp.ucStageNo != 0)
                        {
                            visiableStage(sp);  //stage 默认是不显示的。只有存在的情况下才显示出来。ucStageNo为0不存在。

                            uint ap = sp.usAllowPhase;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((ap >> i) & 0x01) == 0x01)
                                {
                                    foreach (PhaseToDirec ptd in lptd)
                                    {
                                        if (ptd.ucPhase != 0)
                                        {
                                            if (ptd.ucPhase == (i + 1))
                                            {
                                                //初始化
                                                InitStageDirec(ptd, sp);
                                                //Define.NORTH_LEFT
                                            }
                                        }
                                        else
                                        {
                                            initDirecArrow(ptd, sp);
                                        }

                                    }
                                }
                            }

                            sldGreenTime.Value = sp.ucGreenTime;
                            sldYellowTime.Value = sp.ucYellowTime;
                            sldRedTime.Value = sp.ucRedTime;
                            cbxReaction.IsChecked = true;//sp.ucOption;
                            // sp.ucStageNo   各个阶段编号，已经固定生成
                            //}
                        }
                        else
                        {
                            //hiddenStage(sp);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="t"></param>
        private void initStageAttriable(TscData t)
        {
            try
            {
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (Pattern p in lp)
                {
                    
                    tbxCycle.Text = p.ucCycleTime.ToString();
                    cbxCoordination.SelectedItem = p.ucCoorPhase;
                    tbxOffset.Text = p.ucOffset.ToString();
                    sldStagePatternId.Value = p.ucStagePatternId;
                    foreach (StagePattern sp in lsp)
                    {
                        if (sp.ucStageNo != 0)
                        {
                            visiableStage(sp);  //stage 默认是不显示的。只有存在的情况下才显示出来。ucStageNo为0不存在。
                            uint ap = sp.usAllowPhase;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((ap >> i) & 0x01) == 0x01)
                                {
                                    foreach (PhaseToDirec ptd in lptd)
                                    {
                                        if (ptd.ucPhase != 0)
                                        {
                                            if (ptd.ucPhase == (i + 1))
                                            {
                                                //初始化
                                                InitStageDirec(ptd, sp);
                                            }
                                        }
                                        else
                                        {
                                            initDirecArrow(ptd, sp);
                                        }
                                    }
                                }
                            }

                            sldGreenTime.Value = sp.ucGreenTime;
                            sldYellowTime.Value = sp.ucYellowTime;
                            sldRedTime.Value = sp.ucRedTime;
                            cbxReaction.IsChecked = true;//sp.ucOption;
                            // sp.ucStageNo   各个阶段编号，已经固定生成
                            
                        }
                    }
                    sldSchemeId.Value = p.ucPatternId;   //sldSchemeId有一个valuechanged事件。必需要放到其它属性之后 。不然会存在 问题
                    break;   //第一条方案记录，及些方案数据的stagepatternid 相关的stagepattern 数据列出。 其它不进行显示
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        /// <summary>
        /// 根据方向表，可以得到哪个方向有配置相位。哪个方向没有配置相位，
        /// 根据方向表的相位字段，可以将方向隐藏起来
        /// </summary>
        /// <param name="ptd"></param>
        /// <param name="sp"></param>
        private void initDirecArrow(PhaseToDirec ptd, StagePattern sp)
        {
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northPedestrain1.Visibility = Visibility.Hidden;
                northPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northPedestrain2.Visibility = Visibility.Hidden;
                northPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_TURN_AROUND && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northLeft.Visibility = Visibility.Hidden;
                northLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northStraight.Visibility = Visibility.Hidden;
                northStraight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northRight.Visibility = Visibility.Hidden;
                northRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northOther.Visibility = Visibility.Hidden;
                northOther.Visibility = Visibility.Hidden;
            }
            // 南
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southPedestrain1.Visibility = Visibility.Hidden;
                southPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southPedestrain2.Visibility = Visibility.Hidden;
                southPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southLeft.Visibility = Visibility.Hidden;
                southLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southOther.Visibility = Visibility.Hidden;
                southOther.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southRight.Visibility = Visibility.Hidden;
                southRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southStraight.Visibility = Visibility.Hidden;
                southStraight.Visibility = Visibility.Hidden;
            }
            // 西
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westPedestrain1.Visibility = Visibility.Hidden;
                westPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westPedestrain2.Visibility = Visibility.Hidden;
                westPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westLeft.Visibility = Visibility.Hidden;
                westLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westStraight.Visibility = Visibility.Hidden;
                westStraight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westRight.Visibility = Visibility.Hidden;
                westRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westOther.Visibility = Visibility.Hidden;
                westOther.Visibility = Visibility.Hidden;
            }

            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastPedestrain1.Visibility = Visibility.Hidden;
                eastPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastPedestrain2.Visibility = Visibility.Hidden;
                eastPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastLeft.Visibility = Visibility.Hidden;
                eastLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastStraight.Visibility = Visibility.Hidden;
                eastStraight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastRight.Visibility = Visibility.Hidden;
                eastRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastOther.Visibility = Visibility.Hidden;
                eastOther.Visibility = Visibility.Hidden;
            }



        }
        /// <summary>
        /// 通过stageno 得到stageitem对象
        /// </summary>
        /// <param name="stageNo"></param>
        /// <returns></returns>
        private StageItem returnStageItemObjectByStageNo(int stageNo)
        {
            if (stageNo == 1)
            {
                return stage1;
            }
            else if (stageNo == 2)
            {
                return stage2;
            }
            else if (stageNo == 3)
            {
                return stage3;
            }
            else if (stageNo == 4)
            {
                return stage4;
            }
            else if (stageNo == 5)
            {
                return stage5;
            }
            else if (stageNo == 6)
            {
                return stage6;
            }
            else if (stageNo == 7)
            {
                return stage7;
            }
            else if (stageNo == 8)
            {
                return stage8;
            }
            else if (stageNo == 9)
            {
                return stage9;
            }
            else if (stageNo == 10)
            {
                return stage10;
            }
            else if (stageNo == 11)
            {
                return stage11;
            }
            else if (stageNo == 12)
            {
                return stage12;
            }
            else if (stageNo == 13)
            {
                return stage13;
            }
            else if (stageNo == 14)
            {
                return stage14;
            }
            else if (stageNo == 15)
            {
                return stage15;
            }
            else if (stageNo == 16)
            {
                return stage16;
            }
            else
                return null;
            
        }
        /// <summary>
        /// 通过方向 表和阶段表可以确定，相应的相位已经配置上去。
        /// </summary>
        /// <param name="ptd"></param>
        /// <param name="sp"></param>
        private void InitStageDirec(PhaseToDirec ptd,StagePattern sp)
        {
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_TURN_AROUND)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_RIGHT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT_STRAIGHT_RIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative)); 

            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            // 南
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            // 西
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT_STRAIGHT_RIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT_STRAIGHT_RIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT_STRAIGHT)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            //byte direcId = ptd.ucId;
            //byte direc = Convert.ToByte(direcId >> 5);
            //byte turn = Convert.ToByte(direcId >> 3);
            //byte pedestrain = Convert.ToByte((direcId >> 3) & 0x07);

            //if (direc == 0x01)
            //{
            //    if (turn == 0x00)
            //    {

            //    }
            //}
        }
        TscData t;

        private void DispatcherInitStageNum()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitStageNumber(initStageNumber));
        }
        private void DispatcherInitStageItem()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new InitStageItemToLSI(initStageItemList));
        }
        private void DispatcherInitCoordination()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitcbxCoordination(initcbxCoordination));
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //初始化当前阶段
            currentStage = stage1;
            //初始化各个阶段的编号
            Thread tStageNum = new Thread(DispatcherInitStageNum);
            tStageNum.IsBackground = true;
            tStageNum.Start();
           // initStageNumber();
            Thread tStageItem = new Thread(DispatcherInitStageItem);
            tStageItem.IsBackground = true;
            tStageItem.Start();
           // initStageItemList();
            Thread tCoordination = new Thread(DispatcherInitCoordination);
            tCoordination.IsBackground = true;
            tCoordination.Start();
            
            //initcbxCoordination();
            //初始化所有数据到界面上
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                MessageBox.Show("请选择一台信号机后，切换到此界面！");
                return;
            }
            //initStageAttriable(t);
            
        }

        private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ///MessageBox.Show("addd stage");
        }

        private void ScrollViewer_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           // MessageBox.Show("addd stage");
        }


        private void hiddenStageAll()
        {
            foreach (StageItem si in lsi)
            {
              si.Visibility = Visibility.Hidden;
            }
        }
        /// <summary>
        /// 隐藏所有的stage 图
        /// </summary>
        private void hiddenStage(StagePattern sp)
        {
          
            foreach (StageItem si in lsi)
            {
                if (sp.usAllowPhase == 0)
                {
                    si.Visibility = Visibility.Hidden;
                    //break;
                }
            }
        }
        private void clearStageByDeleteStage(TscData t,StageItem si)
        {
            List<StagePattern> lsp = t.ListStagePattern;
            foreach(StagePattern sp in lsp)
            {
                if(sldStagePatternId.Value == sp.ucStagePatternId)
                {
                    if (sp.ucStageNo == Convert.ToByte(si.lblNumber.Content))
                    {
                        sp.ucStageNo = 0;
                        sp.ucGreenTime = 0;
                        sp.ucOption = 0;
                        sp.ucRedTime = 0;
                        sp.ucYellowTime = 0;
                        sp.usAllowPhase = 0;
                    }
                }
                
            }
        }
        private void ScrollViewer_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           // MessageBox.Show("del stage");
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (lsi[0] == stage1)
            {
                lsi.Reverse();
            }
            foreach(StageItem si in lsi)
            {
                if (si.Visibility == Visibility.Visible)
                {
                    si.Visibility = Visibility.Hidden;
                    clearStageByDeleteStage(t,si);
                    bigMapInitArllowRed();
                    break;
                }
            }
        }
        private void bigMapInitArllowRed()
        {
            northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

            eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));

            southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

            westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
        }
        private void createStageByInitArllowRed(StageItem si)
        {
            si.northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

            si.eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));

            si.southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

            si.westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            si.westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
        }
        /// <summary>
        /// 双击，创建新的stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("addd stage");
            if (lsi[0] != stage1)
            {
                lsi.Reverse();
            }
            foreach(StageItem si in lsi)
            {
                if (si.Visibility == Visibility.Hidden)
                {
                    si.Visibility = Visibility.Visible;
                    createStageByInitArllowRed(si);
                    break;
                }
            }
        }

        private void sldSchemeId_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           // initStageAttriableByPatternId();
        }
        private void DisplayStageByStagePatternIdChange()
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<StagePattern> lsp = t.ListStagePattern;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            //每次都要把stage清空，再由下面的进行显示 
            hiddenStageAll();
            foreach (StagePattern sp in lsp)
            {
                if (sldStagePatternId.Value == sp.ucStagePatternId)
                {
                    if (sp.ucStageNo != 0)
                    {
                        visiableStage(sp);  //stage 默认是不显示的。只有存在的情况下才显示出来。ucStageNo为0不存在。
                        //if (sldStagePatternId.Value == sp.ucStagePatternId)
                        //{
                        uint ap = sp.usAllowPhase;
                        for (int i = 0; i < 32; i++)
                        {
                            if (((ap >> i) & 0x01) == 0x01)
                            {
                                foreach (PhaseToDirec ptd in lptd)
                                {
                                    if (ptd.ucPhase != 0)
                                    {
                                        if (ptd.ucPhase == (i + 1))
                                        {
                                            //初始化
                                            InitStageDirec(ptd, sp);
                                            //Define.NORTH_LEFT
                                        }
                                    }
                                    else
                                    {
                                        initDirecArrow(ptd, sp);
                                    }

                                }
                            }
                        }
                        sldGreenTime.Value = sp.ucGreenTime;
                        sldYellowTime.Value = sp.ucYellowTime;
                        sldRedTime.Value = sp.ucRedTime;
                        cbxReaction.IsChecked = true;//sp.ucOption;
                        // sp.ucStageNo   各个阶段编号，已经固定生成
                        //}
                    }
                }
                else
                {
                    // hiddenStage(sp);
                }
            }
        }
        private void sldStagePatternId_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DisplayStageByStagePatternIdChange();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            { 
            ThreadPool.QueueUserWorkItem(SaveStagePattern);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BaseTime: " + ex.ToString());
            }
        }

        private void SaveStagePattern(object state)
        {
            Message msgPattern = TscDataUtils.SetPattern(t.ListPattern);
            if (!msgPattern.flag)
            {
                MessageBox.Show("对象：" + msgPattern.obj + "\n内容：" + msgPattern.msg);
            }
            Message msgStagePattern = TscDataUtils.SetStagePattern(t.ListStagePattern);
            if (!msgStagePattern.flag)
            {
                MessageBox.Show("对象：" + msgStagePattern.obj + "\n内容：" + msgStagePattern.msg);
            }
        }

        private void sldGreenTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
              //  Thread.Sleep(500);
                Slider sld = sender as Slider;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucGreenTime = Convert.ToByte(sld.Value);
                        }
                    }
                   
                }

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void sldYellowTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
              //  Thread.Sleep(500);
                Slider sld = sender as Slider;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucYellowTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void sldRedTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
             ///   Thread.Sleep(500);
               Slider sld = sender as Slider;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null)
                    {
                        if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucRedTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

    }
}
