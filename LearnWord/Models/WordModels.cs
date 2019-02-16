using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public List<string> Synonyms { get; set; }

        public string Category { get; set; }

        public string Meaning { get; set; }
    }
}