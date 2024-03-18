using System.Configuration;
using System.Data;
using System.Windows;
using TourPlanner.Models;
using TourPlanner.Store;
using TourPlanner.ViewModels;
using TourPlanner.Views;
using TourPlanner.Services;
using System.ComponentModel;
using TourPlanner.Commands;

namespace TourPlanner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly TourPlannerManager _tourPlannerManager;

        public App()
        {
            _navigationStore = new NavigationStore();
            _tourPlannerManager = new TourPlannerManager();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateMainMenuViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private MainMenuViewModel CreateMainMenuViewModel()
        {
            return new MainMenuViewModel(_tourPlannerManager,
                new NavigationService(_navigationStore, CreateAddTourViewModel),
                new NavigationService(_navigationStore, CreateEditTourViewModel));
        }

        private EditTourViewModel CreateEditTourViewModel()
        {
            return new EditTourViewModel(_tourPlannerManager, new NavigationService(_navigationStore, CreateMainMenuViewModel));
        }
        
        private AddTourViewModel CreateAddTourViewModel()
        {
            return new AddTourViewModel(new NavigationService(_navigationStore, CreateMainMenuViewModel),_tourPlannerManager);
        }
    }

}
