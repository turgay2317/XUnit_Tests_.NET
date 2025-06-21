namespace TestProject1.MoqTests;

public interface IUserRepository
{
    public User GetById(Guid id);
}