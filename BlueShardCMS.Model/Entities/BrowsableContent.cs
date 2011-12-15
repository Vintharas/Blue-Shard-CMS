namespace BlueShardCMS.Model.Entities
{
    public abstract class BrowsableContent : Content
    {
        public string Head { get; set; }
        public string Title { get; set; }
        public string Permalink { get; set; }
    }
}