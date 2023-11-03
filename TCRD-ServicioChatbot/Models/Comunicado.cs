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
        public int idComunicado { get; set; }
        public string NombreComunicado { get; set; }
        public string Expedientes { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string URL_Documento { get; set; }
        public string NombreComunicado_URL { get; set; }
        public DateTime FechaComunicado { get; set; }
        public DateTime Fecha_UltimaActualizacion { get; set; }

    }
}