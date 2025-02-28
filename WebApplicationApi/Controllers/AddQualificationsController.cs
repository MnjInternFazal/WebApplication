using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddQualificationsController : ControllerBase
    {
        private readonly ApplicationContext context;

        public AddQualificationsController(ApplicationContext context)
        {
            this.context = context;
        }


    }
}
