namespace EchoMind.Domain.Exceptions
{
    public class InvalidFeedbackException : System.Exception
    {
        public List<ErrorField> Errors { get; set; }
        public InvalidFeedbackException(List<ErrorField> errors) : base("There were validation errors on the Feedback entity.")
        {
            Errors = errors;
        }   
    }
}
