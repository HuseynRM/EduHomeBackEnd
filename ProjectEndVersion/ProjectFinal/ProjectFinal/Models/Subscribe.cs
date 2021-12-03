using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 300)]
        [Required(ErrorMessage = "duzgun yaz")]
        [EmailAddress(ErrorMessage = "Salam olsun :)).")]
        public string Email { get; set; }
    }
}
