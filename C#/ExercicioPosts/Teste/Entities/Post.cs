using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities {
    internal class Post {
        public DateTime Moment {
            get; private set;
        }
        public string Title {
            get; private set;
        }
        public User User {
            get; private set;
        }
        public string Description {
            get; private set;
        }
        public List<Comment> Comments {
            get; private set;
        } = new List<Comment>();
        public List<Likes> Likes {
            get; private set;
        } = new List<Likes>();

        public Post() {
        }

        public Post(DateTime moment, string title, User user,string description) {
            Moment = moment;
            Title = title;
            User = user;
            Description = description;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Title);
            sb.Append(' ');
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine();
            sb.AppendLine(User.UserName);
            sb.AppendLine();
            sb.AppendLine(Description);
            sb.AppendLine();
            sb.AppendLine($"likes- {Likes.Count}");
            sb.AppendLine();

            foreach (Comment c in Comments)
            {   
                sb.AppendLine(c.User.UserName);
                sb.AppendLine(c.Text);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public void AddLikes(Likes like) {
            Likes.Add(like);
        }

        public void RemoveLikes(Likes like) {
            Likes.Remove(like);
        }
    }
}
