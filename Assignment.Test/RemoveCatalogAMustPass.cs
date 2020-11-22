using Assignment.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Test
{
    /// <summary>
    /// BAU Mode
    /// An existing product removed from Catalog A
    /// </summary>
    public class RemoveCatalogAMustPass
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddCatalogMustPass_ReturnIfFail()
        {
            string catalogLine = "999-vyk-317";
            var result = FileService.RemoveCatalogItem(catalogLine);
            Assert.IsTrue(result, $"Record removed successfully");
        }
    }
}
