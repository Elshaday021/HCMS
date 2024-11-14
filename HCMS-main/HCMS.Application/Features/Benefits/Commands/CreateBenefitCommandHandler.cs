using HCMS.Services.DataService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCMS.Domain.Benefits;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HCMS.Domain;

namespace HCMS.Application.Features.Benefits.Commands
{
    public class CreateBenefitCommandHandler : IRequestHandler<CreateBenefitCommad, int>
    {
        private readonly IDataService dataService;
        private readonly IMapper   mapper;
        public CreateBenefitCommandHandler(IMapper mapper, IDataService dataService)
        {
            this.mapper = mapper;
            this.dataService = dataService;
        }
        public async  Task<int> Handle(CreateBenefitCommad request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Benefit request cannot be null.");
            }

            // Manual mapping of request properties to the Benefit entity
            var benefit = new Benefit
            {  
               
                Name = request.Name,
                Description = request.Description,
                BenefitType = request.BenefitType,
                // Initialize other properties if necessary
            };

            try
            {
                // Add the benefit to the data service
                dataService.Benefits.Add(benefit);

                // Save changes asynchronously
                await dataService.SaveAsync(cancellationToken);

                // Return the created benefit ID
                return benefit.ID;
            }
            catch (Exception ex)
            {
                // Handle exceptions (logging, etc.)
                throw new ApplicationException("An error occurred while creating the benefit.", ex);
            }

            //dataService.Benefits.Add(benefit);

            //dataService.Save();
            //return Task.FromResult(benefit.ID);


        }
    }
}
