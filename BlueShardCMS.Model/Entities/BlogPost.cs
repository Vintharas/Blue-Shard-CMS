using System;
using System.Collections.Generic;

namespace BlueShardCMS.Model.Entities
{
    public class BlogPost : Content
    {
        public int BlogPostId { get; set; }
        public string Author { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime PublishingDate { get; set; }

        public int CategoryId { get; set; }
        public IEnumerable<int> TagIds { get; set; }

        public string Introduction { get; set; }
        public bool HasIntroduction { get { return Introduction != ""; } }
    }
}