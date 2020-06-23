namespace Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Supplierld { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }
    }
}
