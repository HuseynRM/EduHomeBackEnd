using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal.Models
{
    public class BlogMore
    {

        public int Id { get; set; }
        [StringLength(maximumLength: 405)]
        public bool Isdeleted { get; set; }
        public string Image { get; set; }
        [StringLength(maximumLength: 405)]
        public string ByWho { get; set; }
        [StringLength(maximumLength: 405)]
        public string Date { get; set; }
        public int ComCount { get; set; }
        [StringLength(maximumLength: 405)]
        public string Name { get; set; }
        public BlogReadMore BlogReadMore { get; set; }
        public int? BlogReadMoreId { get; set; }

    }
}
