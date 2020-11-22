using Assignment.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class CatalogService
    {
        /// <summary>
        /// Initialize the catalog data
        /// </summary>
        /// <returns>Tuple with catalogA and catalogB data</returns>
        public static (List<Catalog> catalogA, List<Catalog> catalogB) GetCatalogData()
        {
            var catalogA = File.ReadAllLines("input\\catalogA.csv")
                               .Skip(1) // To remove the header text 
                               .Select(v => Catalog.FromCsv(v))
                               .ToList();
            var catalogB = File.ReadAllLines("input\\catalogB.csv")
                                .Skip(1) // To remove the header text 
                                .Select(v => Catalog.FromCsv(v))
                                .ToList();

            return (catalogA, catalogB);

        }


        /// <summary>
        /// To load catalog data into result list
        /// </summary>
        /// <param name="catalog">Catalog name</param>
        /// <param name="barcodes">bar code list</param>
        /// <param name="source">Company</param>
        /// <param name="results">output result reference, to combine the catalog from both company</param>
        public static void LoadCatalogData(List<Catalog> catalog, List<SupplierProductBarcode> barcodes, string source, ref List<Result> results)
        {
            foreach (var item in catalog)
            {
                var bc = barcodes.FirstOrDefault(p => p.SKU.Trim() == item.SKU.Trim());
                if (bc != null)
                {
                    // Check if the barcode data already exist in result list
                    if (!results.Any(p => p.Barcode.Equals(bc.Barcode)))
                    {
                        Result obj = new Result
                        {
                            SKU = item.SKU,
                            Description = item.Description,
                            Barcode = bc.Barcode,
                            Source = source
                        };
                        results.Add(obj);  //Add only when the barcode doesn't exist
                    }
                }

            }
        }




    }
}
