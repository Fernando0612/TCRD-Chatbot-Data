using System.Web;
using System.Web.Mvc;

namespace TCRD_ServicioChatbot
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
