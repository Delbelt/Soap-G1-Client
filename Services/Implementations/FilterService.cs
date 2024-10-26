namespace soap_client.Services.Implementations
{
    public class FilterService : IFilterService
    {
        private readonly FilterPortClient _client; // Cambia a tu clase generada

        public FilterService(FilterPortClient client)
        {
            _client = client;
        }

        public async Task<List<FilterSoap>> GetFiltersByUserId(int userId)
        {
            var request = new getFiltersRequest { userId = userId }; // Asegúrate de que este objeto sea correcto
            var response = await _client.getFiltersAsync(request);
            return response.getFiltersResponse1.ToList();
        }

        public async Task<FilterSoap> SaveFilter(SaveFilterType filter)
        {
            var request = new saveFilterRequest { filter = filter }; // Crear la solicitud con el filtro
            var responseWrapper = await _client.saveFilterAsync(request); // Llama al servicio y obtiene la respuesta envuelta

            // Retorna el filtro desde la respuesta
            return responseWrapper.saveFilterResponse.filter; // Acceder a la propiedad correcta
        }

        public async Task<FilterSoap> EditFilter(EditFilterType filter)
        {
            var request = new editFilterRequest { filter = filter }; // Crea la solicitud para editar el filtro
            var response = await _client.editFilterAsync(request); // Llama al método SOAP
            return response.editFilterResponse.filter;
        }

        public async Task<bool> DeleteFilter(int id)
        {
            var request = new deleteFilterRequest { id = id }; // Crea la solicitud para borrar el filtro
            var response = await _client.deleteFilterAsync(request); // Llama al método SOAP
            return response.deleteFilterResponse.success; // Retorna true si fue exitoso
        }
    }
}
