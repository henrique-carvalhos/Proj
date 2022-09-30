using Extranet.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Extranet.API.Controllers
{
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var skills = _skillService.GetAll();

            return Ok(skills);
        }
    }
}
