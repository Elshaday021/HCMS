using HCMS.Application.Features.Benefits.Commands;
using HCMS.Application.Features.Benefits.Queries;
using HCMS.Domain.Benefits;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
namespace HCMS.API.Controllers.BenefitController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitController : BaseController<BenefitController>
    {
        [HttpPost("Create", Name ="CreateBenefit")]
        public async  Task<ActionResult <int>> CreateBenefit([FromBody] CreateBenefitCommad benefit )
        {

            var benefitId = await mediator.Send(benefit);
            return Ok(benefitId);
        }
        [HttpGet("GetBenefit", Name ="GetAllBenefit")]
        public async Task<ActionResult<List<Benefit>>> GetAllBenefit()
        {
            var benefits = await mediator.Send(new GetAllBenefitQuery());
            return benefits;
        }
    }
}
