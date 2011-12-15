namespace BlueShardCMS.Model.Entities
{
    public class User
    {
        public string UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public byte[] Avatar { get; set; }

    }
}