using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 300)]
        public string Name { get; set; }
        public int Percent { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
