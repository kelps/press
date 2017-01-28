using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

//http://andrewlock.net/creating-a-custom-iconfigurationprovider-in-asp-net-core-to-parse-yaml/
//http://andrewlock.net/how-to-use-the-ioptions-pattern-for-configuration-in-asp-net-core-rc2/
//look at RazorViewEngineOptionsSetup
//services.TryAddEnumerable(ServiceDescriptor.Transient<IConfigureOptions<RazorViewEngineOptions>, RazorViewEngineOptionsSetup>());
//http://asp.net-hacker.rocks/2016/02/17/dependency-injection-in-aspnetcore.html
namespace Press.Configuration {
    public class PressConfigurationSource : FileConfigurationSource {
        public override IConfigurationProvider Build(IConfigurationBuilder builder) {
            FileProvider = FileProvider ?? builder.GetFileProvider();
            return new PressConfigurationProvider(this);
        }
    }
}
