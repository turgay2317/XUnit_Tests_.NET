using Moq;

namespace TestProject1.MoqTests;

public class UserTests
{
    private Mock<IUserRepository> _userRepository;

    public UserTests()
    {
        this._userRepository = new Mock<IUserRepository>();
    }
    
    [Fact]
    public void ByUserId_ReturnUserEntity_WhenCorrect()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var expectedUser = new User { Id = userId, FullName = "Turgay Ceylan" };

        // Bu repodan bu talep edildiğinde bunu döndür.
        _userRepository.Setup(repo => repo.GetById(userId)).Returns(expectedUser);

        // Action
        var result = _userRepository.Object.GetById(userId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedUser.Id, result.Id);
        Assert.Equal(expectedUser.FullName, result.FullName);
    }
}