using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Press.Configuration {
    public class PressConfigurationProvider : FileConfigurationProvider {

        public PressConfigurationProvider(PressConfigurationSource source) : base(source) { }

        public override void Load(Stream stream) {

        }
    }
}
