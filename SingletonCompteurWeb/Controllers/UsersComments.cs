using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonCompteurWeb.Controllers
{
    // design pattern singleton
    public class UsersComments
    {
        private static UsersComments commentSingleton = null;
        private List<string> _usersComments = new List<string>();
        //private int count = 0;

        private UsersComments()
        {

        }
        public static UsersComments getSingleton()
        {
            if (commentSingleton == null)
            {
                commentSingleton = new UsersComments();
            }
            return commentSingleton;
        }


        // ci dessous le code utile pour la vue



        //public string[] getComment()
        //{

        //    return usersComments;
        //}
        // tralala

        //public void setNewComment(string newComment)
        //{
        //    usersComments[count] = newComment;
        //    count++;
        //}

        public void AddComment(string comment)
        {
            _usersComments.Add(comment);
        }
        public IEnumerable<string> Comments => _usersComments;
    }
}
