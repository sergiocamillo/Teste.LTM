using System.Web.Mvc;
using X.Infra.CrossCutting.Logging.Helpers;
using X.Infra.CrossCutting.MvcFilters;
using SimpleInjector;

namespace X.UI.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, Container container)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(container.GetInstance<GlobalFilterTool>());
        }
    }
}
