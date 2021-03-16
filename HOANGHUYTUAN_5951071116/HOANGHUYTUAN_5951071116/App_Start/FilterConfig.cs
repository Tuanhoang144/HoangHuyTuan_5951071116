using System.Web;
using System.Web.Mvc;

namespace HOANGHUYTUAN_5951071116
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
