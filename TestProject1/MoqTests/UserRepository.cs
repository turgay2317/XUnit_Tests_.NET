namespace TestProject1.MoqTests;

public class UserRepository : IUserRepository
{

    private List<User> _users = new List<User>();
    
    public UserRepository(List<User> users)
    {
        this._users = users;
    }
    
    public User GetById(Guid id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }
}
