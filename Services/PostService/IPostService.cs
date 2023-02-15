namespace webapi.Services.PostService
{
    public interface IPostService
    {
        Task<ServiceResponse<List<GetPostResponseDTO>>> getPosts();
        Task<ServiceResponse<GetPostResponseDTO>> getPostById(int id);
        Task<ServiceResponse<GetPostResponseDTO>> updatePost(UpdatePostResponseDTO post);
        Task<ServiceResponse<List<GetPostResponseDTO>>> deletePost(int id);
    }
}