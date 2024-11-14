using HCMS.Application.Features.Jobs.JobGrades;
using HCMS.Domain.Benefits;
using HCMS.Domain.Job;
using HCMS.Services.DataService;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMS.Application.Features.Benefits.Queries
{
    //public record GetBenefitQuery :IRequest<List<Benefit>>;
    public class GetAllBenefitQueryHandler:IRequestHandler<GetAllBenefitQuery, List<Benefit>>  
    {
        private readonly IDataService dataService;

        public GetAllBenefitQueryHandler(IDataService dataService)
        {
            this.dataService = dataService;
        }


        public async Task<List<Benefit>> Handle(GetAllBenefitQuery request, CancellationToken cancellationToken)
        {
            var benefits = await dataService.Benefits.ToListAsync();
            return benefits;
        }
    }
}
