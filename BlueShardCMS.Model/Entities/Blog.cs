using System.Collections.Generic;

namespace BlueShardCMS.Model.Entities
{
    public class Blog : Page
    {
        public int BlogId { get; set; }

        public User Owner { get; set; }

        public IEnumerable<BlogPost> BlogPosts;
 
        public IEnumerable<Category> Categories;
        public IEnumerable<Tag> Tags;

        public bool IsMainBlog { get; set; }
    }
}