﻿using System.ComponentModel.DataAnnotations;

namespace devempower_api.Core.Entities
{
    public class VideoEntity
    {
        [Key]
        public long Id { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}