using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 500)]
        public string Name { get; set; }
        [StringLength(maximumLength: 200)]
        public string Value { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
