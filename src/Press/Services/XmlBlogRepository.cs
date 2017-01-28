using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.FileProviders;

namespace Press.Services {
    public class XmlBlogRepository : FileBlogRepository {

        public XmlBlogRepository(IFileProvider fileProvider) : base(fileProvider) { }

        public override IPost Create() {
            return new Post(this);
        }

        protected override bool TryParsePost(IFileInfo file, out IPost post) {
            post = new Post(this) {
                Author="Kelps Leite de Sousa",
                Title = file.Name,
                LastModified = file.LastModified,
                PublishDate = file.LastModified,
                Slug = file.Name,
                Excerpt= "<p>Est clita elitr lorem mazim ut esse nulla sit eirmod tempor aliquam nonummy dolores justo liber et aliquyam accumsan dolor no est duo sanctus sadipscing ut nulla nibh vero sit invidunt invidunt clita elitr eos takimata nam quod vel rebum lorem justo ipsum gubergren eros diam vero autem clita at</p>",
                Content = "<p>Est clita elitr lorem mazim ut esse nulla sit eirmod tempor aliquam nonummy dolores justo liber et aliquyam accumsan dolor no est duo sanctus sadipscing ut nulla nibh vero sit invidunt invidunt clita elitr eos takimata nam quod vel rebum lorem justo ipsum gubergren eros diam vero autem clita at</p><p>Est clita elitr lorem mazim ut esse nulla sit eirmod tempor aliquam nonummy dolores justo liber et aliquyam accumsan dolor no est duo sanctus sadipscing ut nulla nibh vero sit invidunt invidunt clita elitr eos takimata nam quod vel rebum lorem justo ipsum gubergren eros diam vero autem clita at</p><p>Est clita elitr lorem mazim ut esse nulla sit eirmod tempor aliquam nonummy dolores justo liber et aliquyam accumsan dolor no est duo sanctus sadipscing ut nulla nibh vero sit invidunt invidunt clita elitr eos takimata nam quod vel rebum lorem justo ipsum gubergren eros diam vero autem clita at</p><p>Est clita elitr lorem mazim ut esse nulla sit eirmod tempor aliquam nonummy dolores justo liber et aliquyam accumsan dolor no est duo sanctus sadipscing ut nulla nibh vero sit invidunt invidunt clita elitr eos takimata nam quod vel rebum lorem justo ipsum gubergren eros diam vero autem clita at</p><p>Est clita elitr lorem mazim ut esse nulla sit eirmod tempor aliquam nonummy dolores justo liber et aliquyam accumsan dolor no est duo sanctus sadipscing ut nulla nibh vero sit invidunt invidunt clita elitr eos takimata nam quod vel rebum lorem justo ipsum gubergren eros diam vero autem clita at</p>",
                Tags = new[] {"Events", "Build", "Build Tour"}
            };
            return true;
        }
    }
}
