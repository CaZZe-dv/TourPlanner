using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class TourPlannerManager
    {
        private readonly List<Tour> _tours;
        public TourPlannerManager()
        {
            _tours = new List<Tour>();
        }

        public IEnumerable<Tour> GetAllTours()
        {
            return _tours;
        }

        public void AddTour(Tour tour)
        {
            _tours.Add(tour);
        }

        public Tour? UpdateTour(Tour oldTour, Tour newTour)
        {
            for(int i = 0; i < _tours.Count; i++)
            {
                if (_tours[i] == oldTour)
                {
                    _tours[i] = newTour;
                    return newTour;
                }
            }
            return null;
        }

        public bool DeleteTour(Tour tour)
        {
            return _tours.Remove(tour);
        }
    }
}
