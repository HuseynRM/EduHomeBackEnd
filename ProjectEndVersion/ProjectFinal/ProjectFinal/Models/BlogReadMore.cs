using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal.Models
{
    public class BlogReadMore
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Image { get; set; }
        public bool IsdeletHead { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string ByWho { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Date { get; set; }
        [Required]
        public int ComCount { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Desc { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Desc1 { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Desc2 { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Desc3 { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Reply { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string Rdesc { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string ThemaImage { get; set; }
        [Required]
        [StringLength(maximumLength: 600)]
        public string ThemaTitle { get; set; }
    }
}