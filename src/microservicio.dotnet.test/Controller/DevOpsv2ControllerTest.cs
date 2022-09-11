using microservicio.dotnet.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace microservicio.dotnet.test.Controller
{
    public class DevOpsv2ControllerTest
    {
        readonly ILogger<DevOpsv2Controller> _logger;
        public DevOpsv2ControllerTest(ILogger<DevOpsv2Controller> logger)
            => _logger = logger;

        [Fact]
        public async Task GetInformationFromApiEqualToTaskDevops2()
        {
            ////Arange
            var evalController = new DevOpsv2Controller(_logger);
            evalController.ControllerContext.HttpContext = new DefaultHttpContext();
            var expected = "Finaliza el curso DevOpsFoundation V2 - Mario Villanueva";


            //Action 
            IActionResult result = await evalController.Get();

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result); 
            Assert.True(okResult.Value!.ToString() == expected, "dont return empty");

        }

        [Fact]
        public async Task GetInformationDiffToEmpty()
        {
            ////Arange
            var evalController = new DevOpsv2Controller(_logger);
            evalController.ControllerContext.HttpContext = new DefaultHttpContext(); 


            //Action 
            IActionResult result = await evalController.Get();

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.True(okResult.Value!.ToString() != String.Empty);

        }
    }
}
