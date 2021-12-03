using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.ViewModels
{
    public class MemberRegisterModel
    {
        [StringLength(maximumLength: 300)]
        public string FullName { get; set; }

        [StringLength(maximumLength: 200)]
        public string UserName { get; set; }

        [StringLength(maximumLength: 500)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(maximumLength: 500)]
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmedPassword { get; set; }
    }
}
