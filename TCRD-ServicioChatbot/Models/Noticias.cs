using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCRD_ServicioChatbot.Models
{
    public class Noticias
    {
        public string Status { get; set; }
        public object Body { get; set; }
        public List<ContentNoticia> Content { get; set; }
    }

    public class ContentNoticia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlAddress { get; set; }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Introduction { get; set; }
    }

}