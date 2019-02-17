﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnWord.Models
{
    public class WordModels
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Word { get; set; }

        public string Sentences { get; set; }

        public string Synonyms { get; set; }

        public string Category { get; set; }

        public string Meaning { get; set; }
    }
}