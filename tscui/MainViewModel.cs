using Apex.MVVM;
using tscui.Pages;
using tscui.Pages.Apex;
using tscui.Pages.ThePages;
using tscui.ViewModels;
using tscui.Pages.Phase;
using tscui.Pages.Detector;
using tscui.Pages.Collision;
using tscui.Pages.Stage;
using tscui.Pages.CountDown;
using tscui.Pages.VariableSign;
using tscui.Pages.BaseTime;
using tscui.Pages.Calendar;
using tscui.Pages.LightCheck;
using tscui.Pages.Config;
using tscui.Service;
using tscui.Pages.Degradation;
using tscui.Pages.Log;
using tscui.Utils;
using System.Data.SQLite;
using tscui.Pages.Schedules;
using tscui.Pages.Update;

namespace tscui
{
    /// <summary>
    /// The MainViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class MainViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            //  Set the title.
            Title = "tscui";
            RuntasticHeartRate rhr = new RuntasticHeartRate();
            rhr.RunHeartRate();
            //  Create the pages.
            CreatePages();
        }

        /// <summary>
        /// Creates the pages.
        /// </summary>
        private void CreatePages()
        {
            //  Create the 'home' section.
            var homeViewModel = new PageViewModel()
            {
                IsSelected = true,
                Title = "主页"
            };

            //  Add home pages.
            homeViewModel.Pages.Add(new ApexViewModel() { IsSelected = true });
            

            //  Create the 'collection' section.
            var signalViewModel = new PageViewModel() { Title = "信号" };

            //  Add the collection pages.
            signalViewModel.Pages.Add(new PhaseViewModel() { IsSelected = true });
            signalViewModel.Pages.Add(new CollisionViewModel());
            signalViewModel.Pages.Add(new StageViewModel());
            signalViewModel.Pages.Add(new DetectorViewModel());
            signalViewModel.Pages.Add(new LightCheckViewModel());
            signalViewModel.Pages.Add(new DetectorAdvancedViewModel());

            //  Create the 'collection' section.
            var timeViewModel = new PageViewModel() { Title = "时基" };

            //  Add the collection pages.
            timeViewModel.Pages.Add(new BaseTimeViewModel() { IsSelected = true });
            timeViewModel.Pages.Add(new SeasonTimeViewModel());
            timeViewModel.Pages.Add(new CalendarViewModel());
            timeViewModel.Pages.Add(new ScheduleViewModel());

            //  Create the 'collection' section.
            var peripheralViewModel = new PageViewModel() { Title = "外设" };

            //  Add the collection pages.
            peripheralViewModel.Pages.Add(new CountDownViewModel() { IsSelected = true });
            peripheralViewModel.Pages.Add(new VariableSignViewModel());
            
            peripheralViewModel.Pages.Add(new DegradationViewModel());


            //系统配置相关
            var systemViewModel = new PageViewModel() { Title = "系统" };
            systemViewModel.Pages.Add(new ModuleViewModel());
            systemViewModel.Pages.Add(new LogsViewModel());
            systemViewModel.Pages.Add(new ConfigViewModel() { IsSelected = true });
            systemViewModel.Pages.Add(new UpdateViewModel());
            
            //  Add the page groups to the view model.




            Pages.Add(homeViewModel);
            Pages.Add(timeViewModel);
            Pages.Add(signalViewModel);
            Pages.Add(peripheralViewModel);
            Pages.Add(systemViewModel);

           // SQLiteConnection sc = SQLiteHelper.GetSQLiteConnection();
        }
    }
}
