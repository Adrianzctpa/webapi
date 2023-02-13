namespace webapi.Services.PostService
{
    public class PostService : IPostService
    {
        private static List<Post> posts = new List<Post> {
            new Post(),
            new Post {
                Id = 1,
                AuthorId = 1,
                Title = "Loremiun",
                content = "Ipsumlicious 2",
                viewableBy = Roles.admin
            },  
        };
        public List<Post> getPosts()
        {
            return posts;
        }

        public Post getPostById(int id)
        {
            var post = posts.FirstOrDefault(p => p.Id == id);

            if (post != null)
            {
                return post;
            }

            throw new Exception("Post not found");
        }
    }
}