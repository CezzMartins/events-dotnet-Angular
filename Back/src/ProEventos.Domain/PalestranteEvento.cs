namespace ProEventos.Domain
{
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; } = default!;
        public Palestrante Palestrante { get; set; } = default!;
        public int EventoId { get; set; } = default!;
        public Evento Evento { get; set; } = default!;
    }
}