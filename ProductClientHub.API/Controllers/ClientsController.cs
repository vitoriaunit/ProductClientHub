﻿using Microsoft.AspNetCore.Mvc;

namespace ProductClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Ok();
        }



    }
}