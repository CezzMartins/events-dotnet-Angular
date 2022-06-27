namespace ProEventos.Domain
{
    public class Lote
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int Quantity { get; set; }
        public int EventID { get; set; }
        public Event? Event { get; set; }
    }
}