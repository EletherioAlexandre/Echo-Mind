using EchoMind.Communication.Requests;
using FluentValidation;

namespace EchoMind.Application.UseCases.Feedback.Register
{
    public class RegisterFeedbackUseCase
    {

        private readonly IValidator<RequestRegisterFeedbackJson> _validator;

        public RegisterFeedbackUseCase(IValidator<RequestRegisterFeedbackJson> validator)
        {
            _validator = validator;
        }

        public void Execute(RequestRegisterFeedbackJson request)
        {
            Validate(request);
        }

        public void Validate(RequestRegisterFeedbackJson request)
        {

            var result = _validator.Validate(request);

            if (!result.IsValid)
            {
                List<string> errors = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ValidationException(string.Join(" | ", errors));
            }

        }
    }
}
