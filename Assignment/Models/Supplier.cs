namespace Assignment.Models
{
    public class Supplier
    {
        public string ID { get; set; }
        public string Name { get; set; }


        public static Supplier FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Supplier supplier = new Supplier();
            supplier.ID = values[0];
            supplier.Name = values[1];            
            return supplier;
        }
    }
}
