using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Press.Extensions {
    public static class PressApplicationBuilderExtensions {
        public static IApplicationBuilder UseBlog(this IApplicationBuilder app) {
            if (app == null) throw new ArgumentNullException(nameof(app));

            var routes = new RouteBuilder(app) {
                DefaultHandler = app.ApplicationServices.GetRequiredService<MvcRouteHandler>()
            };

            routes.MapRoute(
                name: "blogPost",
                template: "post/{*slug}",
                defaults: new {
                    controller = "Blog",
                    action = "Article"
                })
            .MapRoute(
                name: "blogCategory",
                template: "category/{*category}",
                defaults: new {
                    controller = "Blog",
                    action = "ViewCategory"
                })
            .MapRoute(
                name: "blogTag",
                template: "tag/{*tag}",
                defaults: new {
                    controller = "Blog",
                    action = "ViewTag"
                });

            return app.UseRouter(routes.Build());
        }
    }
}
