using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Services;

namespace TourPlanner.Commands
{
    public class EditTourCommand : CommandBase
    {
        private readonly NavigationService _editTourViewNavigationService;

        public EditTourCommand(NavigationService editTourViewNavigationService)
        {
            _editTourViewNavigationService = editTourViewNavigationService;
        }
        public override void Execute(object? parameter)
        {
            _editTourViewNavigationService.Navigate();
        }
    }
}
