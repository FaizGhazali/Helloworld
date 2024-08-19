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

namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Interaction logic for ThreadingView.xaml
    /// </summary>
    public partial class ThreadingView : UserControl
    {
        public ThreadingView()
        {
            InitializeComponent();
        }
        private void StartBtn_C(object sender,EventArgs e)
        {
            // Retrieve the text from the TextBox
            string name = textboxName.Text;

            // Check if the Label has existing content
            if (string.IsNullOrEmpty(labelThreading.Content as string))
            {
                // If the Label is empty, just set the new text
                labelThreading.Content = name;
            }
            else
            {
                // Otherwise, append the new text with a newline
                labelThreading.Content += "\n" + name;
            }

            // Optionally, clear the TextBox after updating the Label
            textboxName.Clear();
        }
        private void StopBtn_C(Object sender, EventArgs e)
        {
        }


    }
}
