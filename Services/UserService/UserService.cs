namespace webapi.Services.UserService
{
    public class UserService : IUserService
    {
       private static List<User> users = new List<User> {
            new User{Id = 1},
            new User {
                Id = 2,
                Name = "Jane Doe",
                Email = "janedoe@gmail.com"
            }
        };
        
        private readonly IMapper _mapper;
        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetUserResponseDTO>> PostUser(AddUserResponseDTO user) {
            User provUser = new User {
                Id = users.Max(u => u.Id) + 1,
                Name = user.Name,
                Email = user.Email
            };

            var serviceResp = new ServiceResponse<GetUserResponseDTO> {
                Data = _mapper.Map<GetUserResponseDTO>(provUser)
            };
            users.Add(provUser);
            return serviceResp;
        }
    }
}