using System;
using System.Collections.Generic;

namespace BlueShardCMS.Model.Entities
{
    public class BlogPost : BrowsableContent
    {
        public int BlogPostId { get; set; }

        public User Author { get; set; }


        public DateTime CreationDate { get; set; }
        public DateTime PublishingDate { get; set; }

        public BlogPostType BlogPostType { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Tag> Tags { get; set; }

        public string Introduction { get; set; }
        public bool HasIntroduction { get { return Introduction != ""; } }
    }
}