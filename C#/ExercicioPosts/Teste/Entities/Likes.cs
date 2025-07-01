using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities {
    internal class Likes {
        public User User { get; set; }

        public Likes() {
        }

        public Likes(User user) {
            User = user;
        }

        public override string ToString() {
            return $"User: {User}";
        }
    }
}
