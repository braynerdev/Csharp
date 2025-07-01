using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities {
    internal class Comment {

        public User User { get; set; }
        public string Text { get; set; }

        public Comment() { }

        public Comment(User user, string text) {
            User = user;
            Text = text;
        }
    }
}
