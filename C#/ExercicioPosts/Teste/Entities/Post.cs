using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities {
    internal class Post {
        public DateTime Moment {
            get; set;
        }
        public string Title {
            get; set;
        }
        public User User {
            get; set;
        }
        public string Description {
            get; set;
        }
        public List<Comment> Comment{
            get; set;
        }
        public List<Likes> Likes {
            get; set;
        }

        public Post() {
        }

        public Post(DateTime moment, string title, User user,string description) {
            Moment = moment;
            Title = title;
            User = user;
            Description = description;
        }

        public override string ToString() {
            return $"Moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}\nTitle: {Title}\n{User}\nDescription: {Description}";
        }

        public void AddComment(Comment comment) {
            Comment.Add(comment);
        }
        public void RemoveComment(Comment comment) {
            Comment.Remove(comment);
        }

        public void AddLikes(Likes like) {
            Likes.Add(like);
        }

        public void RemoveLikes(Likes like) {
            Likes.Remove(like);
        }
    }
}
