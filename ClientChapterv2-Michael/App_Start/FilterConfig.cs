using System.Web;
using System.Web.Mvc;

namespace ClientChapterv2_Michael
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
