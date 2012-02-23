using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using ConferenceTracker.Web.Contracts;

namespace ConferenceTracker.Web.Controllers
{
    public class InfosController : ApiController
    {
        public IQueryable<InfoDto> Get()
        {
            var i1 = new InfoDto
            {
                id = 1,
                content = "The hackathon has been moved to room 202 because someone in 201 had broccoli for lunch.",
                created_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                updated_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)
            };
            var i2 = new InfoDto
            {
                id = 2,
                content = "'Building VB6 WebSites' has been canceled due to lack of feasibility and interest. It has been replaced with 'PHP90X - How to build apps and biceps'",
                created_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                updated_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)
            };

            var infos = new List<InfoDto> { i1, i2 }.AsQueryable();

            return infos;
        }
    }
}