using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bfClassLib
{
    class Identifier
    {
        Dictionary<string, string> ObjTree = new Dictionary<string, string>();

        public Dictionary<string, string> Identify(string texto)
        {
            Dictionary<string, string> Identificadores = new Dictionary<string, string>();
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string[] pronombres = { "el", "ella", "ellos", "nosotros", "yo", "tu" };
            string[] tiempo = { "manana", "hoy", "ayer", "semana pasada" };
            string[] intrucciones =                                                     //Todas las intrucciones que le puedes dar a bf
                { "recuerda", "dime", "jugar", "reves", "dibujar", "chiste", "reir",
                "aburrido", "que puedes hacer" , "cosas puedes hacer", "dato",
                "memorama", "paint", "muestrame mis dibujos", "galeria", "calcula", "canta", "diversion", "cuenta"};

            foreach (string elemento in dias)
            {
                if (texto.Contains(elemento))
                {
                    Identificadores.Add("dia", elemento);
                }
            }

            foreach (int elemento in numeros)
            {
                if (texto.Contains(elemento.ToString()))
                {
                    Identificadores.Add("numeros", elemento.ToString());
                }
            }

            foreach (string elemento in pronombres)
            {
                if (texto.Contains(elemento))
                {
                    Identificadores.Add("pronombre", elemento);
                }
            }

            foreach (string elemento in tiempo)
            {
                if (texto.Contains(elemento))
                {
                    Identificadores.Add("tiempo", elemento);
                }
            }

            foreach (string elemento in intrucciones)
            {
                if (texto.Contains(elemento))
                {
                    Identificadores.Add("intruccion", elemento);
                }
            }


            return Identificadores;

        }

        public Dictionary<string, string> Capture(string texto)
        {
            string[] defObj = { "el, la, los, las " };
            string[] txtPart = texto.Split();
            int n = 0;

            foreach(string elemento in txtPart)
            {
                foreach(string elemento2 in defObj)
                {
                    if (elemento == elemento2)
                    {
                        ObjTree.Add("obj" + n, txtPart[n + 1]);
                    }
                }
                n++;
            }

            return ObjTree;
        }
    }
}
