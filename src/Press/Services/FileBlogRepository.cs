using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Press.Services {
    public class FileBlogRepository : IBlogRepository {
        IFileProvider fileProvider;

        public FileBlogRepository(IFileProvider fileProvider) {
            this.fileProvider = fileProvider;
        }

        public IEnumerable<IPost> List() {
            var files = fileProvider.GetDirectoryContents("posts").Where(f => !f.IsDirectory);
            var result = new List<Post>();
            result.AddRange(
                files
                    .Select(f => new Post() { Title = f.Name, LastModified = f.LastModified, PublishDate = f.LastModified })
                    .OrderByDescending(p => p.PublishDate)
            );
            return result;
        }

        class Post : IPost {
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
