using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MainsoftTesting.Services.Domain.CQRS.Request;
using MainsoftTesting.Services.Domain.CQRS.Response;
using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Application;
using AutoMapper;
using MainsoftTesting.Services.Infrastructure;


namespace MainsoftTesting.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;

        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        
        [HttpPost]
        [Route("SendMail")]
        public async Task<IActionResult> SendMail([FromBody] MailObject request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
