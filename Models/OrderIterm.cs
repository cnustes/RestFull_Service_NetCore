namespace Models
{
    public class OrderIterm
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitePrice { get; set; }
        public int Quantity { get; set; }
    }
}
