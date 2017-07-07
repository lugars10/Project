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
using System.Windows.Shapes;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace BF
{
    

    public partial class Pruebas : Window
    {
        SpeechRecognitionEngine recognition = new SpeechRecognitionEngine();
        SpeechSynthesizer sintetizador = new SpeechSynthesizer();

        public Pruebas()
        {
            InitializeComponent();
        }

        void recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Confidence >= 0.4)
            {
                if (e.Result.ToString() == "será" || e.Result.ToString() == "Serra")
                {
                    textBox.Text += "cerrar" + Environment.NewLine;
                }
                else
                {
                    foreach (RecognizedWordUnit word in e.Result.Words)
                    {
                        textBox.Text += word.Text + Environment.NewLine;
                    }
                }
            }
               
            

            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            recognition.SetInputToDefaultAudioDevice();
            recognition.LoadGrammar(new DictationGrammar());
            recognition.SpeechRecognized += recognition_SpeechRecognized;
            recognition.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void btnDecir_Click(object sender, RoutedEventArgs e)
        {
            sintetizador.Volume = 100;
            sintetizador.Rate = -2;
            sintetizador.SelectVoice("Microsoft Sabina Desktop");
            sintetizador.Speak(textBox.Text);
            //sintetizador.SpeakAsync("Hello World");

            foreach(InstalledVoice voice in sintetizador.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                textBox.Text += $"Voz: {info.Name}{ Environment.NewLine}";
            }
        }
    }
}
