using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCRD_ServicioChatbot.Models
{
    public class Comunicado
    {
        public string Status { get; set; }
        public object Body { get; set; }
        public List<ContentComunicado> Content { get; set; }

    }

    public class ContentComunicado
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}