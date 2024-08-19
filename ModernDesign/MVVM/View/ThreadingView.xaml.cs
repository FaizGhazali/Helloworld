using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Interaction logic for ThreadingView.xaml
    /// </summary>
    public partial class ThreadingView : UserControl
    {
        private Thread thread1;

        public ThreadingView()
        {
            InitializeComponent();
        }

        // This method is called from a separate thread
        public void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                // Update the UI safely using Dispatcher
                Dispatcher.Invoke(() =>
                {
                    labelThreading.Content += $"\n{name} : {i} seconds";
                });

                Thread.Sleep(1000);
            }

            // Final update when countdown is complete
            Dispatcher.Invoke(() =>
            {
                labelThreading.Content += $"\n{name} is complete!";
            });
        }

        private void StartBtn_C(object sender, RoutedEventArgs e)
        {
            // Retrieve the text from the TextBox
            string name = textboxName.Text;

            // Start the countdown in a new thread
            thread1 = new Thread(() => CountDown(name));
            thread1.Start();

            // Optionally, clear the TextBox after updating the Label
            textboxName.Clear();
        }

        private void StopBtn_C(object sender, RoutedEventArgs e)
        {
            // Add logic to stop the thread if needed
        }
    }
}
