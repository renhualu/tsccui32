using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.Stage
{
    /// <summary>
    /// The StageViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class StageViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StageViewModel"/> class.
        /// </summary>
        public StageViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "阶段配时";
        }



    }
}
