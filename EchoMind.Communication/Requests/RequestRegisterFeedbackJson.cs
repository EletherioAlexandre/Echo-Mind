namespace EchoMind.Communication.Requests
{
    public class RequestRegisterFeedbackJson
    {
        public string Name { get; set; } = string.Empty;
        public bool IsAnonymous { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
