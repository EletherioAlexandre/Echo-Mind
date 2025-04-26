using EchoMind.Communication.Requests;
using EchoMind.Communication.Responses;
using FeedbackEntity = EchoMind.Domain.Entities.Feedback;
using EchoMind.Domain.Exceptions;
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

            FeedbackEntity feedback = new FeedbackEntity(request.Message, request.CreatedAt, request.IsAnonymous, request.Name);

            return new ResponseRegisterFeedbackJson
            {
                Id = feedback.Id,
                CreatedAt = feedback.CreatedAt,
                Message = feedback.Message
            };

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
