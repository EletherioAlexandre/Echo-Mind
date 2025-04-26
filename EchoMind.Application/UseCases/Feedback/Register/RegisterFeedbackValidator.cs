using EchoMind.Communication.Requests;
using FluentValidation;

namespace EchoMind.Application.UseCases.Feedback.Register
{
    public class RegisterFeedbackValidator : AbstractValidator<RequestRegisterFeedbackJson>
    {
        public RegisterFeedbackValidator()
        {
            RuleFor(f => f.Message)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Text is required to register feedback.")
                .MinimumLength(5).WithMessage("Feedback text must have at least 5 characters.");

            RuleFor(f => f.CreatedAt).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Feedback cannot be in the future.");

            When(f => !f.IsAnonymous, () =>
            {
                RuleFor(n => n.Name).NotEmpty().WithMessage("Name is required when the feedback is not anonymous.");
            });

        }
    }
}
