namespace webapi.Services.PostService
{
    public interface IPostService
    {
        List<Post> getPosts();
        Post getPostById(int id);
    }
}