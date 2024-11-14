using HCMS.Domain.Benefits;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMS.Application.Features.Benefits.Queries
{
    public class GetAllBenefitQuery:IRequest<List<Benefit>>
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string BenefitType { get; set; }
    }
}
