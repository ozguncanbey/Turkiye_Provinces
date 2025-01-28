using TurkiyeProvinces.Business.Abstract;
using TurkiyeProvinces.Business.Concrete.Managers;
using TurkiyeProvinces.Core.DataAccess.NHibernate;
using TurkiyeProvinces.DataAccess.Abstract;
using TurkiyeProvinces.DataAccess.Concrete.NHibernate;
using TurkiyeProvinces.DataAccess.Concrete.NHibernate.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<ICityDal, NhCityDal>();
builder.Services.AddSingleton<NHibernateHelper, SqlServerHelper>();

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