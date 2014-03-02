using System.Windows.Controls;
using Apex;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Views;
using Microsoft.Win32;
using tscui.Utils;
using tscui.Models;
using System.Windows;
using System.Threading;
using System.Collections.Generic;

namespace tscui.Pages.Update
{
    /// <summary>
    /// Interaction logic for TheShellView.xaml
    /// </summary>
    [View(typeof(UpdateViewModel))]
    public partial class UpdateView : UserControl, IView
    {
        public UpdateView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);

            //  Handle the 'show popup' executed event.
           // ((UpdateViewModel)DataContext).ShowPopupCommand.Executed += ShowPopupCommand_Executed;
        }

        /// <summary>
        /// Handles the Executed event of the ShowPopupCommand.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="Apex.MVVM.CommandEventArgs"/> instance containing the event data.</param>
        void ShowPopupCommand_Executed(object sender, CommandEventArgs args)
        {
            //  Get the shell and show the example popup.
           // ApexBroker.GetShell().ShowPopup(new ExamplePopup());
        }

        public void OnDeactivated()
        {
            //  Remove the handler for the 'show popup' executed event.
           // ((UpdateViewModel)DataContext).ShowPopupCommand.Executed -= ShowPopupCommand_Executed;
        }

        private void TextBox_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tsc Program(*.aiton)|*.aiton";
            dialog.Multiselect = false;
            
            //TextBox tb = sender as TextBox;
            if (dialog.ShowDialog() == true)
            {
                tbxFileName.Text = dialog.FileName;
            }
        }

        private void TextBox_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
        }
        TscData t;
        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_TSC_START);
            Thread.Sleep(500);
            int result = FtpHelper.UploadFtp(tbxFileName.Text, t.Node.sIpAddress, Define.FTP_NAME, Define.FTP_PASSWD);
            Thread.Sleep(500);

            if(result == 0)
            {
                Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_TSC_FINISH);
                MessageBox.Show("升级成功！");
            }
            else if (result == -2)
            {
                //升级失败后，不要发送完成指令
                //Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_TSC_FINISH);
                MessageBox.Show("上传失败");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool b = Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_TSC_REVERSE);
            if (b == true)
            {
                MessageBox.Show("信号机程序恢复成功！");
            }
            else
            {
                MessageBox.Show("信号机程序恢复失败！");
            }
        }

        private void btnBakLocal_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Interop.HwndSource source = PresentationSource.FromVisual(this) as System.Windows.Interop.HwndSource;
            System.Windows.Forms.IWin32Window win = new FolderBrowserHelper(source.Handle);
            System.Windows.Forms.DialogResult result = dlg.ShowDialog(win);
            string path = dlg.SelectedPath;
            List<string> ls = FtpHelper.GetFileList(t.Node.sIpAddress, "/userdata/backup/", Define.FTP_NAME, Define.FTP_PASSWD);
            foreach(string fileName in ls)
            {
                FtpHelper.DownloadFtp(path, fileName, t.Node.sIpAddress + "/userdata/backup", Define.FTP_NAME, Define.FTP_PASSWD);
            }
           // FtpHelper.DownloadFtp()
        }
      
        private void btnDatabaseSelected_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tsc Database(*.db)|*.db";
            dialog.Multiselect = false;

            //TextBox tb = sender as TextBox;
            if (dialog.ShowDialog() == true)
            {
                tbxDatabase.Text = dialog.FileName;
            }
        }

        private void btnUpdateDatabase_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_DATABASE_START);
            Thread.Sleep(500);
            int result = FtpHelper.UploadFtp(tbxFileName.Text, t.Node.sIpAddress, Define.FTP_NAME, Define.FTP_PASSWD);
            Thread.Sleep(500);

            if (result == 0)
            {
                Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_DATABASE_FINISH);
                MessageBox.Show("升级成功！");
            }
            else if (result == -2)
            {
                //升级失败后，不要发送完成指令
                //Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.UPDATE_TSC_FINISH);
                MessageBox.Show("上传失败");
            }
        }
    }
}
