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
using tscui.ViewModels;
using Apex.Behaviours;
using tscui.Service;
using tscui.Models;

namespace tscui.Views
{
    /// <summary>
    /// Interaction logic for PicturesView.xaml
    /// </summary>
    [View(typeof(DetectorAdvancedViewModel))]
    public partial class DetectorAdvancedView : UserControl, IView
    {
        public DetectorAdvancedView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            #region 灵敏度等级设置
            
            byte[] se = new byte[16];
            byte sen1 = Convert.ToByte(sldDetector1.Value);
            byte sen2 = Convert.ToByte(sldDetector2.Value);
            se[0] = (byte)(sen1 | sen2 << 4);

            byte sen3 = Convert.ToByte(sldDetector3.Value);
            byte sen4 = Convert.ToByte(sldDetector4.Value);
            se[1] = (byte)(sen3 | sen4 << 4);

            byte sen5 = Convert.ToByte(sldDetector5.Value);
            byte sen6 = Convert.ToByte(sldDetector6.Value);
            se[2] = (byte)(sen5 | sen6 << 4);

            byte sen7 = Convert.ToByte(sldDetector7.Value);
            byte sen8 = Convert.ToByte(sldDetector8.Value);
            se[3] = (byte)(sen7 | sen8 << 4);

            byte sen9 = Convert.ToByte(sldDetector9.Value);
            byte sen10 = Convert.ToByte(sldDetector10.Value);
            se[4] = (byte)(sen9 | sen10 << 4);

            byte sen11 = Convert.ToByte(sldDetector11.Value);
            byte sen12 = Convert.ToByte(sldDetector12.Value);
            se[5] = (byte)(sen11 | sen12 << 4);

            byte sen13 = Convert.ToByte(sldDetector13.Value);
            byte sen14 = Convert.ToByte(sldDetector14.Value);
            se[6] = (byte)(sen13 | sen14 << 4);

            byte sen15 = Convert.ToByte(sldDetector15.Value);
            byte sen16 = Convert.ToByte(sldDetector16.Value);
            se[7] = (byte)(sen15 | sen16 << 4);

            byte sen21 = Convert.ToByte(sldDetector21.Value);
            byte sen22 = Convert.ToByte(sldDetector22.Value);
            se[8] = (byte)(sen21 | sen22 << 4);

            byte sen23 = Convert.ToByte(sldDetector23.Value);
            byte sen24 = Convert.ToByte(sldDetector24.Value);
            se[9] = (byte)(sen23 | sen24 << 4);

            byte sen25 = Convert.ToByte(sldDetector25.Value);
            byte sen26 = Convert.ToByte(sldDetector26.Value);
            se[10] = (byte)(sen25 | sen26 << 4);

            byte sen27 = Convert.ToByte(sldDetector27.Value);
            byte sen28 = Convert.ToByte(sldDetector28.Value);
            se[11] = (byte)(sen27 | sen28 << 4);

            byte sen29 = Convert.ToByte(sldDetector29.Value);
            byte sen210 = Convert.ToByte(sldDetector210.Value);
            se[12] = (byte)(sen29 | sen210 << 4);

            byte sen211 = Convert.ToByte(sldDetector211.Value);
            byte sen212 = Convert.ToByte(sldDetector212.Value);
            se[13] = (byte)(sen211 | sen212 << 4);

            byte sen213 = Convert.ToByte(sldDetector213.Value);
            byte sen214 = Convert.ToByte(sldDetector214.Value);
            se[14] = (byte)(sen213 | sen214 << 4);
            byte sen215 = Convert.ToByte(sldDetector215.Value);
            byte sen216 = Convert.ToByte(sldDetector216.Value);
            se[15] = (byte)(sen215 | sen216 << 4);

            TscDataUtils.SetSensitivityAdv(se, t.Node);

            #endregion

            #region 灵敏度数值设置
            byte lv1 = Convert.ToByte(tbxLv1.Text);
            byte lv2 = Convert.ToByte(tbxLv2.Text);
            byte lv3 = Convert.ToByte(tbxLv3.Text);
            byte lv4 = Convert.ToByte(tbxLv4.Text);
            byte lv5 = Convert.ToByte(tbxLv5.Text);
            byte lv6 = Convert.ToByte(tbxLv6.Text);
            byte lv7 = Convert.ToByte(tbxLv7.Text);
            byte[] bdg1 = {lv1,lv2,lv3,lv4,lv5,lv6,lv7};
            TscDataUtils.SetSensityvityDig1(bdg1, t.Node);
            TscDataUtils.SetSensityvityDig4(bdg1, t.Node);
            byte lv8 = Convert.ToByte(tbxLv8.Text);
            byte lv9 = Convert.ToByte(tbxLv9.Text);
            byte lv10 = Convert.ToByte(tbxLv10.Text);
            byte lv11 = Convert.ToByte(tbxLv11.Text);
            byte lv12 = Convert.ToByte(tbxLv12.Text);
            byte lv13 = Convert.ToByte(tbxLv13.Text);
            byte lv14 = Convert.ToByte(tbxLv14.Text);
            byte[] bdg2 = { lv8, lv9, lv10, lv11, lv12, lv13, lv14 };
            TscDataUtils.SetSensityvityDig2(bdg2, t.Node);
            TscDataUtils.SetSensityvityDig5(bdg2, t.Node);
            byte lv15 = Convert.ToByte(tbxLv15.Text);
            byte lv16 = Convert.ToByte(tbxLv16.Text);
            byte[] bdg3 = { lv15, lv16};
            TscDataUtils.SetSensityvityDig3(bdg3, t.Node);
            TscDataUtils.SetSensityvityDig6(bdg3, t.Node);


            #endregion
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<byte> lb = TscDataUtils.GetSensitivityAdv11(t.Node);
            sldDetector1.Value = lb[5];
            sldDetector2.Value = lb[6];
            sldDetector3.Value = lb[7];
            sldDetector4.Value = lb[8];
            sldDetector5.Value = lb[9];
            sldDetector6.Value = lb[10];
            sldDetector7.Value = lb[11];
            sldDetector8.Value = lb[12];
            List<byte> lb12 = TscDataUtils.GetSensitivityAdv12(t.Node);
            sldDetector9.Value = lb12[5];
            sldDetector10.Value = lb12[6];
            sldDetector11.Value = lb12[7];
            sldDetector12.Value = lb12[8];
            sldDetector13.Value = lb12[9];
            sldDetector14.Value = lb12[10];
            sldDetector15.Value = lb12[11];
            sldDetector16.Value = lb12[12];

            List<byte> lb21 = TscDataUtils.GetSensitivityAdv21(t.Node);
            sldDetector21.Value = lb21[5];
            sldDetector22.Value = lb21[6];
            sldDetector23.Value = lb21[7];
            sldDetector24.Value = lb21[8];
            sldDetector25.Value = lb21[9];
            sldDetector26.Value = lb21[10];
            sldDetector27.Value = lb21[11];
            sldDetector28.Value = lb21[12];

            List<byte> lb22 = TscDataUtils.GetSensitivityAdv22(t.Node);
            sldDetector29.Value = lb22[5];
            sldDetector210.Value = lb22[6];
            sldDetector211.Value = lb22[7];
            sldDetector212.Value = lb22[8];
            sldDetector213.Value = lb22[9];
            sldDetector214.Value = lb22[10];
            sldDetector215.Value = lb22[11];
            sldDetector216.Value = lb22[12];

        }
    }
}
