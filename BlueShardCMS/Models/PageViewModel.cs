using System.Collections.Generic;
using BlueShardCMS.Model.Entities;

namespace BlueShardCMS.Models
{
    public class PageViewModel
    {
        public Page PageDisplayed { get; set; }
        public IEnumerable<Page> NavigationPages { get; set; }
    }
}