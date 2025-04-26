namespace EchoMind.Communication.Requests
{
    public class RequestRegisterFeedbackJson
    {
        public string Name { get; set; } = string.Empty;
        public bool IsAnonymous { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
