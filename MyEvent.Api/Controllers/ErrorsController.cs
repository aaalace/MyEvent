﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MyEvent.Api.Controllers;

[ApiController]
public class ErrorsController : ControllerBase
{
    [Route("/error")]
    [ApiExplorerSettings(IgnoreApi = true)] 
    public IActionResult Error()
    {
        var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        
        return Problem(title: exception?.Message);
    }
}