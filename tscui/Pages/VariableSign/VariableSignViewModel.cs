using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.VariableSign
{
    /// <summary>
    /// The VariableSignViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class VariableSignViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableSignViewModel"/> class.
        /// </summary>
        public VariableSignViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "可变标志";
        }



    }
}
