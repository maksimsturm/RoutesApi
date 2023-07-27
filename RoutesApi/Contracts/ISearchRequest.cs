namespace RoutesApi.Contracts
{
    public interface ISearchRequest
    {
        public Filters Filters { get; set; }
    }
}