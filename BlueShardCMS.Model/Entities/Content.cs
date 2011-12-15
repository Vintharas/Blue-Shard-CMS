namespace BlueShardCMS.Model.Entities
{
    /// <summary>
    /// Represents any piece of content 
    /// </summary>
    public abstract class Content
    {
        public int ContentId { get; set; }

        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

    }
}