﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Press.Services {
    public interface IPost {
        string Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Slug { get; set; }
        string Excerpt { get; set; }
        string Content { get; set; }
        bool IsPublished { get; set; }
        DateTimeOffset PublishDate { get; set; }
        DateTimeOffset LastModified { get; set; }
        IEnumerable<string> Categories { get; set; }
        IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Saves this post in its' repository.
        /// </summary>
        /// <returns>Boolean indicating the success of the operation</returns>
        bool Save();

        /// <summary>
        /// Removes this post from its' repository.
        /// </summary>
        /// <returns>Boolean indicating the success of the operation</returns>
        bool Delete();
    }
}
