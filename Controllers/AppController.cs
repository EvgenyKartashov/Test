using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using GridWebApp.Services;
using GridWebApp.Models;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private ApplicationService dbService;
        public AppController(ApplicationService dbService)
        {
            this.dbService = dbService;
        }

        [HttpGet]
        public IEnumerable<FederalDistrict> Districts()
        {
            return dbService.GetDistricts();
        }
    }
}