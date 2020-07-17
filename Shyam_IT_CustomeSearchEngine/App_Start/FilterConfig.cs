using System.Web;
using System.Web.Mvc;

namespace Shyam_IT_CustomeSearchEngine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
