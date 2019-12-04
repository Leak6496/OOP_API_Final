using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIComRoomCla
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RoomsUsed",
                routeTemplate: "api/Rooms/Used",
                defaults: new { controller = "Usedroom", action = "Get",  id = RouteParameter.Optional }
            );

            

            config.Routes.MapHttpRoute(
                name: "RoomsUnused",
                routeTemplate: "api/Rooms/Unused",
                defaults: new { controller = "Unusedroom", action = "Get", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "RoomWithCom",
                routeTemplate: "api/Rooms/Computers",
                defaults: new { controller = "Roomwithcom", action = "Get", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
