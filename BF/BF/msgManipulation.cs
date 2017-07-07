using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BF
{
    class msgManipulation
    {
        public string message { set ; get; }
        public string LettersEqualString { set; get; }

        /// <summary>
        /// Verifica si la cadena cumple con ciertos requerimientos
        /// </summary>
        /// <param name="retornar"> True si se quiere regresar un valor y False si no.</param>
        /// <returns></returns>
        public string Requirements(bool retornar) {

            string requisitos = ""; //Cadena para almacenar los requisitos cumplidos;

            //Lista de verificaciones de requisitos:
            if(message.Length > 1)                       //Verifica si la cadena contiene más de un caracter
            {
                requisitos += "1";
            }
            else
            {
                requisitos += "0";
            }
            //Fin 1

            if(int.TryParse(message, out int i) == false) //Verifica si la cadena solo contiene números
            {
                requisitos += "1";
            }
            else
            {
                requisitos += "0";
            }
            //Fin 2

            if (LettersEqual(message) == false)
            {
                requisitos += "1";
            }
            else
            {
                requisitos += "0";
            }
            //Fin 3

            
            



            //Se verifica si el usuario quiso la cadena de requisitos cumplidos:
            if (retornar == true)
            {
                return requisitos;
            }
            else
            {
                return null;
            }
            
           
        }

        public bool LettersEqual(string mensaje) //Determina si la cadena repite matormente un caracter
        {
            char memory = ' ';             //Variable en la que se almacena el valor antiguo del caracter utilizado
            int contador = 0;        //Contador para mostrar el siguiente caracter
            int letterCount = 0;         //Contador de letras iguales en una cadena 
            char[] letras = mensaje.ToCharArray();
            if (mensaje.Length > 1)
            {
                foreach (char letter in letras)
                {

                    if (contador != 0 && memory == letter)
                    {
                        letterCount++;
                        contador++;
                        LettersEqualString += memory; //Añade la letra que se repitió en la cadena a otra cadena
                    }
                    else
                    {
                        contador++;
                        memory = letter;
                    }


                }
                if (letterCount >= mensaje.Length / 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        
    }
}
//<>