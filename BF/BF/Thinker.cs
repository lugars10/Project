using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BF
{
    class Thinker
    {
        //Variables globales
        string message_anterior;
        public string response = null;
        public int user_messages { set; get; }
        bool complemento;
        public string Support(string helping, string msg) //Sistema interno y externo de response
        {


            if (message_anterior == msg)
            {
                response = "Ya dijiste eso";
                return response;

            }
            if (helping == "111") //Si la cadena es normal
            {
                {
                    //Variables de sistema interno
                    Random lowP = new Random();
                    Random numero = new Random();
                    int decision = numero.Next(1, 6);
                    int lowPn = lowP.Next(1, 101);


                    //Comando de saludo
                    if (msg.Contains("hola") || msg.Contains("saludos") || msg.Contains("qué pasó") || msg.Contains("qué onda") //Linea 1 de if
                      || msg.Contains("qué tal") || user_messages == 0)                                                        //Linea 2 de if
                    {
                        if (user_messages == 0)
                        {
                            complemento = true;
                        }
                        switch (decision)
                        {

                            case 1:
                                response = "Hola";
                                break;
                            case 2:
                                response = "Saludos";
                                break;
                            case 3:
                                response = "Qué pasó?";
                                break;
                            case 4:
                                response = "Qué onda?";
                                break;
                            case 5:
                                response = "Qué tal?";
                                break;
                        }

                    }


                    //Comando de Hora
                    if (msg.Contains("hora") || msg.Contains("rotación") || msg.Contains("tiempo"))
                    {
                        DateTime hora = DateTime.Now;
                        response = $"{hora.Hour.ToString()}:{hora.Minute.ToString()}";
                    }
                    else if (msg.Contains("hora en") || msg.Contains("rotación en") || msg.Contains("tiempo en"))
                    {


                    }
                    //Comando de Fecha
                    if (msg.Contains("fecha") || msg.Contains("calendario") || msg.Contains("traslación") || msg.Contains("día"))

                    {
                        DateTime tiempo = DateTime.Now;
                        response = $"{tiempo.Day.ToString()}/{tiempo.Month.ToString()}/{tiempo.Year.ToString()}";
                    }


                    //Comando de Agradecimiento
                    if (msg.Contains("gracias") || msg.Contains("ty") || msg.Contains("thank"))
                    {
                        switch (decision)
                        {
                            case 1:
                                response = "Por nada :)";
                                break;
                            case 2:
                                response = "No hay de qué :)";
                                break;
                            case 3:
                                response = "De nada :)";
                                break;
                            case 4:
                                response = "De nada :)";
                                break;
                            case 5:
                                response = "Por nada :)";
                                break;

                        }
                    }


                    //Comando de Despedida
                    if (msg.Contains("adios") || msg.Contains("bye") || msg.Contains("hasta") || msg.Contains("nos vemos") || msg.Contains("descansa"))
                    {
                        if (lowPn == 31)
                        {
                            response = "Hasta la vista, baby";
                        }
                        else
                        {

                            switch (decision)
                            {
                                case 1:
                                    response = "Adios";
                                    break;
                                case 2:
                                    response = "Bye";
                                    break;
                                case 3:
                                    response = msg;
                                    break;
                                case 4:
                                    response = "Nos vemos";
                                    break;
                                case 5:
                                    response = "Descansa";
                                    break;
                                default:
                                    response = "Supongo que nos platicamos luego";
                                    break;
                            }

                            

                        }

                    }
                }
            }






            else if (helping != "111") //Si la cadena NO es normal
            {
                char caracter;
                int responseI;
                switch (helping)
                {
                    case "001":                                //Resolución 1
                        responseI = Convert.ToInt32(msg);
                        responseI++;
                        response = responseI.ToString();
                        break;
                    case "100":                                //Resolcuión 1
                        responseI = Convert.ToInt32(msg);
                        responseI++;
                        response = responseI.ToString();
                        break;
                    case "101":                                //Resolución 1
                        responseI = Convert.ToInt32(msg);
                        responseI++;
                        response = responseI.ToString();
                        break;
                    case "011":                               //Resolución 2
                        caracter = Convert.ToChar(msg);
                        caracter++;
                        response = caracter.ToString();
                        break;
                    case "110":                               //Resolucion 3
                        response = "Lo siento, no entendí eso :/";
                        break;
                }

                return response;
                message_anterior = msg;

            }
                return response;
                message_anterior = msg;

            }
        }
    } 