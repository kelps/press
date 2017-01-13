using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postal.Services
{
    public interface IPost
    {
        string Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Slug { get; set; }
        string Excerpt { get; set;}
        string Content { get; set; }
        bool IsPublished { get; set; }
        DateTime PublishDate { get; set; }
        DateTime LastModified { get; set; }
        IEnumerable<string> Categories { get; set; }
        IEnumerable<string> Tags { get; set; }
    }
}
