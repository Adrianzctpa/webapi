namespace webapi.Services.PostService
{
    public interface IPostService
    {
        Task<ServiceResponse<List<GetPostResponseDTO>>> getPosts();
        Task<ServiceResponse<GetPostResponseDTO>> getPostById(int id);
    }
}