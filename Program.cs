using System.Reflection;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

builder.Services
	.AddGraphQLServer()
	.AddTypes()
	.AddFairyBread();

var app = builder.Build();
app.MapGraphQL();
app.Run();
