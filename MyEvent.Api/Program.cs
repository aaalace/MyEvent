using Microsoft.AspNetCore.Mvc.Infrastructure;
using MyEvent.Api.Errors;
using MyEvent.Application;
using MyEvent.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSwaggerGen();
    
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
    
    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, MyEventProblemDetailsFactory>();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    
    app.Run();
}