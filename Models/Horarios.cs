namespace ListApi.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public string? Dia { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? Status { get; set; }
    }
}