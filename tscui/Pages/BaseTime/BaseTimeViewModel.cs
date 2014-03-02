using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;
using tscui.Service;
using tscui.Models;
using System.Windows;

namespace tscui.Pages.BaseTime
{
    /// <summary>
    /// The BaseTimeViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class BaseTimeViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTimeViewModel"/> class.
        /// </summary>
        public BaseTimeViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.

            //  Create the example command.
           
            Title = "按月时基";
        }
       
       
    }
}
