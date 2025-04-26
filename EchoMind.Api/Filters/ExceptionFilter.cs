using EchoMind.Communication.Responses;
using EchoMind.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EchoMind.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is EchoMindBaseException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnknownError(context);
            }
        }

        public void HandleProjectException(ExceptionContext context)
        {
            if (context.Exception is ErrorsOnValidationException)
            {
                var ex = context.Exception as ErrorsOnValidationException;

                var errorResponse = new ResponseErrorJson(ex.Errors);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorResponse);
            }
        }

        public void ThrowUnknownError(ExceptionContext context)
        {
            var errorMessage = new ResponseErrorJson(new List<ErrorField>
            {
                new ErrorField
                {
                    Field = "Undefined",
                    Message = "Unknow error"
                }
            });

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorMessage);
        }
    }
}
