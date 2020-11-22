using Assignment.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment.Service
{
    public class BarcodeService
    {
        /// <summary>
        /// Initialize barcode data
        /// </summary>
        /// <returns>Tuple with barcodeA and barcodeB data</returns>
        public static (List<SupplierProductBarcode> barcodeA, List<SupplierProductBarcode> barcodeB, string msg) GetBarcodeData()
        {
            try
            {
                string msg = "";
                var barcodesA = File.ReadAllLines($"input\\barcodesA.csv")
                                     .Skip(1) // To remove the header text 
                                     .Select(v => SupplierProductBarcode.FromCsv(v))
                                     .ToList();
                var barcodesB = File.ReadAllLines($"input\\barcodesB.csv")
                                    .Skip(1) // To remove the header text 
                                    .Select(v => SupplierProductBarcode.FromCsv(v))
                                    .ToList();
                return (barcodesA, barcodesB, "success");
            }
            catch (System.Exception ex)
            {

                return (null, null, ex.Message);
            }


        }

    }
}
