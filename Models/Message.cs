﻿namespace SharedCalendar.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string User { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
