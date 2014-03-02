using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;

namespace tscui.Pages.ListTsc
{
    /// <summary>
    /// Interaction logic for ListTscView.xaml
    /// </summary>
    [View(typeof(ListTscViewModel))]
    public partial class ListTscView : UserControl,IView
    {
        public ListTscView()
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
