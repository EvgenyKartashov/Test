using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using GridWebApp.Models;
using GridWebApp.Repository;
using GridWebApp.Data;

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

            result.ForEach(fd =>
            {
                fd.Subjects.ForEach(st =>
                {
                    st.Routes.ForEach(rt => rt.CalcSum());

                    st.MenKid = st.Routes.CountByField(q => q.MenKid);
                    st.MenAdult = st.Routes.CountByField(q => q.MenAdult);
                    st.MenSenior = st.Routes.CountByField(q => q.MenSenior);
                    st.WomenKid = st.Routes.CountByField(q => q.WomenKid);
                    st.WomenAdult = st.Routes.CountByField(q => q.WomenAdult);
                    st.WomenSenior = st.Routes.CountByField(q => q.WomenSenior);

                    st.CalcSum();
                });

                fd.MenKid = fd.Subjects.CountByField(q => q.MenKid);
                fd.MenAdult = fd.Subjects.CountByField(q => q.MenAdult);
                fd.MenSenior = fd.Subjects.CountByField(q => q.MenSenior);
                fd.WomenKid = fd.Subjects.CountByField(q => q.WomenKid);
                fd.WomenAdult = fd.Subjects.CountByField(q => q.WomenAdult);
                fd.WomenSenior = fd.Subjects.CountByField(q => q.WomenSenior);

                fd.CalcSum();
            });

            return result;
        }
    }
}