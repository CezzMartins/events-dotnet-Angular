namespace ProEventos.Domain
{
    public class SocialMedia
    {
        public int id { get; set; }
        public string name { get; set; } = "";
        public string Url { get; set; } = "";
        public int? EventId { get; set; }
        public Event? Event { get; set; }
        public int? SpeakerID { get; set; }
        public Speaker? Speaker { get; set; }
    }
}