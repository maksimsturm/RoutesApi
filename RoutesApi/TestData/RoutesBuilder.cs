using RoutesApi.Models;

namespace RoutesApi.TestData
{
    public class RoutesBuilder
    {
        private readonly string[] Points = { "Paris", "Berlin", "Koln", "Madrid", "Praha", "Barcelona" };

        private List<RouteEntity> _routes = new List<RouteEntity>();

        public RoutesBuilder RoutesByFilter()
        { 
            _routes = GenerateRoutes().ToList();
            return this;
        }

        public RoutesBuilder RoutesByFilterFromCache()
        {
            //Here should be some logic for cache values
            _routes = GenerateRoutes().ToList();
            return this;
        }

        public List<RouteEntity> Build()
        {
            return _routes;
        }


        private IEnumerable<RouteEntity> GenerateRoutes()
        {
            return Enumerable.Range(1, 5).Select(index => new RouteEntity
            {
                StartingPoint = Points[Random.Shared.Next(Points.Length)],
                StartTime = DateTime.Now.AddDays(1).AddHours(-2),
                ArrivalPoint = Points[Random.Shared.Next(Points.Length)],
                ArrivalTime = DateTime.Now.AddDays(1).AddHours(1),
                Price = Random.Shared.NextDouble(),
                TimeToLive = DateTime.Now.AddHours(1)
            }).ToArray();
        }
    }
}
