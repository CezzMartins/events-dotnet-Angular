namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; } = default!;
        public string Local { get; set; } = "";
        public DateTime DataEvento { get; set; } = default!;
        public string Tema { get; set; } = "";
        public int QtdPessoa { get; set; } = default!;
        public string ImageUrl { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";
        public IEnumerable<Lote> Lotes { get; set; } = default!;
        public IEnumerable<RedeSocial> RedeSociais { get; set; } = default!;
        public IEnumerable<PalestranteEvento> PalestranteEvento { get; set; } = default!;
       

    }
}