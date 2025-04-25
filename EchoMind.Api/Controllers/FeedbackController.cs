using System.ComponentModel.DataAnnotations;
using EchoMind.Application.UseCases.Feedback.Register;
using EchoMind.Communication.Requests;
using EchoMind.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EchoMind.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {

        private readonly RegisterFeedbackUseCase _useCase;

        public FeedbackController(RegisterFeedbackUseCase useCase)
        {
            _useCase = useCase;
        }


        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterFeedbackJson request)
        {
            _useCase.Execute(request);

            return Created(string.Empty, request);
        }
    }
}
