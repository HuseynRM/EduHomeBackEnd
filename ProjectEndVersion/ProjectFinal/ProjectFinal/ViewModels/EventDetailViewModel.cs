using ProjectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.ViewModels
{
    public class EventDetailViewModel
    {
        public List<Tag> Tags { get; set; }
        public Event Event { get; set; }
        public List<Category> Categories { get; set; }
    }
}
