﻿using System.Web.Mvc;
using System.Web.Routing;

namespace TrainTicketBookingSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Content/Images/*.jpg");

            routes.MapRoute(
                name: "Train",
                url: "trains/{action}/{id}",
                defaults: new { controller = "Train", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Ticket",
                url: "tickets/{action}/{id}",
                defaults: new { controller = "Ticket", action = "List", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
