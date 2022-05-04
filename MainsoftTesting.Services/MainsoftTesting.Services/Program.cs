using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var _Config = builder.Configuration;


// Add services to the container.

var emailConfig = _Config.GetSection("MailSettings").Get<MailSettings>();
builder.Services.AddSingleton(emailConfig);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IMailService, MailService>();

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
