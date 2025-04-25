using EchoMind.Communication.Requests;
using EchoMind.Communication.Responses;
using EchoMind.Exception.ExceptionsBase;
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

        public ResponseRegisterFeedbackJson Execute(RequestRegisterFeedbackJson request)
        {
            Validate(request);

            return new ResponseRegisterFeedbackJson(request);

        }

        public void Validate(RequestRegisterFeedbackJson request)
        {

            var result = _validator.Validate(request);

            if (!result.IsValid)
            {
                var errors = result.Errors.Select(e => new ErrorField
                {
                    Field = e.PropertyName,
                    Message = e.ErrorMessage
                }).ToList();

                throw new ErrorsOnValidationException(errors);
            }

        }
    }
}
