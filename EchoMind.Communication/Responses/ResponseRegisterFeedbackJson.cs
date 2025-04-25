using EchoMind.Communication.Requests;

namespace EchoMind.Communication.Responses
{
    public class ResponseRegisterFeedbackJson
    {
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public ResponseRegisterFeedbackJson(RequestRegisterFeedbackJson request)
        {
            Id = Guid.NewGuid();
            Text = request.Text;
            CreatedAt = request.CreatedAt;
        }
    }

}
