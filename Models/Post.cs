namespace webapi.Models
{
    public class Post {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; } = "Lorem";
        public string content { get; set; } = "Ipsumlicious";
        public Roles viewableBy { get; set; } = Roles.genericUser;
    }
}