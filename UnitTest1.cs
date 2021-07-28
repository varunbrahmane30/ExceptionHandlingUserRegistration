using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day21_ExceptionHandlingUserRegistration;

namespace ExceptionHandling
{
    public class UnitTest1
    {
        readonly Pattern pattern = new Pattern();

        [TestMethod]
        public void ShouldReturnCustomUserExceptionForFirstName()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validateFirstName(null));
            }
            catch (RegisterUser e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);
            }
        }
    }
}
