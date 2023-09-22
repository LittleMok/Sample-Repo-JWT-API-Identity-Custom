﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestIdentity.Controllers
{
    [Route("api/test-role")]
    [ApiController]
    [Authorize(Roles = "Superuser")]
    public class AuthorizationByRoleExistant : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test role don't exists works");
        }
    }
}
