using EchoMind.Communication.Requests;
using FluentValidation;

namespace EchoMind.Application.UseCases.Feedback.Register
{
    public class RegisterFeedbackValidator : AbstractValidator<RequestRegisterFeedbackJson>
    {
        public RegisterFeedbackValidator()
        {
            RuleFor(f => f.Text)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Text is required to register feedback.")
                .MinimumLength(5).WithMessage("Feedback text must have at least 5 characters");

            RuleFor(f => f.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Feedback cannot be in the future.");

        }
    }
}
