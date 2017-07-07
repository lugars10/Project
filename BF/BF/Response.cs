using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BF
{
    class Response
    {
        public void Send(string mensaje, TextBox output)
        {
            output.Text = $"{output.Text}[BF]{mensaje}{Environment.NewLine}";
            
        }
    }
}
