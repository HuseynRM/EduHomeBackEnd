using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [StringLength(maximumLength: 300)]
        public string Position { get; set; }
        [StringLength(maximumLength: 500)]
        public string FullName { get; set; }
        [StringLength(maximumLength: 1000)]
        public string FacebookUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string PinterestUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string VimeUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string TwitterUrl { get; set; }
        [StringLength(maximumLength: 3000)]
        public string About { get; set; }
        [StringLength(maximumLength: 500)]
        public string Degree { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Experience { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Hobbies { get; set; }
        [StringLength(maximumLength: 500)]
        public string Faculty { get; set; }
        [StringLength(maximumLength: 300)]
        public string Email { get; set; }
        [StringLength(maximumLength: 200)]
        public string PhoneNumber { get; set; }
        [StringLength(maximumLength: 300)]
        public string SkypeName { get; set; }
        public List<EventTeachers> EventTeachers { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Course> Courses { get; set; }
    }
}
