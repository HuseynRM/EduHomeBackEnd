using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Title { get; set; }
        [StringLength(maximumLength: 3000)]
        public string Context { get; set; }
        [StringLength(maximumLength: 1000)]
        public string BackgroundImage { get; set; }
        [StringLength(maximumLength: 1000)]
        public string OverImage { get; set; }

        [NotMapped]
        public IFormFile BackgroundFile { get; set; }
        [NotMapped]
        public IFormFile OverFile { get; set; }
    }
}
