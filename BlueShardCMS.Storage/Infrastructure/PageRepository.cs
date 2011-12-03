using System.Collections.Generic;
using BlueShardCMS.Model.Entities;
using BlueShardCMS.Storage.Interfaces;

namespace BlueShardCMS.Storage.Infrastructure
{
    public class PageRepository : IPageRepository
    {
        public Page GetHomePage()
        {
            return new Page {
                Body = "<h1>HomePage</h1><p>Awesome</p>",
                Title = "Home Page!",
                IsHomePage = true,
                IsNavigationPage = true,
                Permalink = "home-page"
            };
        }

        public IEnumerable<Page> GetNavigationPages()
        {
            return new List<Page>
                       {
                           new Page
                               {
                                   Title = "Home Page!",
                                   Body = "<h1>Home Page</h1><p>Awesome!</p>",
                                   Permalink = "home-page",
                                   IsHomePage = true,
                                   IsNavigationPage = true
                               },
                           new Page
                               {
                                   Title = "About",
                                   Body = "<h1>About</h1>",
                                   Permalink = "about",
                                   IsNavigationPage = true
                               }
                       };
        }

        public Page GetPageByTitle(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}