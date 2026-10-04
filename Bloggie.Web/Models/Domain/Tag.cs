namespace Bloggie.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string DisplayName { get; set; }

        public required ICollection<BlogPost> BlogPosts { get; set; }
    }
}
