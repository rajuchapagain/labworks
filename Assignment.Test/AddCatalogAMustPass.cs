using Assignment.Service;
using NUnit.Framework;

namespace Assignment.Test
{
    /// <summary>
    /// BAU mode
    /// A new product added in Catalog A
    /// </summary>
    public class AddCatalogAMustPass
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddCatalogMustPass_ReturnIfFail()
        {
            string catalogLine = "999-vyk-317,Walkers Special Old Whiskey test";
            var result = FileService.AddCatalogItem(catalogLine);
            Assert.IsTrue(result, $"Record insert successful");
        }
    }
}
