using EchoMind.Communication.Requests;

namespace EchoMind.Communication.Responses
{
    public class ResponseRegisterFeedbackJson
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }

}
