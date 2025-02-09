namespace WebApplication1.Models
{
    public class Seminar
    {
        public int SeminarId { get; set; }

        public int? PersonalId { get; set; }

        public string? SeminarName { get; set; }

        public string? ConductedBy { get; set; }

        public DateOnly? DurationFrom  { get; set; }

        public DateOnly? DurationTo { get; set; }

        public virtual PersonalDetail? Personal { get; set; }
    }
}
