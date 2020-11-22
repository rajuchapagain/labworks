using NUnit.Framework;

namespace Assignment.Test
{
    [TestFixture]
    public class CatatalogNotEmpty
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IfCatalogIsEmpty_ReturnFalse()
        {
            new DirectoryShouldExist().IsInputDataFolderExist_ReturnFalse(); 
            

            string msg = "";
            bool isEmpty = false;
            var catalogData = CatalogService.GetCatalogData();
            if (catalogData.catalogA.Count.Equals(0))
            {
                msg = "Catalog A is empty";
                isEmpty = true;
            }

            if (catalogData.catalogB.Count.Equals(0))
            {
                msg = "Catalog B is empty";
                isEmpty = true;
            }

            Assert.IsFalse(isEmpty, msg);
        }
    }
}