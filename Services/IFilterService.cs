namespace soap_client.Services
{
    public interface IFilterService
    {
        public Task<List<FilterSoap>> GetFiltersByUserId(int userId);
    }
}
