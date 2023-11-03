using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCRD_ServicioChatbot.Models
{
    public class RolesAudiencia
    {
        public string Status { get; set; }
        public object Body { get; set; }
        public List<ContentRoles> Content { get; set; }

    }

    public class ContentRoles
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}