using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities {
    internal class User {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public User() {
        }

        public User(string name, string email, string userName) {
            Name = name;
            Email = email;
            UserName = userName;
        }

        public override string ToString() {
            return $"Name: {Name}, Email: {Email}, Username: {UserName}";
        }
    }
}
