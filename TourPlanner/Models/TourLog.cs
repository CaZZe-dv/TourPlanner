namespace TourPlanner.Models
{
    public class TourLog
    {
        public DateTime DateTime { get; }
        public string Comment { get; }
        public float Difficulty { get; }
        public float TotalDistance { get; }
        public TimeSpan TotalTime { get; }
        public float Rating { get; }
        public TourLog(DateTime dateTime, string comment, float difficulty, float totalDistance, TimeSpan totalTime, float rating)
        {
            DateTime = dateTime;
            Comment = comment;
            Difficulty = difficulty;
            TotalDistance = totalDistance;
            TotalTime = totalTime;
            Rating = rating;
        }
    }
}