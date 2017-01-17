using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Press.Services {
    public interface IBlogRepository {
        IEnumerable<IPost> List();
        void Save(IPost post);
        void Delete(IPost post);

        //void Delete(Post post);

        //IEnumerable<Post> GetAll(string blogId);

        //Dictionary<string, int> GetCategories(string blogId);

        //Dictionary<string, int> GetTags(string blogId);

        //void Save(Post post);

        //string SaveMedia(string blogid, MediaObject media);

    }
}
