namespace ProEventos.Domain
{
    public class Speaker
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? CellPhone { get; set; }
        public string? Email { get; set; }
        public IEnumerable<SocialMedia>? SocialMedia { get; set; }
        public IEnumerable<SpeakerEvent>? SpeakerEvent { get; set; }


    }
}