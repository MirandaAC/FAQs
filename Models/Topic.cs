﻿using FAQs.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FAQs.Models
{
    public class Topic
    {
        [Key]
        public string TopicId { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        public List<FAQ> FAQs { get; set; }
    }
}
