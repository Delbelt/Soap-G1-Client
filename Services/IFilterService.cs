
namespace soap_client.Services
{
    public interface IFilterService
    {
        Task<FilterSoap> SaveFilter(FilterSoap filter);
    }
}
