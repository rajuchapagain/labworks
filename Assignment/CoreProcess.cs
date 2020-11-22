using Assignment.Models;
using Assignment.Service;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    public class CoreProcess
    {
        public static void Process()
        {
            List<Result> results = new List<Result>();
            List<Catalog> catalogA, catalogB;
            List<SupplierProductBarcode> barcodesA, barcodesB;
            //Returns the tupls of catalog, first item is CatalogA and second item is CatalogB
            var catalog = CatalogService.GetCatalogData();
            //Returns the tupls of barcodes, first item is BarcodeA and second item is BarcodeB
            var barcode = BarcodeService.GetBarcodeData();
            catalogA = catalog.catalogA;
            catalogB = catalog.catalogB;
            barcodesA = barcode.barcodeA;
            barcodesB = barcode.barcodeB;
            CatalogService.LoadCatalogData(catalogA, barcodesA, "A", ref results);  //Load catalog data into result from catalog A, avoid duplicate
            CatalogService.LoadCatalogData(catalogB, barcodesB, "B", ref results);  //Load catalog data into result from catalog B, avoid duplicate
            var output = results.Select(p => new { p.SKU, p.Description, p.Source }); //select required fields only from merged list
            FileService.WriteCSV(output); //Write the data into output file
        }
    }
}
