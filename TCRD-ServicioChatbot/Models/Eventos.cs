using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCRD_ServicioChatbot.Models
{
    public class Evento
    {
        public string Status { get; set; }
        public object Body { get; set; }
        public List<ContentEvento> Content { get; set; }
    }

    public class ContentEvento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Pago { get; set; }
        public bool EventHasFinished { get; set; }
        public string Titulo1 { get; set; }
        public string Titulo2 { get; set; }
        public string Titulo3 { get; set; }
        public string Titulo4 { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinal { get; set; }
        public string HoraInicio { get; set; } 
        public string HoraFinal { get; set; }  
        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }

}