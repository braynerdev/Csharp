using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedido.Entities
{
    internal class Client
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDay { get; private set; }

        public Client() { }

        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"BirthDay: {BirthDay}");
            return sb.ToString();
        }
    }
}
