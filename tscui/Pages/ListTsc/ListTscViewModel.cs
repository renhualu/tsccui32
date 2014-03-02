using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.ListTsc
{
    /// <summary>
    /// The ListTscViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class ListTscViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTscViewModel"/> class.
        /// </summary>
        public ListTscViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "在线信号列表";
        }



    }
}
