using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace Press.Extensions {
    public static class PressServiceCollectionExtensions {

        public static void AddBlog(this IServiceCollection services) {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddEmbededViews();
        }

        private static void AddEmbededViews(this IServiceCollection services) {
            //http://stackoverflow.com/questions/31561135/how-to-include-controllers-and-views-from-an-external-project-into-mvc6
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/file-providers

            //services.AddSingleton<IFileProvider>(new EmbeddedFileProvider(typeof(PressServiceCollectionExtensions).GetTypeInfo().Assembly));
            //    new CompositeFileProvider(
            //        new EmbeddedFileProvider(typeof(PressServiceCollectionExtensions).GetTypeInfo().Assembly),
            //        f
            //    )
            //);


            //var f = (IFileProvider)services.LastOrDefault(d => d.ServiceType == typeof(IFileProvider))?.ImplementationInstance;
            //services.AddSingleton<IFileProvider>(
            //    new CompositeFileProvider(
            //        new EmbeddedFileProvider(typeof(PressServiceCollectionExtensions).GetTypeInfo().Assembly),
            //        f
            //    )
            //);
        }
    }
}
