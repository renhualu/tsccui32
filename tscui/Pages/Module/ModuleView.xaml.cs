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

namespace tscui.Views
{
    /// <summary>
    /// Interaction logic for MusicView.xaml
    /// </summary>
    [View(typeof(ModuleViewModel))]
    public partial class ModuleView : UserControl, IView
    {
        public ModuleView()
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

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
