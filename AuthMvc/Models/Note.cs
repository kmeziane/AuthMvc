using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthMvc.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int NoteObtenue { get; set; }
        public DateTime Periode { get; set; }
        public Student Etudiant { get; set; }
        public Courses Cours { get; set; }
    }
}
