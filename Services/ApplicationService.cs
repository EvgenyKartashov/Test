using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using GridWebApp.Models;
using GridWebApp.Repository;

namespace GridWebApp.Services
{
    public class ApplicationService
    {
        private ApplicationContext context;
        public ApplicationService(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<FederalDistrict> GetDistricts()
        {
            var result = context.FederalDistricts.ToList();

            context.Subjects.Load();
            context.Routes.Load();
            context.Cities.Load();

            return result;
        }
    }
}