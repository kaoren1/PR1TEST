using ConsoleTest1;

namespace PR1TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDigit_PasswordWithDigit_ReturnsTrue()
        {
            Assert.AreEqual(true, Program.IsDigit("Test123"));
        }

        [TestMethod]
        public void IsDigit_PasswordWithoutDigit_ReturnsFalse()
        {
            Assert.AreNotEqual(false, Program.IsDigit("TestABC"));
        }

        [TestMethod]
        public void IsLowercase_PasswordWithLowercase_ReturnsTrue()
        {
            Assert.AreEqual(true, Program.IsLowercase("Test123a"));
        }

        [TestMethod]
        public void IsLowercase_PasswordWithoutLowercase_ReturnsFalse()
        {
            Assert.AreNotEqual(false, Program.IsLowercase("TEST123"));
        }

        [TestMethod]
        public void IsUppercase_PasswordWithUppercase_ReturnsTrue()
        {
            Assert.AreEqual(true, Program.IsUppercase("Test123A"));
        }

        [TestMethod]
        public void IsUppercase_PasswordWithoutUppercase_ReturnsFalse()
        {
            Assert.AreNotEqual(false, Program.IsUppercase("test123a"));
        }

        [TestMethod]
        public void IsLengthValid_ValidLength_ReturnsTrue()
        {
            Assert.AreEqual(true, Program.IsLengthValid("Test12345"));
        }

        [TestMethod]
        public void IsLengthValid_InvalidLength_ReturnsFalse()
        {
            Assert.AreNotEqual(false, Program.IsLengthValid("Test123"));
        }

        [TestMethod]
        public void IsSpecialCharacter_PasswordWithSpecialCharacter_ReturnsTrue()
        {
            Assert.AreEqual(true, Program.IsSpecialCharacter("Test123!"));
        }

        [TestMethod]
        public void IsSpecialCharacter_PasswordWithoutSpecialCharacter_ReturnsFalse()
        {
            Assert.AreNotEqual(false, Program.IsSpecialCharacter("Test123"));
        }
    }
}
