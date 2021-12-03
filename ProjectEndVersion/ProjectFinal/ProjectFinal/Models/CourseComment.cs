using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class CourseComment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        [Required]
        [StringLength(maximumLength: 5000)]
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
