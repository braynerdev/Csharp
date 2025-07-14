using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConjuntoLogs.Entities
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }

        public User(string name, string email)
        {
            Name = name.ToUpper();
            Email = email.ToLower();
            DataNasc = DateTime.Now;
        }
    }
}
