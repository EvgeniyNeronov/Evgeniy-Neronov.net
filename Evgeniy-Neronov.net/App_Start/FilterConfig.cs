using System.Web;
using System.Web.Mvc;

namespace Evgeniy_Neronov.net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
