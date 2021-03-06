using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DevExpTempTest {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                name: "Default", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "bonLivraisonIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "bonLivraison", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
            

            routes.MapRoute(
                name: "RDCIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "RDC", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "TypeJournauxAssocieIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "TypeJournauxAssocie", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "CompteRacineIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "CompteRacine", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "CompteFeuilleIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "CompteFeuille", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "ColisArticlesIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "ColisArticles", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "ColiIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "Coli", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "ArboJournalIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "ArboJournal", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "ArboCompteRacineIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "ArboCompteRacine", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "TJAJoinCompteRacineIndex", // Route name
                url: "{controller}/{action}/{id}", // URL with parameters
                defaults: new { controller = "TJAJoinCompteRacine", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

          

        }
    }
}