using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TCRD_ServicioChatbot.Helpper;

namespace TCRD_ServicioChatbot.Controllers
{
    public class DataController : Controller
    {

        HelpperEntidades entidades = new HelpperEntidades();

        public async Task<ActionResult> Sentencias(int cantidad = 0)
        {
            cantidad = cantidad > 0 ? cantidad : await entidades.GetIntFromApiAsync("LabTc/GetCountSentencias");
            ViewBag.CantidadSentencias = cantidad;
            ViewBag.Sentencias = await entidades.GetFromApiAsync("LabTc/GetLabSentences?cantidad=" + cantidad);
            return View();
        }

        public async Task<ActionResult> Comunicados(int cantidad = 0)
        {
            cantidad = cantidad > 0 ? cantidad : await entidades.GetIntFromApiAsync("LabTc/GetCountComunicados");
            ViewBag.CantidadComunicados = cantidad;
            ViewBag.Comunicados = await entidades.GetFromApiAsync("LabTc/GetLatestComunicados?cantidad="+cantidad);
            return View();
        }

        public async Task<ActionResult> Noticias(int cantidad = 0)
        {
            cantidad = cantidad > 0 ? cantidad : await entidades.GetIntFromApiAsync("LabTc/GetCountNoticias");
            ViewBag.CantidadNoticias = cantidad;
            ViewBag.Noticias = await entidades.GetFromApiAsync("LabTc/GetLatestNoticias?cantidad=" + cantidad);
             return View();
        }

        public async Task<ActionResult> Roles(int cantidad = 0)
        {
            cantidad = cantidad > 0 ? cantidad : await entidades.GetIntFromApiAsync("LabTc/GetCountAudienceRoles");
            ViewBag.CantidadRoles = cantidad;
            ViewBag.Roles = await entidades.GetFromApiAsync("LabTc/GetLastAudienceRoles?cantidad=" + cantidad);
            return View();
        }

        public async Task<ActionResult> Eventos()
        {

            ViewBag.Eventos = await entidades.GetFromApiAsync("LabTc/Events");

            return View();
        }


    }
}