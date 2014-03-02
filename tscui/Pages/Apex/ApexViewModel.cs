﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;
using tscui.ViewModels;

namespace tscui.Pages.Apex
{
    /// <summary>
    /// The ApexViewModel ViewModel class.
    /// </summary>
    public class ApexViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApexViewModel"/> class.
        /// </summary>
        public ApexViewModel()
        {
            Title = "信号控制";
        }
    }
}
