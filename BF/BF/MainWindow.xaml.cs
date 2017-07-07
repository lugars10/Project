using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;





namespace BF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
  
        int messages;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            
            System.Windows.Forms.Application.Restart();
            System.Windows.Application.Current.Shutdown();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            //Indice de Funciones a Ejecutar "ENTRANDO AL CENTRO DE LA APLICACIÓN"

            //Variables:
            msgManipulation y = new msgManipulation();
            Thinker x = new Thinker();
            Response respuesta = new Response();
            DataBase data = new DataBase();
            x.user_messages = messages;

            //Procedimiento:
            OutPut.Text += Environment.NewLine;
            OutPut.Text = $"{OutPut.Text}[Tu]{msgWriter.Text}{Environment.NewLine}";


            y.message = msgWriter.Text;
            string mensaje = x.Support(y.Requirements(true), y.message.ToLower());
            respuesta.Send(mensaje, OutPut);

            data.database.Add("hola", "adios");
            data.database.Add("adios", "hola");
            data.database.Add("suma", "resta");
            string result = data.Search(msgWriter.Text.ToLower());
            respuesta.Send(result, OutPut);

            
        

            messages++;
            //string output = Regex.Replace(msgWriter.Text, "(.)\\1{1,}", "$1");
            //Spelling.Text = output;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Pruebas prueba = new Pruebas();
            prueba.Show();
        }
    }
}
