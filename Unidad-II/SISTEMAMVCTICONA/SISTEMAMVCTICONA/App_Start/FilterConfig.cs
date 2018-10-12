using System.Web;
using System.Web.Mvc;

namespace SISTEMAMVCTICONA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
