namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; } 
        public string Local { get; set; } = "";
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; } = "";
        public int QtdPessoa { get; set; }
        public string ImageUrl { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";
        public IEnumerable<Lote>? Lotes { get; set; }
        public IEnumerable<RedeSocial>? RedeSociais { get; set; }
        public IEnumerable<PalestranteEvento>? PalestranteEvento { get; set; }
       

    }
}