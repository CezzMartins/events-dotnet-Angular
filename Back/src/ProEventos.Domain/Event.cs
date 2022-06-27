namespace ProEventos.Domain
{
    public class Event
    {
        public int Id { get; set; } 
        public string Local { get; set; } = "";
        public DateTime? DateEvent { get; set; }
        public string Theme { get; set; } = "";
        public int QtyPeople { get; set; }
        public string ImageUrl { get; set; } = "";
        public string CellPhone { get; set; } = "";
        public string Email { get; set; } = "";
        public IEnumerable<Lote>? Lote { get; set; }
        public IEnumerable<SocialMedia>? SocialMedia { get; set; }
        public IEnumerable<SpeakerEvent>? SpeakerEvent { get; set; }
       

    }
}