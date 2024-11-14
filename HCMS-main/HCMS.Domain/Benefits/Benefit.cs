using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMS.Domain.Benefits
{
    public class Benefit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BenefitType { get; set; }
    }
}
