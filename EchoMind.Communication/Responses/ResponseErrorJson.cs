namespace EchoMind.Communication.Responses
{
    public class ResponseErrorJson
    {
        public List<ErrorField>? Errors { get; set; }

        public ResponseErrorJson(List<ErrorField> errorMessages)
        {
            Errors = errorMessages;
        }

    }
}
