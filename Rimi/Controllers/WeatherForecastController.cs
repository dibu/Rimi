using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rimi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rimi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private readonly ITestClass1 testClass1;
        private readonly ITestClass2 testClass2;
        /* dependency kikore register kore , Startup.cs file e dekh */
        /* constructor er vetor interface guloke pass korbi, n number interface pass korte parbi */

        public WeatherForecastController(ITestClass1 class1, ITestClass2 class2/* , Interface .... nth */) {
            this.testClass1 = class1;
            this.testClass2 = class2;
            /* 
             this.testClass-nth = class-nth; 
            */
        }
        [HttpGet]
        public string Get() {
            return testClass1.test() + " -  " + testClass2.testfunction();
        }
    }
}
