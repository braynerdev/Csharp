using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using Teste.Entities;

namespace TesteVs
{
    class Program
    {
        static void Main(string[] args) {
            User user1 = new User("João Brayner","jbrayner04@gmail.com","brayner04");
            User user2 = new User("Larissa Monteiro", "larissa.monteiro@exemplo.com", "lmonteiro25");
            User user3 = new User("Carlos Henrique", "carlos.henrique@exemplo.com", "carlosh");
            User user4 = new User("Amanda Souza", "amanda.souza@exemplo.com", "amandinha_sz");
            User user5 = new User("Rafael Lima", "rafael.lima@exemplo.com", "rafalima88");


            Post postUser1 = new Post(DateTime.Now,"Semana de treinamento",user1,
                "Está no ar a nossa Semana de Treinamento! Serão dias intensos de aprendizado, " +
                "troca de experiências e crescimento profissional. Uma oportunidade única para " +
                "desenvolver novas habilidades, revisar conceitos importantes e se preparar para os " +
                "próximos desafios. Durante essa semana, teremos workshops práticos, palestras " +
                "com especialistas e dinâmicas que vão transformar o jeito que você enxerga sua rotina " +
                "de trabalho. É hora de sair da zona de conforto e mergulhar de cabeça no conhecimento!");



            Console.WriteLine(postUser1.ToString());
            Console.WriteLine();

            Comment comment2 = new Comment(user2, "Treinamentos como esse fazem toda a diferença no nosso crescimento profissional.");
            Comment comment3 = new Comment(user3, "Já comecei a aplicar o que aprendi no primeiro dia. Muito produtivo!");
            Comment comment4 = new Comment(user4, "Parabéns pela iniciativa! Conteúdos muito bem elaborados e aplicáveis.");
            Comment comment5 = new Comment(user5, "Adorei a dinâmica de hoje! Que venham os próximos dias!");

            postUser1.AddComment(comment2);
            postUser1.AddComment(comment3);
            postUser1.AddComment(comment4);
            postUser1.AddComment(comment5);

            Console.WriteLine(postUser1.ToString());
            Console.WriteLine();

            Likes likes1 = new Likes(user1);
            Likes likes2 = new Likes(user2);
            Likes likes3 = new Likes(user3);
            Likes likes4 = new Likes(user4);
            Likes likes5 = new Likes(user5);

            postUser1.AddLikes(likes1);
            postUser1.AddLikes(likes2);
            postUser1.AddLikes(likes3);
            postUser1.AddLikes(likes4);
            postUser1.AddLikes(likes5);

            Console.WriteLine(postUser1.ToString());
            Console.WriteLine();


            postUser1.RemoveLikes(likes5);

            Console.WriteLine(postUser1.ToString());
            Console.WriteLine();

        }
    }
}