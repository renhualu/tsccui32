using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;

namespace tscui.Pages.Control
{
    /// <summary>
    /// Interaction logic for ControlView.xaml
    /// </summary>
    [View(typeof(ControlViewModel))]
    public partial class ControlView : UserControl,IView
    {
        public ControlView()
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
    }
}
