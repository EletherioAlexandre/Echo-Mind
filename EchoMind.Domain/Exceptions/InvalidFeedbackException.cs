namespace EchoMind.Domain.Exceptions
{
    public class InvalidFeedbackException : System.Exception
    {
        public List<ErrorDomainField> Errors { get; set; }
        public InvalidFeedbackException(List<ErrorDomainField> errors) : base("There were validation errors on the Feedback entity.")
        {
            Errors = errors;
        }   
    }
}
