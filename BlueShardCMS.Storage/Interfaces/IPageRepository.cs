using System.Collections.Generic;
using BlueShardCMS.Model.Entities;

namespace BlueShardCMS.Storage.Interfaces
{
    public interface IPageRepository
    {
        Page GetHomePage();
        IEnumerable<Page> GetNavigationPages();
        Page GetPageByTitle(string title);
    }
}