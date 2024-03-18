using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;
using TourPlanner.Services;
using TourPlanner.ViewModels;

namespace TourPlanner.Commands
{
    public class UpdateEditTourCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly TourPlannerManager _tourPlannerManager;
        private readonly EditTourViewModel _editTourViewModel;

        public UpdateEditTourCommand(EditTourViewModel editTourViewModel, TourPlannerManager tourPlannerManager, NavigationService navigationService)
        {
            _editTourViewModel = editTourViewModel;
            _tourPlannerManager = tourPlannerManager;
            _navigationService = navigationService;
        }
        public override void Execute(object? parameter)
        {
            //_tourPlannerManager.UpdateTour();
            _navigationService.Navigate();
        }
    }
}
