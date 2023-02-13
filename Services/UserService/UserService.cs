namespace webapi.Services.UserService
{
    public class UserService : IUserService
    {
       private static List<User> users = new List<User> {
            new User(),
            new User {
                Id = 3,
                Name = "Jane Doe",
                Email = "janedoe@gmail.com"
            }
        };

        public User PostUser(User user) {
            User provUser = new User {
                Id = users.Count + 2,
                Name = user.Name,
                Email = user.Email
            };
            users.Add(provUser);
            return provUser;
        }
    }
}