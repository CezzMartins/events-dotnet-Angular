namespace ProEventos.Domain
{
    public class Palestrante
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public string CellPhone { get; set; } = default!;
        public string Email { get; set; } = default!;
        public IEnumerable<RedeSocial> RedeSociais { get; set; } = default!;
        public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; } = default!;


    }
}