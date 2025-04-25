using EchoMind.Api.Filters;
using EchoMind.Application.UseCases.Feedback.Register;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddScoped<RegisterFeedbackUseCase>();

builder.Services.AddValidatorsFromAssemblyContaining<RegisterFeedbackValidator>();

builder.Services.AddMvc(options => options.Filters.Add(typeof(ExceptionFilter)));


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
