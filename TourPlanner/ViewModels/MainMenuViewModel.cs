using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner.Commands;
using TourPlanner.Models;
using TourPlanner.Services;

namespace TourPlanner.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        public ICommand MainMenuFileCommand { get; }
        public ICommand MainMenuEditCommand { get; }
        public ICommand MainMenuOptionsCommand { get; }
        public ICommand MainMenuHelpCommand { get; }

        private string _searchBar;

        public string SearchBar
        {
            get => _searchBar;
            set
            {
                _searchBar = value;
                OnPropertyChanged(nameof(SearchBar));
            }
        }


        private readonly ObservableCollection<TourViewModel> _tours;
        public IEnumerable<TourViewModel> Tours => _tours;

        private readonly TourPlannerManager _tourPlannerManager;

        public ICommand ListControlViewButtonPlus { get; }
        public ICommand ListControlViewButtonMinus { get; }
        public ICommand ListControlViewButtonEdit { get; }

        private TourViewModel _selectedTour;
        public TourViewModel SelectedTour
        {
            get => _selectedTour;
            set
            {
                _selectedTour = value;
                OnPropertyChanged(nameof(SelectedTour));
            }
        }

        public MainMenuViewModel(TourPlannerManager tourPlannerManager, NavigationService addTourNavigationService, NavigationService editTourNavigationService)
        {
            _tours = new ObservableCollection<TourViewModel>();
            _tours.Add(new TourViewModel(new Tour(
                "Tour 1")));
            _tours.Add(new TourViewModel(new Tour(
                "Tour 2")));
            _tours.Add(new TourViewModel(new Tour(
                "Tour 3")));
            _tourPlannerManager = tourPlannerManager;
            ListControlViewButtonPlus = new AddTourCommand(addTourNavigationService);
            ListControlViewButtonMinus = new RemoveTourCommand(this, tourPlannerManager);
            ListControlViewButtonEdit = new EditTourCommand(editTourNavigationService);
        }
    }
}
