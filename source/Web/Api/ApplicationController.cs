using DotNetCore.AspNetCore;
using DotNetCoreArchitecture.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreArchitecture.Web
{
    [ApiController]
    [RouteController]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public ApplicationModel Get()
        {
            return new ApplicationModel();
        }
    }
}
