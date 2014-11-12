using System.Web.Mvc;

namespace LeagueOfLegendsTrivia.Areas.Main_Page
{
    public class Main_PageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Main_Page";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Main_Page_default",
                "Main_Page/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
