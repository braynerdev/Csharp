using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using Teste.Entities;

namespace TesteVs
{
    class Program
    {
        static void Main(string[] args) {
            User user1 = new User("João Brayner","jbrayner04@gmail.com","brayner04");
            Post postUser1 = new Post(DateTime.Now,"Semana de treinamento",user1,
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod " +
                "tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
                "laboris nisi ut aliquip ex ea commodo consequat.");

            Console.WriteLine(user1);
            Console.WriteLine();
            Console.WriteLine(postUser1);
        }
    }
}