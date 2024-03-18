using System.Drawing;
using System.Windows.Media;

namespace TourPlanner.Models
{
    public class Tour
    {
        private readonly List<TourLog> _tourLogs;
        public string Name { get; }
        public string Description { get; }
        public string From { get; }
        public string To { get; }
        public string TransportType { get; }

        public float TourDistance { get; }
        public TimeSpan EstimatedTime { get; }
        public Bitmap RouteInformation { get; }
        public Tour(string name, string description, string from, string to, string transportType, float tourDistance, TimeSpan estimatedTime, Bitmap routeInformation)
        {
            Name = name;
            Description = description;
            From = from;
            To = to;
            TransportType = transportType;
            TourDistance = tourDistance;
            EstimatedTime = estimatedTime;
            RouteInformation = routeInformation;

            _tourLogs = new List<TourLog>();
        }

        public Tour(string name) : this(name, "", "", "", "", 0, TimeSpan.Zero, null)
        {

        }

        public IEnumerable<TourLog> GetAllTourLogs()
        {
            return _tourLogs;
        }
        
    }
}