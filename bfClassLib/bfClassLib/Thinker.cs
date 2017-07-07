using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfClassLib
{
    class Thinker
    {
        struct DataBase
        {

        }

        public string InternalThink(string texto, Dictionary<string, string> identificadores) //Proceso de comparación y resolución interno (En la base de datos del sistema)
        {
            DataBase x = new DataBase();


            return "hola";
        }

        public string ExternalThink(string texto) //Proceso de comparación y resolución externo (En la base de datos del txt)
        {
            
            return "hola";
        }
    }
}

/* 
    dia, martes
    clima para 
    
    Ejemplo Conversación:
        
    Bf: Hola, Luis! (Hola, {name_user}      (1)
    Yo: Hola brotherfriend                  (2)
    Bf: Dime cosas sobre ti                 (3)
    Yo: Tengo 13 años || No tengo 11 años   (4)
    || No quiero
    #Cómo diferenciar eso?

    (4.1) = 
     
     */