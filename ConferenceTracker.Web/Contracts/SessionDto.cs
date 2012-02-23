using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferenceTracker.Web.Contracts
{
    public partial class SessionDto
    {
        public string created_at;
        public string day;
        public string description;
        public int id;
        public string level;
        public string speaker;
        public string time;
        public string title;
        public string updated_at;
        public string formatted_time;
    }
}