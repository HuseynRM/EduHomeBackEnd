using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class AboutEduHome
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Title { get; set; }
        [StringLength(maximumLength: 3000)]
        public string Text { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public bool IsHome { get; set; }
    }
}
