using System.Web.Mvc;

namespace LargeApp.Areas.ReactJS
{
    public class ReactJSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ReactJS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
           

            context.MapRoute(
                "ReactJS_default",
                "ReactJS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}