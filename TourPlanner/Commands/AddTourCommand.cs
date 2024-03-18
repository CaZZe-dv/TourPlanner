using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;
using TourPlanner.Services;

namespace TourPlanner.Commands
{
    public class AddTourCommand : CommandBase
    {
        private readonly NavigationService _addTourViewNavigationService;
        public AddTourCommand(NavigationService addTourViewNavigationService)
        {
            _addTourViewNavigationService = addTourViewNavigationService;
        }
        public override void Execute(object? parameter)
        {
            _addTourViewNavigationService.Navigate();
        }
    }
}
