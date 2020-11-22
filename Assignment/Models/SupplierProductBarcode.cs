using System.Collections.Generic;

namespace Assignment.Models
{
    public class SupplierProductBarcode
    {
        public string SupplierId { get; set; }
        public string SKU { get; set; }
        public string Barcode { get; set; }

        public List<string> barcodes { get; set; }

        public static SupplierProductBarcode FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            SupplierProductBarcode supplierProductBarcode = new SupplierProductBarcode();
            supplierProductBarcode.SupplierId = values[0];
            supplierProductBarcode.SKU = values[1];
            supplierProductBarcode.Barcode = values[2];
            return supplierProductBarcode;
        }
    }
}
