using System.Net;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using NetJarvisAPI.Models;
using NetJarvisAPI.Services;
using System.Threading.Tasks;

namespace NetJarvisAPI.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class RecognizerController : ControllerBase {

        private readonly IRecognizerService service;
        public RecognizerController(RecognizerService _service) {
            service = _service;
        }
        [HttpGet]
        public async Task<IActionResult> Humans() {

            var result = await service.GetHumans();
            return Ok(result);
        }
    }
}