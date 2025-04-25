
using EchoMind.Communication.Responses;

namespace EchoMind.Exception.ExceptionsBase
{
    public class ErrorsOnValidationException : EchoMindException
    {
        public List<ErrorField> Errors { get; set; }

        public ErrorsOnValidationException(List<ErrorField> errors)
        {
            Errors = errors;
        }
    }
}
