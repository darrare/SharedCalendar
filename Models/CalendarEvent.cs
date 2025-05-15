using System.ComponentModel.DataAnnotations.Schema;

namespace SharedCalendar.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string? Description { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime StartDateTime { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime EndDateTime { get; set; }
    }

}
