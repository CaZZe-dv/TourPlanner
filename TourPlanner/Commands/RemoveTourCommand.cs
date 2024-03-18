using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;
using TourPlanner.ViewModels;

namespace TourPlanner.Commands
{
    public class RemoveTourCommand : CommandBase
    {
        private readonly TourPlannerManager _tourPlannerManager;
        private readonly MainMenuViewModel _mainMenuViewModel;

        public RemoveTourCommand(MainMenuViewModel mainMenuViewModel, TourPlannerManager tourPlannerManager)
        {
            _mainMenuViewModel = mainMenuViewModel;
            _tourPlannerManager = tourPlannerManager;
        }
        public override void Execute(object? parameter)
        {
            _tourPlannerManager.DeleteTour(_mainMenuViewModel.SelectedTour._tour);
        }
    }
}
