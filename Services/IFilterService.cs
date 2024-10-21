
namespace soap_client.Services
{
    public interface IFilterService
    {
        Task<FilterSoap> SaveFilter(FilterSoap filter);
        Task<List<FilterSoap>> GetFiltersByUser(int userId);
    }
}
