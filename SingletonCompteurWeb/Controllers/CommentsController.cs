using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SingletonCompteurWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController
    {
        private UsersComments usersComments = UsersComments.getSingleton();


        [HttpGet]
        public IEnumerable<string> Get([FromQuery] string saisieUser)
        {
            usersComments.AddComment(saisieUser);
            return usersComments.Comments;
        }


        

    }
}
