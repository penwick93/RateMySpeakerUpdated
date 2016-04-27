using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace RateMySpeaker.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the speaker.")]
        [Display(Name = "Speaker Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the name of the conference where you saw the speaker.")]
        [Display(Name = "Conference")]
        public string Conference { get; set; }

        [Required(ErrorMessage = "Please rate the speaker on a scale of 1 to 5")]
        [Range(1, 5)]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please review the speaker in less than 500 characters.")]
        [Display(Name = "Review")]
        [StringLength(500)]
        public string Review { get; set; }

        
    }

    public class SpeakerDBContext : DbContext
    {
        public DbSet<Speaker> Speakers { get; set; }
    }
}