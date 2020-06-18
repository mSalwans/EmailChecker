using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailChecker.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmailChecker.Controllers
{
    [Route("api/v1/checker")]
    [ApiController]
    public class Checker : ControllerBase
    {
        IEmailChecker _emailChecker;
        ILogger _logger;

        public Checker(IEmailChecker emailChecker, ILogger logger)
        {
            _emailChecker = emailChecker;
            _logger = logger;
        }
     
        [HttpPost]
        public int Post([FromBody] IList<string> emailsList)
        {
            try
            {
                _logger.LogInformation("Request received");
                return _emailChecker.CheckEmails(emailsList);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, emailsList);
                return -1;
            }
        }

    }
}
