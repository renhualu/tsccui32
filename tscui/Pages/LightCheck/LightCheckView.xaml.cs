using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex;
using tscui.Views;
using tscui.Models;
using System.Windows;
using tscui.Service;
using System.Threading;

namespace tscui.Pages.LightCheck
{
    /// <summary>
    /// Interaction logic for ListTscView.xaml
    /// </summary>
    [View(typeof(LightCheckViewModel))]
    public partial class LightCheckView : UserControl,IView
    {
        public LightCheckView()
        {
            InitializeComponent();
        }


        public void OnActivated()
        {
            ((LightCheckViewModel)DataContext).SaveLightCheck.Executed += SaveLightCheck_Executed;
            ((LightCheckViewModel)DataContext).ResetLightCheck.Executed += ResetLightCheck_Executed;
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }
        private void ResetLightCheck()
        {
            TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<LampCheck> llc = TscDataUtils.GetLampCheck();

            if (llc.Count == 0)
            {
               // ApexBroker.GetShell().ShowPopup(new FailePopup());
                MessageBox.Show("无法读取灯泡检测数据！");
            }
            else
            {
                foreach (LampCheck lc in llc)
                {
                    if (lc.ucId == 1)// 第一块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.R1.IsChecked = true;
                        else
                            LampBroad1.R1.IsChecked = false;
                    }
                    if (lc.ucId == 2) //第一块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.Y1.IsChecked = true;
                        else
                            LampBroad1.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 3) //第一块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.G1.IsChecked = true;
                        else
                            LampBroad1.G1.IsChecked = false;
                    }
                    if (lc.ucId == 4)// 第一块板的第二组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.R2.IsChecked = true;
                        else
                            LampBroad1.R2.IsChecked = false;
                    }
                    if (lc.ucId == 5) //第一块板的第二组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.Y2.IsChecked = true;
                        else
                            LampBroad1.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 6) //第一块板的第二组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.G2.IsChecked = true;
                        else
                            LampBroad1.G2.IsChecked = false;
                    }
                    if (lc.ucId == 7)// 第一块板的第三组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.R3.IsChecked = true;
                        else
                            LampBroad1.R3.IsChecked = false;
                    }
                    if (lc.ucId == 8) //第一块板的第三组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.Y3.IsChecked = true;
                        else
                            LampBroad1.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 9) //第一块板的第三组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.G3.IsChecked = true;
                        else
                            LampBroad1.G3.IsChecked = false;
                    }
                    if (lc.ucId == 10)// 第一块板的第四组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.R4.IsChecked = true;
                        else
                            LampBroad1.R4.IsChecked = false;
                    }
                    if (lc.ucId == 11) //第一块板的第四组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.Y4.IsChecked = true;
                        else
                            LampBroad1.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 12) //第一块板的第四组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad1.G4.IsChecked = true;
                        else
                            LampBroad1.G4.IsChecked = false;
                    }
                    if (lc.ucId == 13)// 第二块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.R1.IsChecked = true;
                        else
                            LampBroad2.R1.IsChecked = false;
                    }
                    if (lc.ucId == 14) //第二块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.Y1.IsChecked = true;
                        else
                            LampBroad2.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 15) //第二块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.G1.IsChecked = true;
                        else
                            LampBroad2.G1.IsChecked = false;
                    }
                    if (lc.ucId == 16)// 第二块板的第二组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.R2.IsChecked = true;
                        else
                            LampBroad2.R2.IsChecked = false;
                    }
                    if (lc.ucId == 17) //第二块板的第二组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.Y2.IsChecked = true;
                        else
                            LampBroad2.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 18) //第二块板的第二组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.G2.IsChecked = true;
                        else
                            LampBroad2.G2.IsChecked = false;
                    }
                    if (lc.ucId == 19)// 第二块板的第三组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.R3.IsChecked = true;
                        else
                            LampBroad2.R3.IsChecked = false;
                    }
                    if (lc.ucId == 20) //第二块板的第三组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.Y3.IsChecked = true;
                        else
                            LampBroad2.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 21) //第二块板的第三组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.G3.IsChecked = true;
                        else
                            LampBroad2.G3.IsChecked = false;
                    }
                    if (lc.ucId == 22)// 第二块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.R4.IsChecked = true;
                        else
                            LampBroad2.R4.IsChecked = false;
                    }
                    if (lc.ucId == 23) //第二块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.Y4.IsChecked = true;
                        else
                            LampBroad2.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 24) //第二块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad2.G4.IsChecked = true;
                        else
                            LampBroad2.G4.IsChecked = false;
                    }
                    if (lc.ucId == 25)// 第3块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.R1.IsChecked = true;
                        else
                            LampBroad3.R1.IsChecked = false;
                    }
                    if (lc.ucId == 26) //第3块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.Y1.IsChecked = true;
                        else
                            LampBroad3.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 27) //第3块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.G1.IsChecked = true;
                        else
                            LampBroad3.G1.IsChecked = false;
                    }
                    if (lc.ucId == 28)// 第3块板的第2组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.R2.IsChecked = true;
                        else
                            LampBroad3.R2.IsChecked = false;
                    }
                    if (lc.ucId == 29) //第3块板的第2组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.Y2.IsChecked = true;
                        else
                            LampBroad3.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 30) //第3块板的第2组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.G2.IsChecked = true;
                        else
                            LampBroad3.G2.IsChecked = false;
                    }
                    if (lc.ucId == 31)// 第3块板的第3组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.R3.IsChecked = true;
                        else
                            LampBroad3.R3.IsChecked = false;
                    }
                    if (lc.ucId == 32) //第3块板的第3组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.Y3.IsChecked = true;
                        else
                            LampBroad3.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 33) //第3块板的第3组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.G3.IsChecked = true;
                        else
                            LampBroad3.G3.IsChecked = false;
                    }
                    if (lc.ucId == 34)// 第3块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.R4.IsChecked = true;
                        else
                            LampBroad3.R4.IsChecked = false;
                    }
                    if (lc.ucId == 35) //第3块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.Y4.IsChecked = true;
                        else
                            LampBroad3.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 36) //第3块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad3.G4.IsChecked = true;
                        else
                            LampBroad3.G4.IsChecked = false;
                    }
                    if (lc.ucId == 37)// 第4块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.R1.IsChecked = true;
                        else
                            LampBroad4.R1.IsChecked = false;
                    }
                    if (lc.ucId == 38) //第4块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.Y1.IsChecked = true;
                        else
                            LampBroad4.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 39) //第4块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.G1.IsChecked = true;
                        else
                            LampBroad4.G1.IsChecked = false;
                    }
                    if (lc.ucId == 40)// 第4块板的第2组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.R2.IsChecked = true;
                        else
                            LampBroad4.R2.IsChecked = false;
                    }
                    if (lc.ucId == 41) //第4块板的第2组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.Y2.IsChecked = true;
                        else
                            LampBroad4.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 42) //第4块板的第2组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.G2.IsChecked = true;
                        else
                            LampBroad4.G2.IsChecked = false;
                    }
                    if (lc.ucId == 43)// 第4块板的第3组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.R3.IsChecked = true;
                        else
                            LampBroad4.R3.IsChecked = false;
                    }
                    if (lc.ucId == 44) //第4块板的第3组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.Y3.IsChecked = true;
                        else
                            LampBroad4.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 45) //第4块板的第3组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.G3.IsChecked = true;
                        else
                            LampBroad4.G3.IsChecked = false;
                    }
                    if (lc.ucId == 46)// 第4块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.R4.IsChecked = true;
                        else
                            LampBroad4.R4.IsChecked = false;
                    }
                    if (lc.ucId == 47) //第4块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.Y4.IsChecked = true;
                        else
                            LampBroad4.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 48) //第4块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad4.G4.IsChecked = true;
                        else
                            LampBroad4.G4.IsChecked = false;
                    }

                    if (lc.ucId == 49)// 第4块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.R1.IsChecked = true;
                        else
                            LampBroad5.R1.IsChecked = false;
                    }
                    if (lc.ucId == 50) //第4块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.Y1.IsChecked = true;
                        else
                            LampBroad5.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 51) //第4块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.G1.IsChecked = true;
                        else
                            LampBroad5.G1.IsChecked = false;
                    }
                    if (lc.ucId == 52)// 第4块板的第2组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.R2.IsChecked = true;
                        else
                            LampBroad5.R2.IsChecked = false;
                    }
                    if (lc.ucId == 53) //第4块板的第2组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.Y2.IsChecked = true;
                        else
                            LampBroad5.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 54) //第4块板的第2组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.G2.IsChecked = true;
                        else
                            LampBroad5.G2.IsChecked = false;
                    }
                    if (lc.ucId == 55)// 第4块板的第3组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.R3.IsChecked = true;
                        else
                            LampBroad5.R3.IsChecked = false;
                    }
                    if (lc.ucId == 56) //第4块板的第3组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.Y3.IsChecked = true;
                        else
                            LampBroad5.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 57) //第4块板的第3组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.G3.IsChecked = true;
                        else
                            LampBroad5.G3.IsChecked = false;
                    }
                    if (lc.ucId == 58)// 第4块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.R4.IsChecked = true;
                        else
                            LampBroad5.R4.IsChecked = false;
                    }
                    if (lc.ucId == 59) //第4块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.Y4.IsChecked = true;
                        else
                            LampBroad5.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 60) //第4块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad5.G4.IsChecked = true;
                        else
                            LampBroad5.G4.IsChecked = false;
                    }

                    if (lc.ucId == 61)// 第4块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.R1.IsChecked = true;
                        else
                            LampBroad6.R1.IsChecked = false;
                    }
                    if (lc.ucId == 62) //第4块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.Y1.IsChecked = true;
                        else
                            LampBroad6.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 63) //第4块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.G1.IsChecked = true;
                        else
                            LampBroad6.G1.IsChecked = false;
                    }
                    if (lc.ucId == 64)// 第4块板的第2组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.R2.IsChecked = true;
                        else
                            LampBroad6.R2.IsChecked = false;
                    }
                    if (lc.ucId == 65) //第4块板的第2组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.Y2.IsChecked = true;
                        else
                            LampBroad6.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 66) //第4块板的第2组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.G2.IsChecked = true;
                        else
                            LampBroad6.G2.IsChecked = false;
                    }
                    if (lc.ucId == 67)// 第4块板的第3组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.R3.IsChecked = true;
                        else
                            LampBroad6.R3.IsChecked = false;
                    }
                    if (lc.ucId == 68) //第4块板的第3组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.Y3.IsChecked = true;
                        else
                            LampBroad6.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 69) //第4块板的第3组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.G3.IsChecked = true;
                        else
                            LampBroad6.G3.IsChecked = false;
                    }
                    if (lc.ucId == 70)// 第4块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.R4.IsChecked = true;
                        else
                            LampBroad6.R4.IsChecked = false;
                    }
                    if (lc.ucId == 71) //第4块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.Y4.IsChecked = true;
                        else
                            LampBroad6.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 72) //第4块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad6.G4.IsChecked = true;
                        else
                            LampBroad6.G4.IsChecked = false;
                    }

                    if (lc.ucId == 73)// 第4块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.R1.IsChecked = true;
                        else
                            LampBroad7.R1.IsChecked = false;
                    }
                    if (lc.ucId == 74) //第4块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.Y1.IsChecked = true;
                        else
                            LampBroad7.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 75) //第4块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.G1.IsChecked = true;
                        else
                            LampBroad7.G1.IsChecked = false;
                    }
                    if (lc.ucId == 76)// 第4块板的第2组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.R2.IsChecked = true;
                        else
                            LampBroad7.R2.IsChecked = false;
                    }
                    if (lc.ucId == 77) //第4块板的第2组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.Y2.IsChecked = true;
                        else
                            LampBroad7.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 78) //第4块板的第2组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.G2.IsChecked = true;
                        else
                            LampBroad7.G2.IsChecked = false;
                    }
                    if (lc.ucId == 79)// 第4块板的第3组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.R3.IsChecked = true;
                        else
                            LampBroad7.R3.IsChecked = false;
                    }
                    if (lc.ucId == 80) //第4块板的第3组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.Y3.IsChecked = true;
                        else
                            LampBroad7.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 81) //第4块板的第3组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.G3.IsChecked = true;
                        else
                            LampBroad7.G3.IsChecked = false;
                    }
                    if (lc.ucId == 82)// 第4块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.R4.IsChecked = true;
                        else
                            LampBroad7.R4.IsChecked = false;
                    }
                    if (lc.ucId == 83) //第4块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.Y4.IsChecked = true;
                        else
                            LampBroad7.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 84) //第4块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad7.G4.IsChecked = true;
                        else
                            LampBroad7.G4.IsChecked = false;
                    }

                    if (lc.ucId == 85)// 第4块板的第一组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.R1.IsChecked = true;
                        else
                            LampBroad8.R1.IsChecked = false;
                    }
                    if (lc.ucId == 86) //第4块板的第一组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.Y1.IsChecked = true;
                        else
                            LampBroad8.Y1.IsChecked = false;
                    }
                    if (lc.ucId == 87) //第4块板的第一组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.G1.IsChecked = true;
                        else
                            LampBroad8.G1.IsChecked = false;
                    }
                    if (lc.ucId == 88)// 第4块板的第2组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.R2.IsChecked = true;
                        else
                            LampBroad8.R2.IsChecked = false;
                    }
                    if (lc.ucId == 89) //第4块板的第2组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.Y2.IsChecked = true;
                        else
                            LampBroad8.Y2.IsChecked = false;
                    }
                    if (lc.ucId == 90) //第4块板的第2组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.G2.IsChecked = true;
                        else
                            LampBroad8.G2.IsChecked = false;
                    }
                    if (lc.ucId == 91)// 第4块板的第3组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.R3.IsChecked = true;
                        else
                            LampBroad8.R3.IsChecked = false;
                    }
                    if (lc.ucId == 92) //第4块板的第3组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.Y3.IsChecked = true;
                        else
                            LampBroad8.Y3.IsChecked = false;
                    }
                    if (lc.ucId == 93) //第4块板的第3组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.G3.IsChecked = true;
                        else
                            LampBroad8.G3.IsChecked = false;
                    }
                    if (lc.ucId == 94)// 第4块板的第4组的红灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.R4.IsChecked = true;
                        else
                            LampBroad8.R4.IsChecked = false;
                    }
                    if (lc.ucId == 95) //第4块板的第4组的黄灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.Y4.IsChecked = true;
                        else
                            LampBroad8.Y4.IsChecked = false;
                    }
                    if (lc.ucId == 96) //第4块板的第4组的绿灯
                    {
                        if (lc.ucFlag == 1)
                            LampBroad8.G4.IsChecked = true;
                        else
                            LampBroad8.G4.IsChecked = false;
                    }
                }
               // ApexBroker.GetShell().ShowPopup(new SuccessPopup());
            }
            
        }
        void ResetLightCheck_Executed(object sender, CommandEventArgs args)
        {
            ResetLightCheck();
        
        }
        private void SaveLightCheck(object state)
        {
            byte[] hex = new byte[196];
            hex[0] = 0x81;
            hex[1] = 0xFF;
            hex[2] = 0x00;
            hex[3] = 0x60;

            hex[4] = 0x01;
            bool br11 = LampBroad1.R1.IsChecked.Value;
            if (br11)
                hex[5] = 0x01;
            else
                hex[5] = 0x00;
            hex[6] = 0x02;
            bool by11 = LampBroad1.Y1.IsChecked.Value;
            if (by11)
                hex[7] = 0x01;
            else
                hex[7] = 0x00;

            hex[8] = 0x03;
            bool bg11 = LampBroad1.G1.IsChecked.Value;
            if (bg11)
                hex[9] = 0x01;
            else
                hex[9] = 0x00;

            hex[10] = 0x04;
            bool br12 = LampBroad1.R2.IsChecked.Value;
            if (br12)
                hex[11] = 0x01;
            else
                hex[11] = 0x00;

            hex[12] = 0x05;
            bool by12 = LampBroad1.Y2.IsChecked.Value;
            if (by12)
                hex[13] = 0x01;
            else
                hex[13] = 0x00;

            hex[14] = 0x06;
            bool bg12 = LampBroad1.G2.IsChecked.Value;
            if (bg12)
                hex[15] = 0x01;
            else
                hex[15] = 0x00;

            hex[16] = 0x07;
            bool br13 = LampBroad1.R3.IsChecked.Value;
            if (br13)
                hex[17] = 0x01;
            else
                hex[17] = 0x00;

            bool by13 = LampBroad1.Y3.IsChecked.Value;
            hex[18] = 0x08;
            if (by13)
                hex[19] = 0x01;
            else
                hex[19] = 0x00;
            bool bg13 = LampBroad1.G3.IsChecked.Value;
            hex[20] = 0x09;
            if (bg13)
                hex[21] = 0x01;
            else
                hex[21] = 0x00;
            bool br14 = LampBroad1.R4.IsChecked.Value;
            hex[22] = 0x0a;
            if (br14)
                hex[23] = 0x01;
            else
                hex[23] = 0x00;
            bool by14 = LampBroad1.Y4.IsChecked.Value;
            hex[24] = 0x0b;
            if (by14)
                hex[25] = 0x01;
            else
                hex[25] = 0x00;
            bool bg14 = LampBroad1.G4.IsChecked.Value;
            hex[26] = 0x0c;
            if (bg14)
                hex[27] = 0x01;
            else
                hex[27] = 0x00;
            bool br21 = LampBroad2.R1.IsChecked.Value;
            hex[28] = 0x0d;
            if (br21)
                hex[29] = 0x01;
            else
                hex[29] = 0x00;
            bool by21 = LampBroad2.Y1.IsChecked.Value;
            hex[30] = 0x0e;
            if (by21)
                hex[31] = 0x01;
            else
                hex[31] = 0x00;
            bool bg21 = LampBroad2.G1.IsChecked.Value;
            hex[32] = 0x0f;
            if (bg21)
                hex[33] = 0x01;
            else
                hex[33] = 0x00;
            bool br22 = LampBroad2.R2.IsChecked.Value;
            hex[34] = 0x10;
            if (br22)
                hex[35] = 0x01;
            else
                hex[35] = 0x00;
            bool by22 = LampBroad2.Y2.IsChecked.Value;
            hex[36] = 0x11;
            if (by22)
                hex[37] = 0x01;
            else
                hex[37] = 0x00;
            bool bg22 = LampBroad2.G2.IsChecked.Value;
            hex[38] = 0x12;
            if (bg22)
                hex[39] = 0x01;
            else
                hex[39] = 0x00;
            bool br23 = LampBroad2.R3.IsChecked.Value;
            hex[40] = 0x13;
            if (br23)
                hex[41] = 0x01;
            else
                hex[41] = 0x00;
            bool by23 = LampBroad2.Y3.IsChecked.Value;
            hex[42] = 0x14;
            if (by23)
                hex[43] = 0x01;
            else
                hex[43] = 0x00;
            bool bg23 = LampBroad2.G3.IsChecked.Value;
            hex[44] = 0x15;
            if (bg23)
                hex[45] = 0x01;
            else
                hex[45] = 0x00;
            bool br24 = LampBroad2.R4.IsChecked.Value;
            hex[46] = 0x16;
            if (br24)
                hex[47] = 0x01;
            else
                hex[47] = 0x00;
            bool by24 = LampBroad2.Y4.IsChecked.Value;
            hex[48] = 0x17;
            if (by24)
                hex[49] = 0x01;
            else
                hex[49] = 0x00;
            bool bg24 = LampBroad2.G4.IsChecked.Value;
            hex[50] = 0x18;
            if (bg24)
                hex[51] = 0x01;
            else
                hex[51] = 0x00;
            bool br31 = LampBroad3.R1.IsChecked.Value;
            hex[52] = 0x19;
            if (br31)
                hex[53] = 0x01;
            else
                hex[53] = 0x00;
            bool by31 = LampBroad3.Y1.IsChecked.Value;
            hex[54] = 0x1a;
            if (by31)
                hex[55] = 0x01;
            else
                hex[55] = 0x00;
            bool bg31 = LampBroad3.G1.IsChecked.Value;
            hex[56] = 0x1b;
            if (bg31)
                hex[57] = 0x01;
            else
                hex[57] = 0x00;
            bool br32 = LampBroad3.R2.IsChecked.Value;
            hex[58] = 0x1c;
            if (br32)
                hex[59] = 0x01;
            else
                hex[59] = 0x00;
            bool by32 = LampBroad3.Y2.IsChecked.Value;
            hex[60] = 0x1d;
            if (by32)
                hex[61] = 0x01;
            else
                hex[61] = 0x00;
            bool bg32 = LampBroad3.G2.IsChecked.Value;
            hex[62] = 0x1e;
            if (bg32)
                hex[63] = 0x01;
            else
                hex[63] = 0x00;
            bool br33 = LampBroad3.R3.IsChecked.Value;
            hex[64] = 0x1f;
            if (br33)
                hex[65] = 0x01;
            else
                hex[65] = 0x00;
            bool by33 = LampBroad3.Y3.IsChecked.Value;
            hex[66] = 0x20;
            if (by33)
                hex[67] = 0x01;
            else
                hex[67] = 0x00;
            bool bg33 = LampBroad3.G3.IsChecked.Value;
            hex[68] = 0x21;
            if (bg33)
                hex[69] = 0x01;
            else
                hex[69] = 0x00;
            bool br34 = LampBroad3.R4.IsChecked.Value;
            hex[70] = 0x22;
            if (br34)
                hex[71] = 0x01;
            else
                hex[71] = 0x00;
            bool by34 = LampBroad3.Y4.IsChecked.Value;
            hex[72] = 0x23;
            if (by34)
                hex[73] = 0x01;
            else
                hex[73] = 0x00;
            bool bg34 = LampBroad3.G4.IsChecked.Value;
            hex[74] = 0x24;
            if (bg34)
                hex[75] = 0x01;
            else
                hex[75] = 0x00;
            //第四块板
            bool br41 = LampBroad4.R1.IsChecked.Value;
            hex[76] = 0x25;
            if (br41)
                hex[77] = 0x01;
            else
                hex[77] = 0x00;
            bool by41 = LampBroad4.Y1.IsChecked.Value;
            hex[78] = 0x26;
            if (by41)
                hex[79] = 0x01;
            else
                hex[79] = 0x00;
            bool bg41 = LampBroad4.G1.IsChecked.Value;
            hex[80] = 0x27;
            if (bg41)
                hex[81] = 0x01;
            else
                hex[81] = 0x00;
            bool br42 = LampBroad4.R2.IsChecked.Value;
            hex[82] = 0x28;
            if (br42)
                hex[83] = 0x01;
            else
                hex[83] = 0x00;
            bool by42 = LampBroad4.Y2.IsChecked.Value;
            hex[84] = 0x29;
            if (by42)
                hex[85] = 0x01;
            else
                hex[85] = 0x00;
            bool bg42 = LampBroad4.G2.IsChecked.Value;
            hex[86] = 0x2a;
            if (bg42)
                hex[87] = 0x01;
            else
                hex[87] = 0x00;
            bool br43 = LampBroad4.R3.IsChecked.Value;
            hex[88] = 0x2b;
            if (br43)
                hex[89] = 0x01;
            else
                hex[89] = 0x00;
            bool by43 = LampBroad4.Y3.IsChecked.Value;
            hex[90] = 0x2c;
            if (by43)
                hex[91] = 0x01;
            else
                hex[91] = 0x00;
            bool bg43 = LampBroad4.G3.IsChecked.Value;
            hex[92] = 0x2d;
            if (bg43)
                hex[93] = 0x01;
            else
                hex[93] = 0x00;
            bool br44 = LampBroad4.R4.IsChecked.Value;
            hex[94] = 0x2e;
            if (br44)
                hex[95] = 0x01;
            else
                hex[95] = 0x00;
            bool by44 = LampBroad4.Y4.IsChecked.Value;
            hex[96] = 0x2f;
            if (by44)
                hex[97] = 0x01;
            else
                hex[97] = 0x00;
            bool bg44 = LampBroad4.G4.IsChecked.Value;
            hex[98] = 0x30;
            if (bg44)
                hex[99] = 0x01;
            else
                hex[99] = 0x00;
            //第5块板
            bool br51 = LampBroad5.R1.IsChecked.Value;
            hex[100] = 0x31;
            if (br51)
                hex[101] = 0x01;
            else
                hex[101] = 0x00;
            bool by51 = LampBroad5.Y1.IsChecked.Value;
            hex[102] = 0x32;
            if (by51)
                hex[103] = 0x01;
            else
                hex[103] = 0x00;
            bool bg51 = LampBroad5.G1.IsChecked.Value;
            hex[104] = 0x33;
            if (bg51)
                hex[105] = 0x01;
            else
                hex[105] = 0x00;
            bool br52 = LampBroad5.R2.IsChecked.Value;
            hex[106] = 0x34;
            if (br52)
                hex[107] = 0x01;
            else
                hex[107] = 0x00;
            bool by52 = LampBroad5.Y2.IsChecked.Value;
            hex[108] = 0x35;
            if (by52)
                hex[109] = 0x01;
            else
                hex[109] = 0x00;
            bool bg52 = LampBroad5.G2.IsChecked.Value;
            hex[110] = 0x36;
            if (bg52)
                hex[111] = 0x01;
            else
                hex[111] = 0x00;
            bool br53 = LampBroad5.R3.IsChecked.Value;
            hex[112] = 0x37;
            if (br53)
                hex[113] = 0x01;
            else
                hex[113] = 0x00;
            bool by53 = LampBroad5.Y3.IsChecked.Value;
            hex[114] = 0x38;
            if (by53)
                hex[115] = 0x01;
            else
                hex[115] = 0x00;
            bool bg53 = LampBroad5.G3.IsChecked.Value;
            hex[116] = 0x39;
            if (bg53)
                hex[117] = 0x01;
            else
                hex[117] = 0x00;
            bool br54 = LampBroad5.R4.IsChecked.Value;
            hex[118] = 0x3a;
            if (br54)
                hex[119] = 0x01;
            else
                hex[119] = 0x00;
            bool by54 = LampBroad5.Y4.IsChecked.Value;
            hex[120] = 0x3b;
            if (by54)
                hex[121] = 0x01;
            else
                hex[121] = 0x00;
            bool bg54 = LampBroad5.G4.IsChecked.Value;
            hex[122] = 0x3c;
            if (bg54)
                hex[123] = 0x01;
            else
                hex[123] = 0x00;
            //第5块板
            bool br61 = LampBroad6.R1.IsChecked.Value;
            hex[124] = 0x3d;
            if (br61)
                hex[125] = 0x01;
            else
                hex[125] = 0x00;
            bool by61 = LampBroad6.Y1.IsChecked.Value;
            hex[126] = 0x3e;
            if (by61)
                hex[127] = 0x01;
            else
                hex[127] = 0x00;
            bool bg61 = LampBroad6.G1.IsChecked.Value;
            hex[128] = 0x3f;
            if (bg61)
                hex[129] = 0x01;
            else
                hex[129] = 0x00;
            bool br62 = LampBroad6.R2.IsChecked.Value;
            hex[130] = 0x40;
            if (br62)
                hex[131] = 0x01;
            else
                hex[131] = 0x00;
            bool by62 = LampBroad6.Y2.IsChecked.Value;
            hex[132] = 0x41;
            if (by62)
                hex[133] = 0x01;
            else
                hex[133] = 0x00;
            bool bg62 = LampBroad6.G2.IsChecked.Value;
            hex[134] = 0x42;
            if (bg62)
                hex[135] = 0x01;
            else
                hex[135] = 0x00;
            bool br63 = LampBroad6.R3.IsChecked.Value;
            hex[136] = 0x43;
            if (br63)
                hex[137] = 0x01;
            else
                hex[137] = 0x00;
            bool by63 = LampBroad6.Y3.IsChecked.Value;
            hex[138] = 0x44;
            if (by63)
                hex[139] = 0x01;
            else
                hex[139] = 0x00;
            bool bg63 = LampBroad6.G3.IsChecked.Value;
            hex[140] = 0x45;
            if (bg63)
                hex[141] = 0x01;
            else
                hex[141] = 0x00;
            bool br64 = LampBroad6.R4.IsChecked.Value;
            hex[142] = 0x46;
            if (br64)
                hex[143] = 0x01;
            else
                hex[143] = 0x00;
            bool by64 = LampBroad6.Y4.IsChecked.Value;
            hex[144] = 0x47;
            if (by64)
                hex[145] = 0x01;
            else
                hex[145] = 0x00;
            bool bg64 = LampBroad6.G4.IsChecked.Value;
            hex[146] = 0x48;
            if (bg64)
                hex[147] = 0x01;
            else
                hex[147] = 0x00;
            //第5块板
            bool br71 = LampBroad7.R1.IsChecked.Value;
            hex[148] = 0x49;
            if (br71)
                hex[149] = 0x01;
            else
                hex[149] = 0x00;
            bool by71 = LampBroad7.Y1.IsChecked.Value;
            hex[150] = 0x4a;
            if (by71)
                hex[151] = 0x01;
            else
                hex[151] = 0x00;
            bool bg71 = LampBroad7.G1.IsChecked.Value;
            hex[152] = 0x4b;
            if (bg71)
                hex[153] = 0x01;
            else
                hex[153] = 0x00;
            bool br72 = LampBroad7.R2.IsChecked.Value;
            hex[154] = 0x4c;
            if (br72)
                hex[155] = 0x01;
            else
                hex[155] = 0x00;
            bool by72 = LampBroad7.Y2.IsChecked.Value;
            hex[156] = 0x4d;
            if (by72)
                hex[157] = 0x01;
            else
                hex[157] = 0x00;
            bool bg72 = LampBroad7.G2.IsChecked.Value;
            hex[158] = 0x4e;
            if (bg72)
                hex[159] = 0x01;
            else
                hex[159] = 0x00;
            bool br73 = LampBroad7.R3.IsChecked.Value;
            hex[160] = 0x4f;
            if (br73)
                hex[161] = 0x01;
            else
                hex[161] = 0x00;
            bool by73 = LampBroad7.Y3.IsChecked.Value;
            hex[162] = 0x50;
            if (by73)
                hex[163] = 0x01;
            else
                hex[163] = 0x00;
            bool bg73 = LampBroad7.G3.IsChecked.Value;
            hex[164] = 0x51;
            if (bg73)
                hex[165] = 0x01;
            else
                hex[165] = 0x00;
            bool br74 = LampBroad7.R4.IsChecked.Value;
            hex[166] = 0x52;
            if (br74)
                hex[167] = 0x01;
            else
                hex[167] = 0x00;
            bool by74 = LampBroad7.Y4.IsChecked.Value;
            hex[168] = 0x53;
            if (by74)
                hex[169] = 0x01;
            else
                hex[169] = 0x00;
            bool bg74 = LampBroad7.G4.IsChecked.Value;
            hex[170] = 0x54;
            if (bg74)
                hex[171] = 0x01;
            else
                hex[171] = 0x00;
            //第5块板
            bool br81 = LampBroad8.R1.IsChecked.Value;
            hex[172] = 0x55;
            if (br81)
                hex[173] = 0x01;
            else
                hex[173] = 0x00;
            bool by81 = LampBroad8.Y1.IsChecked.Value;
            hex[174] = 0x56;
            if (by81)
                hex[175] = 0x01;
            else
                hex[175] = 0x00;
            bool bg81 = LampBroad8.G1.IsChecked.Value;
            hex[176] = 0x57;
            if (bg81)
                hex[177] = 0x01;
            else
                hex[177] = 0x00;
            bool br82 = LampBroad8.R2.IsChecked.Value;
            hex[178] = 0x58;
            if (br82)
                hex[179] = 0x01;
            else
                hex[179] = 0x00;
            bool by82 = LampBroad8.Y2.IsChecked.Value;
            hex[180] = 0x59;
            if (by82)
                hex[181] = 0x01;
            else
                hex[181] = 0x00;
            bool bg82 = LampBroad8.G2.IsChecked.Value;
            hex[182] = 0x5a;
            if (bg82)
                hex[183] = 0x01;
            else
                hex[183] = 0x00;
            bool br83 = LampBroad8.R3.IsChecked.Value;
            hex[184] = 0x5b;
            if (br83)
                hex[185] = 0x01;
            else
                hex[185] = 0x00;
            bool by83 = LampBroad8.Y3.IsChecked.Value;
            hex[186] = 0x5c;
            if (by83)
                hex[187] = 0x01;
            else
                hex[187] = 0x00;
            bool bg83 = LampBroad8.G3.IsChecked.Value;
            hex[188] = 0x5d;
            if (bg83)
                hex[189] = 0x01;
            else
                hex[189] = 0x00;
            bool br84 = LampBroad8.R4.IsChecked.Value;
            hex[190] = 0x5e;
            if (br84)
                hex[191] = 0x01;
            else
                hex[191] = 0x00;
            bool by84 = LampBroad8.Y4.IsChecked.Value;
            hex[192] = 0x5f;
            if (by84)
                hex[193] = 0x01;
            else
                hex[193] = 0x00;
            bool bg84 = LampBroad8.G4.IsChecked.Value;
            hex[194] = 0x60;
            if (bg84)
                hex[195] = 0x01;
            else
                hex[195] = 0x00;

            string ipaddr = ipAddress.Text;
            Models.LampCheck lc = new LampCheck();
            lc.ucId = 1;
            lc.ucFlag = 1;
            List<LampCheck> listLampCheck = new List<LampCheck>();
            listLampCheck.Add(lc);
            bool b = Udp.sendUdpNoReciveData(ipaddr, 5435, hex);

            
        }
        void SaveLightCheck_Executed(object sender, CommandEventArgs args)
        {
            SaveLightCheck(null);
        }
        TscData td;
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            if (td == null)
            {
                return;
            }
            else
            {
                ipAddress.Text = td.Node.sIpAddress;
            }
            
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckItem_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {

            try
            { 
                //ThreadPool.QueueUserWorkItem(SaveLightCheck);
                SaveLightCheck(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LightCheck: " + ex.ToString());
            }
        }

    }
}
