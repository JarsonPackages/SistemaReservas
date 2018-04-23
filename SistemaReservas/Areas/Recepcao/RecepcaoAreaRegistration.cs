using System.Web.Mvc;

namespace SistemaReservas.Areas.Recepcao
{
    public class RecepcaoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Recepcao";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Recepcao_default",
                "Recepcao/{controller}/{action}/{id}",
                new { action = "Reservas", id = UrlParameter.Optional }
            );
        }
    }
}