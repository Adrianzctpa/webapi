namespace webapi.DTOS.User
{
    public class GetUserResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "John Doe";
        public string Email { get; set; } = "johndoe@gmail.com";
    }
}