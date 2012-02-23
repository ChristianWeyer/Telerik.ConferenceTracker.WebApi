using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using ConferenceTracker.Web.Contracts;

namespace ConferenceTracker.Web.Controllers
{
    public class SessionsController : ApiController
    {
        public IQueryable<SessionDto> Get()
        {
            var s1 = new SessionDto
                         {
                             created_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                             day = "Thursday",
                             description = "",
                             id = 18,
                             level = "Beginner",
                             speaker = "Paul Irish",
                             time = "2012-02-16T17:15:00Z",
                             title = "Progressive Advancement on the High Seas of Web",
                             updated_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                             formatted_time = "05:15 PM"
                         };

            var s2 = new SessionDto
                         {
                             created_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                             day = "Friday",
                             description = "",
                             id = 19,
                             level = "Intermediate",
                             speaker = "Menno Van Slooten",
                             time = "2012-02-17T10:00:00Z",
                             title = "Automated UI Testing With jQuery",
                             updated_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                             formatted_time = "10:00 AM"
                         };
            var s3 = new SessionDto
                         {
                             created_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                             day = "Friday",
                             description = "",
                             id = 21,
                             level = "Advanced",
                             speaker = "Steve Smith",
                             time = "2012-02-17T11:45:00Z",
                             title = "Design Interactions With jQuery",
                             updated_at = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture),
                             formatted_time = "11:45 AM"
                         };
            var sessions = new List<SessionDto> { s1, s2, s3 }.AsQueryable();

            return sessions;
        }
    }
}