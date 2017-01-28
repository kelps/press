using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Press.Services {
    public interface IBlogRepository {
        /// <summary>
        /// Lists all posts in the repository.
        /// </summary>
        IEnumerable<IPost> List();

        /// <summary>
        /// Creates (instantiates) the appropriate <see cref="IPost"/> object for the current <see cref="IBlogRepository"/> implementation.
        /// </summary>
        IPost Create();

        //string SaveMedia(string blogid, MediaObject media);
    }
}
