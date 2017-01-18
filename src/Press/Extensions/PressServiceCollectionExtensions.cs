using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Press.Extensions {
    public static class PressServiceCollectionExtensions {

        public static void AddBlog(this IServiceCollection services) {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddEmbededViews();

            services.AddSingleton<Services.IBlogRepository, Services.FileBlogRepository>();
        }

        private static void AddEmbededViews(this IServiceCollection services) {
            //http://www.mikesdotnetting.com/article/301/loading-asp-net-core-mvc-views-from-a-database-or-other-location
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/file-providers

            services.Configure<RazorViewEngineOptions>(options =>
                options.FileProviders.Add(new EmbeddedFileProvider(typeof(PressServiceCollectionExtensions).GetTypeInfo().Assembly, "Press"))
            );
        }
    }
}
