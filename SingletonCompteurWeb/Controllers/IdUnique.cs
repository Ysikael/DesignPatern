using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonCompteurWeb.Controllers
{
    public class IdUnique
    {
        private int current = 0;
        private static IdUnique sing = null;

        private IdUnique()
        {

        }

        public static IdUnique getSingleton()
        {
            if (sing == null)
            {
                sing = new IdUnique();
            }
            return sing;
        }

        public int getNewId()
        {
            current += 1;
            return current; ;
        }
    }
}
