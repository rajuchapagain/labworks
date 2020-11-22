namespace Assignment.Models
{
    public class Catalog
    {
        public string SKU { get; set; }
        public string Description { get; set; }

        public static Catalog FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Catalog catalog = new Catalog();
            catalog.SKU = values[0];
            catalog.Description = values[1];
            return catalog;
        }
    }
}
