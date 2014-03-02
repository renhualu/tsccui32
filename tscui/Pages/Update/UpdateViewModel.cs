using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;
using tscui.ViewModels;

namespace tscui.Pages.Update
{
    /// <summary>
    /// The TheShellViewModel ViewModel class.
    /// </summary>
    public class UpdateViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheShellViewModel"/> class.
        /// </summary>
        public UpdateViewModel()
        {
            Title = "信号机更新";

            //  Create the show popup command. It actually won't do anything in the 
            //  view model, but a view can still handle it.
           ///ShowPopupCommand = new Command(() => { });
        }

        /// <summary>
        /// Gets the show popup command.
        /// </summary>
       // public Command ShowPopupCommand { get; private set; }
    }
}
