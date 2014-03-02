using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.Detector
{
    /// <summary>
    /// The DetectorViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class DetectorViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorViewModel"/> class.
        /// </summary>
        public DetectorViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "检测器";
            ShowPopupCommandDetector1 = new Command(DoShowPopupCommandDetector1);
            ShowPopupCommandDetector2 = new Command(DoShowPopupCommandDetector2);
            ShowPopupCommandDetector3 = new Command(DoShowPopupCommandDetector3);
            ShowPopupCommandDetector4 = new Command(DoShowPopupCommandDetector4);
        }
        private void DoShowPopupCommandDetector1()
        {
        }
        private void DoShowPopupCommandDetector2()
        {

        }
        private void DoShowPopupCommandDetector3()
        {
        }
        private void DoShowPopupCommandDetector4()
        {
        }
        public Command ShowPopupCommandDetector1 { get; private set; }
        public Command ShowPopupCommandDetector2 { get; private set; }
        public Command ShowPopupCommandDetector3 { get; private set; }
        public Command ShowPopupCommandDetector4 { get; private set; }

    }
}
