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
                Content = "Ipsumlicious 2",
                viewableBy = Roles.admin
            },  
        };

        private readonly IMapper _mapper;
        public PostService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetPostResponseDTO>>> getPosts()
        {
            var serviceResp = new ServiceResponse<List<GetPostResponseDTO>> {
                Data = _mapper.Map<List<GetPostResponseDTO>>(posts)
            };
            return serviceResp;
        }

        public async Task<ServiceResponse<GetPostResponseDTO>> getPostById(int id)
        {
            var post = posts.FirstOrDefault(p => p.Id == id);
            var serviceResp = new ServiceResponse<GetPostResponseDTO> {
                Data = _mapper.Map<GetPostResponseDTO>(post)
            };
            return serviceResp;
        }

        public async Task<ServiceResponse<GetPostResponseDTO>> updatePost(UpdatePostResponseDTO updPost)
        {   
            var serviceResp = new ServiceResponse<GetPostResponseDTO>();
            try {
                var post = posts.FirstOrDefault(p => p.Id == updPost.Id);
                if (post is null) {
                    throw new Exception($"Post with id '{updPost.Id}' not found");
                }

                _mapper.Map(updPost, post);

                serviceResp.Data = _mapper.Map<GetPostResponseDTO>(post);
            } catch (Exception ex) {
                serviceResp.Success = false;
                serviceResp.Message = ex.Message;
            }
            
            return serviceResp;
        }

        public async Task<ServiceResponse<List<GetPostResponseDTO>>> deletePost(int id)
        {
            var serviceResp = new ServiceResponse<List<GetPostResponseDTO>>();
            try {
                var post = posts.First(p => p.Id == id);
                posts.Remove(post);

                serviceResp.Data = _mapper.Map<List<GetPostResponseDTO>>(posts);
            } catch (Exception ex) {
                serviceResp.Success = false;
                serviceResp.Message = ex.Message;
            }
            
            return serviceResp;
        }
    }
}