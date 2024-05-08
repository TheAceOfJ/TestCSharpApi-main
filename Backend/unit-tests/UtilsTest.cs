using Xunit;

namespace WebApp.Tests
{
    public class UtilsTest
    {
        [Fact]
        public void PasswordIsStrong_WhenMeetsCriteria_ReturnsTrue()
        {
            // Arrange
            string strongPassword = "SecurePass123!";

            // Act
            bool isStrong = WebApp.Utils.IsStrongPassword(strongPassword);

            // Assert
            Assert.True(isStrong);
        }

        [Fact]
        public void PasswordIsWeak_WhenDoesNotMeetCriteria_ReturnsFalse()
        {
            // Arrange
            string weakPassword = "weak";

            // Act
            bool isStrong = WebApp.Utils.IsStrongPassword(weakPassword);

            // Assert
            Assert.False(isStrong);
        }
    }
}
