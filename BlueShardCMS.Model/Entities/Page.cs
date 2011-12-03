namespace BlueShardCMS.Model.Entities
{
    public class Page : Content
    {
        public int PageId { get; set; }
        public bool IsHomePage { get; set; }
        public bool IsNavigationPage { get; set; }
        public int OrderInNavigation { get; set; }
    }
}