using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Press.Services {
    public abstract class FileBlogRepository : IBlogRepository {
        IFileProvider fileProvider;

        public FileBlogRepository(IFileProvider fileProvider) {
            this.fileProvider = fileProvider;
        }

        public IEnumerable<IPost> List() {
            var files = fileProvider.GetDirectoryContents("posts").Where(f => !f.IsDirectory);
            var result = new List<IPost>();

            foreach (var file in files) {
                if (TryParsePost(file, out IPost p)) {
                    result.Add(p);
                }
            }

            return result.OrderByDescending(p => p.PublishDate);
        }

        protected abstract bool TryParsePost(IFileInfo file, out IPost post);

        protected class Post : IPost {
            public string Author { get; set; }

            public IEnumerable<string> Categories { get; set; }

            public string Content { get; set; }

            public string Excerpt { get; set; }

            public string Id { get; set; }

            public bool IsPublished { get; set; }

            public DateTimeOffset LastModified { get; set; }

            public DateTimeOffset PublishDate { get; set; }

            public string Slug { get; set; }

            public IEnumerable<string> Tags { get; set; }

            public string Title { get; set; }
        }
    }
}
