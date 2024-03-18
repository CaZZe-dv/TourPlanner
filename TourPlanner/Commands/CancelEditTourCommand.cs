using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Services;

namespace TourPlanner.Commands
{
    public class CancelEditTourCommand : CommandBase
    {
        private readonly NavigationService _navigationService;

        public CancelEditTourCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
