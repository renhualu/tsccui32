using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.Schedules
{
    /// <summary>
    /// The CountDownViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class ScheduleViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the  class.
        /// </summary>
        public ScheduleViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "时段表";
        }



    }
}
