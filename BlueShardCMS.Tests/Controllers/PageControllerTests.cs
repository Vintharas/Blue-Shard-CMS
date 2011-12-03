using System.Web.Mvc;
using BlueShardCMS.Controllers;
using BlueShardCMS.Model.Entities;
using BlueShardCMS.Storage.Interfaces;
using Moq;
using NUnit.Framework;

namespace BlueShardCMS.Tests.Controllers
{
    [TestFixture]
    public class PageControllerTests
    {
        [Test]
        public void Index_WhenUserVisitsTheHomePage_ShouldGetHomePageFromRepository()
        {
            // Arrange
            var pageRepo = new Mock<IPageRepository>();
            var controller = new PageController(pageRepo.Object);
            // Act
            var result = controller.Index();
            // Assert
            pageRepo.Verify(x => x.GetHomePage());
        }

        [Test]
        public void Index_WhenUserVisitsTheHomePage_ShouldGetHomePage()
        {
            // Arrange
            var pageRepo = new Mock<IPageRepository>();
            var controller = new PageController(pageRepo.Object);
            pageRepo.Setup(x => x.GetHomePage()).Returns(new Page {Title = "Homepage"});
            // Act
            var result = controller.Index();
            // Assert
            var view = (ViewResult) result;
            var model = (Page) view.Model;
            Assert.AreEqual(expected: "Homepage", actual: model.Title);
        }



        


         
    }
}