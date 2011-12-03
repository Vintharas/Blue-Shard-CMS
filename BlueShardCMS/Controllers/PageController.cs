using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueShardCMS.Model.Entities;
using BlueShardCMS.Models;
using BlueShardCMS.Storage.Infrastructure;
using BlueShardCMS.Storage.Interfaces;

namespace BlueShardCMS.Controllers
{
    public class PageController : Controller
    {
        private readonly IPageRepository pageRepository;

        public PageController(IPageRepository pageRepository)
        {
            this.pageRepository = pageRepository;
        }

        //
        // GET: /Page/
        public ActionResult Index()
        {
            Page homePage = pageRepository.GetHomePage();
            IEnumerable<Page> navigationPages = pageRepository.GetNavigationPages();
            return View(new PageViewModel
                {
                    PageDisplayed = homePage, 
                    NavigationPages = navigationPages
                });
        }



    }
}
