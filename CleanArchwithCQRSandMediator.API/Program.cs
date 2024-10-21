using CleanArchwithCQRSandMediator.Application;
using CleanArchwithCQRSandMediator.Infra;

var builder = WebApplication.CreateBuilder(args);

//Add layer Dependency
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureService(builder.Configuration);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
