using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;

namespace tscui.Pages.CountDown
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(CountDownViewModel))]
    public partial class CountDownView : UserControl,IView
    {
        public CountDownView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //throw new NotImplementedException();
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
