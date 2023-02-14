namespace webapi.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<GetUserResponseDTO>> PostUser(AddUserResponseDTO user);
    }
}