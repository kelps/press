using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Press.Extensions {
    public static class PressServiceCollectionExtensions {

        public static void AddBlog(this IServiceCollection services) {
            if (services == null) throw new ArgumentNullException(nameof(services));
        }
    }
}
