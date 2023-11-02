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

        public async Task<ActionResult> Sentencias()
        {

            ViewBag.Sentencias = await entidades.GetFromApiAsync("Sentencias");
            return View();
        }

        public async Task<ActionResult> Comunicados()
        {

            ViewBag.Comunicados = await entidades.GetFromApiAsync("Comunicados");
            return View();
        }

        public async Task<ActionResult> Noticias()
        {
            ViewBag.Noticias = await entidades.GetFromApiAsync("Noticias");

            return View();
        }

        public async Task<ActionResult> Roles()
        {

            ViewBag.Roles = await entidades.GetFromApiAsync("AudienceRoles");

            return View();
        }
    }
}