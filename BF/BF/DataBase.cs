using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF
{

    class DataBase
    {
        public Dictionary<string,string> database = new Dictionary<string, string>();
        
        public void Define()
        {
            
        }
        
        public string Search(string texto)
        {
            
            foreach(string llave in database.Keys)
            {
                if(llave == texto)
                {
                    return database[llave];
                }
            }
            return null;
        }

    }
}
