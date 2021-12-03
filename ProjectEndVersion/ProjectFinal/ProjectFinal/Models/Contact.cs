using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string Name { get; set; }
        [StringLength(maximumLength: 300)]
        [Required]
        [EmailAddress(ErrorMessage = "Salam olsun Yaxsilara")]
        public string Email { get; set; }
        [StringLength(maximumLength: 2000)]
        [Required]
        public string Subject { get; set; }
        [StringLength(maximumLength: 2000)]
        [Required]
        public string Message { get; set; }
    }
}
