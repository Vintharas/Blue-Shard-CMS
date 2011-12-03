using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueShardCMS.Model.Entities;
using BlueShardCMS.Storage.Infrastructure;
using BlueShardCMS.Storage.Interfaces;

namespace BlueShardCMS.Controllers
{
    public class PageController : Controller
    {
        private readonly IPageRepository pageRepository;

        public PageController()
        {
            pageRepository = new PageRepository();    
        }

        //
        // GET: /Page/
        public ActionResult Index()
        {
            Page homePage = pageRepository.GetHomePage();
            return View(homePage);
        }



    }
}
