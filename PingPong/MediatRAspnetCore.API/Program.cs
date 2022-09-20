using MediatR;
using MediatR.AspnetCore.Application;
using MediatRAspnetCore.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterMediatRDependencies();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
