using System.Web;
using System.Web.Mvc;

namespace Eq2BrokerCalc2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
