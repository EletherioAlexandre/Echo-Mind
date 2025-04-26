
using EchoMind.Communication.Responses;

namespace EchoMind.Exception.ExceptionsBase
{
    public class ErrorsOnValidationException : EchoMindBaseException
    {
        public List<ErrorField> Errors { get; set; }

        public ErrorsOnValidationException(List<ErrorField> errors) : base("There were validation errors in the application layer.")
        {
            Errors = errors;
        }
    }
}
