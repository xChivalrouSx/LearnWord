using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LearnWord.Models
{
    public class WordModels
    {
        [Key]
        public int id { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public string Word { get; set; }

        public List<string> Sentences { get; set; }

        [Required]
        public int SentencesNumber { get; set; }
        // Default value 0

        public List<string> Synonyms { get; set; }

        [Required]
        public int SynonymsNumber { get; set; }
        // Default value 0

        public string Category { get; set; }

        public string Meaning { get; set; }
    }
}