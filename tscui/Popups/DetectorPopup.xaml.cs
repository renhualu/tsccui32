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
using Apex;
using tscui.Models;

namespace tscui.Popups
{
    /// <summary>
    /// Interaction logic for Detector.xaml
    /// </summary>
    public partial class DetectorPopup : UserControl
    {
        
        public string currentDetector = "";
        public  DetectorPopup(string currentDetector)
        {

        }
        public DetectorPopup()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void detector1_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void detector1_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(1);
            ApexBroker.GetShell().ClosePopup(this, true);

        }

        private void detector2_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(2);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector3_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(3);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector4_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(4);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector5_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(5);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector6_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(6);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector7_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(7);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector8_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(8);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector9_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(9);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector10_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(10);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector11_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(11);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector12_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(12);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector13_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(13);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector14_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(14);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector15_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(15);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector16_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(16);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector17_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(17);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector18_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(18);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector19_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(19);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector20_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(20);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector21_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(21);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector22_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(22);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector23_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(23);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector24_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(24);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector25_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(25);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector26_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(26);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector27_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(27);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector28_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(28);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector29_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(29);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector30_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(30);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector31_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(31);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void detector32_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            //pevent(this, 1);
            Utils.Utils.SetSelectedDetector(32);
            ApexBroker.GetShell().ClosePopup(this, true);
        }
    }
}
