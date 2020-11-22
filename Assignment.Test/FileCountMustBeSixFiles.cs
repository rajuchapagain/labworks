using Assignment.Service;
using NUnit.Framework;

namespace Assignment.Test
{
    public class FileCountMustBeSixFiles
    {


        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void IsFileCount_LessThanSix_ReturnFalse()
        {
            var result = FileService.FilesCount();
            Assert.IsTrue(result.Equals(6), $"Input files count must be exactly 6, but has {result}");
        }
    }
}
