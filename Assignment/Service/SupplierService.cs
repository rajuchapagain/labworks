using Assignment.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assignment.Service
{
    public class SupplierService
    {
        /// <summary>
        /// Initialize barcode data
        /// </summary>
        /// <returns>Tuple with barcodeA and barcodeB data</returns>
        public static (List<Supplier> supplierA, List<Supplier> supplierB, string msg) GetBarcodeData()
        {
            try
            {
                string msg = "";
                var supplierA = File.ReadAllLines($"input\\suppliersA.csv")
                                     .Skip(1) // To remove the header text 
                                     .Select(v => Supplier.FromCsv(v))
                                     .ToList();
                var supplierB = File.ReadAllLines($"input\\suppliersB.csv")
                                    .Skip(1) // To remove the header text 
                                    .Select(v => Supplier.FromCsv(v))
                                    .ToList();
                return (supplierA, supplierB, "success");
            }
            catch (System.Exception ex)
            {

                return (null, null, ex.Message);
            }


        }
    }
}
