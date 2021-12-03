using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class NoticeBoardItem
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        [StringLength(maximumLength: 2000)]
        public string Text { get; set; }
    }
}
