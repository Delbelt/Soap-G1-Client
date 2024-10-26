namespace soap_client.Services
{
    public interface IFilterService
    {
        public Task<List<FilterSoap>> GetFiltersByUserId(int userId);
        public Task<FilterSoap> SaveFilter(SaveFilterType filter);
        public Task<FilterSoap> EditFilter(EditFilterType filter);
        public Task<bool> DeleteFilter(int id);
    }
}
