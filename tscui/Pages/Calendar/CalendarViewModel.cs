using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.Calendar
{
    /// <summary>
    /// The CalendarViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class CalendarViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarViewModel"/> class.
        /// </summary>
        public CalendarViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "特殊日历";
        }

        /// <summary>
        /// The Contacts observable collection.
        /// </summary>
        private ObservableCollection<CalendarViewModel> CalendarProperty =
          new ObservableCollection<CalendarViewModel>();

        /// <summary>
        /// Gets the Contacts observable collection.
        /// </summary>
        /// <value>The Contacts observable collection.</value>
        public ObservableCollection<CalendarViewModel> Calendars
        {
            get { return CalendarProperty; }
        }

    }
}
