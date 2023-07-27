namespace RoutesApi.Models
{
    public class RouteEntity
    {
        public string StartingPoint { get; set; }

        public string ArrivalPoint { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public double Price { get; set; }

        public DateTime TimeToLive { get; set; }
    }
}
