using invencivelAPIoficial;
using invencivelAPIoficial.Services;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.UseUrls("http://0.0.0.0:5000");

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // escuta todas as interfaces na porta 5000
});

builder.WebHost.UseKestrel()
    .UseUrls("http://0.0.0.0:5000");

builder.Services.AddSingleton<IDbConnection>(sp =>
{
    var config = sp.GetRequiredService<IConfiguration>();
    var connectionString = config.GetConnectionString("DefaultConnection");

    return new MySqlConnection(connectionString);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddScoped<Imprevisto, ImprevistoService>();

builder.Services.AddScoped<TremInterface, TremService>();

builder.Services.AddScoped<UsuarioInterface, UsuarioService>();

var app = builder.Build();

app.UseCors("AllowAll");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
