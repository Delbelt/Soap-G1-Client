namespace soap_client.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly UsersPortClient _client;

        public UserService(UsersPortClient client)
        {
            _client = client;
        }

        public async Task<CargarUsuariosResponse1> CargarUsuariosAsync(byte[] fileContent)
        {
            // Convertir el contenido del archivo a Base64
            string fileContentBase64 = Convert.ToBase64String(fileContent);

            // Crear la solicitud usando el contenido en formato Base64
            var request = new CargarUsuariosRequest { fileContent = fileContentBase64 };

            var response = await _client.CargarUsuariosAsync(request);
            Console.WriteLine(response.CargarUsuariosResponse);
         

            var usuariosCargados = response.CargarUsuariosResponse.usuariosCargados;
            var errores = response.CargarUsuariosResponse.errores;
            Console.WriteLine(string.Join(", ", usuariosCargados));
            Console.WriteLine(string.Join(", ", errores)); 

            return response;
        }

    }
}
