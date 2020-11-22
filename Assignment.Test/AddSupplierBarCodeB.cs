using Assignment.Service;
using NUnit.Framework;

namespace Assignment.Test
{
    /// <summary>
    /// BAU Mode
    /// An existing product in Catalog B got new supplier with set of barcodes
    /// </summary>
    public class AddSupplierBarCodeB
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddSupplierBarCode_MustPass_ReturnIfFail()
        {
            string supplierBarCode = "00001,647-vyk-317,w2572813758673";
            var result = FileService.AddSupplierBarCodeB(supplierBarCode);
            Assert.IsTrue(result, $"Record insert successful");
        }
    }
}
