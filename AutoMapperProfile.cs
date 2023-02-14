namespace webapi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddPostDTO, Post>();
            CreateMap<Post, GetPostResponseDTO>();
            CreateMap<AddUserResponseDTO, User>();
            CreateMap<User, GetUserResponseDTO>();
        }
    }
}