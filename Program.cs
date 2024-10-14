using soap_client.Services;
using soap_client.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

var URL_FRONT = "http://localhost:3000";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CountryPortClient>(provider =>
{
    var endpointAddress = new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/countries");
    var binding = new System.ServiceModel.BasicHttpBinding();

    return new CountryPortClient(binding, endpointAddress);
});

builder.Services.AddScoped<ICountryService, CountryService>();

// configura los CORS para que funcione en el front
builder.Services.AddCors(options =>
{
    options.AddPolicy("CQRS",
        builder => builder
            .WithOrigins(URL_FRONT)
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
