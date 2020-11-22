using Assignment.Service;
using NUnit.Framework;

namespace Assignment.Test
{
    [TestFixture]
    public class DirectoryShouldExist
    {

        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void IsInputDataFolderExist_ReturnFalse()
        {
            var result = FileService.FolderCheck();

            Assert.IsTrue(result, "Data folder exist");
        }
    }
}
