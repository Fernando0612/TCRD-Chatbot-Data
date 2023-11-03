using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCRD_ServicioChatbot.Models
{
    public class Sentencia
    {
        public string Status { get; set; }
        public object Body { get; set; } 
        public string Content { get; set; }

    } 

    public class ContentItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FileNumber { get; set; }
        public string RelativeTo { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Document { get; set; }
        public string URLPrefix { get; set; }
        public object Temas { get; set; }
        public object SubTemas { get; set; }
        public object TemasYSubtem { get; set; }
        public string Fundamentos { get; set; }
    }


}