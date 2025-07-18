using System;

namespace URLShortener.Models
{
    public class ShortenedUrl
    {
        public Guid Id { get; set; }
        public required string LongUrl { get; set; }
        public string ShortUrl { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }
        public int ClickCount { get; set; }
    }
}