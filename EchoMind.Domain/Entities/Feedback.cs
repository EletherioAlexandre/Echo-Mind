using EchoMind.Domain.Exceptions;

namespace EchoMind.Domain.Entities
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAnonymous { get; set; }
        public string? Name { get; set; }

        public Feedback(string message, DateTime createdAt, bool isAnonymous, string? name)
        {
            Id = Guid.NewGuid();
            Message = message;
            CreatedAt = createdAt;
            IsAnonymous = isAnonymous;
            Name = name ?? string.Empty;

            Validate();
        }

        private void Validate()
        {
            List<ErrorDomainField> errors = new List<ErrorDomainField>();

            if (!IsAnonymous && string.IsNullOrWhiteSpace(Name))
            {
                errors.Add(new ErrorDomainField
                {
                    Field = "Name",
                    Message = "Name is required when the feedback is not anonymous."
                });
            }

            if (string.IsNullOrWhiteSpace(Message))
            {
                errors.Add(new ErrorDomainField
                {
                    Field = "Message",
                    Message = "Text is required to register feedback."
                });
            }

            if (!string.IsNullOrWhiteSpace(Message) && Message.Length < 5)
            {
                errors.Add(new ErrorDomainField
                {
                    Field = "Message",
                    Message = "Feedback text must have at least 5 characters."
                });
            }

            if (DateTime.Compare(CreatedAt, DateTime.UtcNow) > 0)
            {
                errors.Add(new ErrorDomainField
                {
                    Field = "CreatedAt",
                    Message = "Feedback cannot be in the future."
                });
            }

            if (errors.Count > 0)
            {
                throw new InvalidFeedbackException(errors);
            }


        }
    }
}
