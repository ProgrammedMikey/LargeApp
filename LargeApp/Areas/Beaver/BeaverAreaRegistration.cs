using System.Web.Mvc;

namespace LargeApp.Areas.Beaver
{
    public class BeaverAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Beaver";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Beaver_default",
                "Beaver/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
                
            );
        }
    }
}