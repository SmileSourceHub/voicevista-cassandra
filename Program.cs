using Cassandra.Mapping;
using voicevista_cassandra.Configuration.Cassandra.Mappers;
using voicevista_cassandra.DataAccess;
using voicevista_cassandra.DataAccess.Database.Interfaces;
using voicevista_cassandra.Services;
using voicevista_cassandra.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IServerService, ServerService>();
builder.Services.AddSingleton<IServerRepository, ServerRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
MappingConfiguration.Global.Define(ServerMapper.GetMap());
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
