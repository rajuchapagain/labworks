using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Assignment.Service
{
    public class FileService
    {
        /// <summary>
        /// Function to write data to csv, using generic function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">List of items to write</param>
        public static void WriteCSV<T>(IEnumerable<T> items)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var filePath = "output\\";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (var writer = new StreamWriter($"output\\result_output.csv"))
            {
                writer.WriteLine(string.Join(",", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(",", props.Select(p => p.GetValue(item, null))));
                }
            }
        }

        public static bool AddSupplierBarCodeB(string supplierBarCode)
        {
            try
            {

                var barCodePath = "input\\barcodesB.csv";
                int currentLines = File.ReadLines(barCodePath).Count();
                File.AppendAllLines(barCodePath, new List<string> { supplierBarCode });
                int linesAfterAdd = File.ReadLines(barCodePath).Count();

                return (linesAfterAdd - currentLines == 1);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int GetOutputFileRows()
        {
            var path = "output\\result_output.csv";
            var result = File.ReadAllLines(path).Count();
            return result;
        }

        /// <summary>
        /// To check if input folder exists
        /// </summary>
        /// <returns></returns>
        public static bool FolderCheck()
        {
            var inputPath = "input\\";
            var exist = Directory.Exists(inputPath);
            return exist;

        }

        /// <summary>
        /// To check if all files exist
        /// </summary>
        /// <returns></returns>
        public static int FilesCount()
        {
            if (FolderCheck())
            {
                var inputPath = "input\\";
                return Directory.GetFiles(inputPath).Count();

            }
            return 0;
        }

        public static bool AddCatalogItem(string catalogLine)
        {
            try
            {

                var catalogAPath = "input\\catalogA.csv";
                int currentLines = File.ReadLines(catalogAPath).Count();
                File.AppendAllLines(catalogAPath, new List<string> { catalogLine });
                int linesAfterAdd = File.ReadLines(catalogAPath).Count();

                return (linesAfterAdd - currentLines == 1);
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool RemoveCatalogItem(string sku)
        {
            try
            {
                var catalogAPath = "input\\catalogA.csv";
                List<string> lines = File.ReadAllLines(catalogAPath).ToList();
                int currentLines = lines.Count;
                foreach (var line in lines)
                {
                    if (line.Contains(sku))
                    {
                        lines.Remove(line);
                        break;
                    }
                }
                File.Delete(catalogAPath);
                File.AppendAllLines(catalogAPath, lines);
                int linesAfterremove = File.ReadLines(catalogAPath).Count();
                return currentLines - linesAfterremove == 1;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
