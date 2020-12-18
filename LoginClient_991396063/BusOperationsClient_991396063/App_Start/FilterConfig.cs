using System.Web;
using System.Web.Mvc;

namespace BusOperationsClient_991396063
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
