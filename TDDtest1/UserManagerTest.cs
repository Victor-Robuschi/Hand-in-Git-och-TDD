using TDD;
using Xunit;

namespace TDDtest1
{
    public class UserManagerTest
    {
        [Fact]
        public void ShouldReturnTrue_ForCorrectParameters()
        {
            //Arrange
            string username = "Victor";
            string password = "123456";
            UserManager userManager = new UserManager(username, password);
            //Act
            bool result = userManager.ChangePassword(username, password, "654321");
            //Assert
            Assert.True(result);
        }
    }
}