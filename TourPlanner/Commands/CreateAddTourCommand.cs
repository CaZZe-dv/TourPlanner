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
    public class CreateAddTourCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private readonly AddTourViewModel _addTourViewModel;
        private readonly TourPlannerManager _tourPlannerManager;
        public CreateAddTourCommand(AddTourViewModel addTourViewModel, TourPlannerManager tourPlannerManager, NavigationService navigationService)
        {
            _addTourViewModel = addTourViewModel;
            _navigationService = navigationService;
            _tourPlannerManager = tourPlannerManager;
        }
        public override void Execute(object? parameter)
        {
            _tourPlannerManager.AddTour(new Tour(
                _addTourViewModel.AddTourName,
                _addTourViewModel.AddTourDescription,
                _addTourViewModel.AddTourFrom,
                _addTourViewModel.AddTourTo,
                _addTourViewModel.AddTourTransportType,
                0,
                TimeSpan.Zero,
                null
                ));

            _navigationService.Navigate();
        }
    }
}
