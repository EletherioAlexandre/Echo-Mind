﻿using System.ComponentModel.DataAnnotations;
using EchoMind.Application.UseCases.Feedback.Register;
using EchoMind.Communication.Requests;
using EchoMind.Communication.Responses;
using EchoMind.Exception.ExceptionsBase;
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
        [ProducesResponseType(typeof(ResponseRegisterFeedbackJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status500InternalServerError)]
        public IActionResult Register([FromBody] RequestRegisterFeedbackJson request)
        {
            ResponseRegisterFeedbackJson response = _useCase.Execute(request);

            return Created(string.Empty, response);
        }
    }
}
