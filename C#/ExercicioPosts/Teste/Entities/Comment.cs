using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities {
    internal class Comment {

        public User User { get; private set; }
        public string Text { get; private set; }

        public Comment() { }

        public Comment(User user, string text) {
            User = user;
            Text = text;
        }

        public override string ToString()
        {
            return $"{User.UserName}\n{Text}";
        }
    }
}
