using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [StringLength(maximumLength: 4000)]
        public string Context { get; set; }
        [StringLength(maximumLength: 3000)]
        public string About { get; set; }
        [StringLength(maximumLength: 3000)]
        public string HowToApply { get; set; }
        [StringLength(maximumLength: 3000)]
        public string Certification { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Feature> Features { get; set; }
        public List<CourseTags> CourseTags { get; set; }
        [NotMapped]
        public List<int> TagIds { get; set; }
        public List<CourseComment> CourseComments { get; set; }
        public List<Request> Requests { get; set; }
    }
}
