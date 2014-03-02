using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.CountDown
{
    /// <summary>
    /// The CountDownViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class CountDownViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountDownViewModel"/> class.
        /// </summary>
        public CountDownViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "倒计时";
        }



    }
}
