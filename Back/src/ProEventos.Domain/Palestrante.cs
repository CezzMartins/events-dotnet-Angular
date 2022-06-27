namespace ProEventos.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? CellPhone { get; set; }
        public string? Email { get; set; }
        public IEnumerable<RedeSocial>? RedeSocial { get; set; }
        public IEnumerable<PalestranteEvento>? PalestranteEventos { get; set; }


    }
}