namespace BlueShardCMS.Model.Entities
{
    /// <summary>
    /// Represents any piece of content 
    /// </summary>
    public abstract class Content
    {
        public int ContentId { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string Permalink { get; set; }
    }
}