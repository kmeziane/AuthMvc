using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthMvc.Models
{
    public class Student : IdentityUser
    {
        public int Year { get; set; }
        public ICollection<Courses> Courses { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
