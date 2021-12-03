using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectFinal.Models;

namespace ProjectFinal.ViewModels
{
    public class BlogVM
    {
        public List<BlogMore> BlogMore { get; set; }
        public List<BlogReadMore> BlogReadMores { get; set; }

    }
}
