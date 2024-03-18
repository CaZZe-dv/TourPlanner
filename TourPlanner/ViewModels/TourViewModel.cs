using TourPlanner.Models;

namespace TourPlanner.ViewModels
{
    public class TourViewModel : ViewModelBase
    {
        public readonly Tour _tour;
        public string Name => _tour.Name;

        public TourViewModel(Tour tour)
        {
            _tour = tour;   
        }
    }
}