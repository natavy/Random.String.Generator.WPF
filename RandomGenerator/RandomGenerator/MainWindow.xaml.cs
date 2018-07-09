using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RandomGenerator
{
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
                  
        public MainWindow()
        {
            InitializeComponent();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            String[] patterns =
                {
                    "Abstract Factory Pattern",
                    "Builder Pattern",
                    "Factory Method Pattern",
                    "Prototype Pattern",
                    "Singleton Pattern",
                    "Adapter Pattern",
                    "Bridge Pattern",
                    "Composite Pattern",
                    "Decorator Pattern",
                    "Facade Pattern",
                    "Flyweight Pattern",
                    "Proxy Pattern",
                    "Chain of Responsibility Pattern",
                    "Command Pattern",
                    "Interpreter Pattern",
                    "Iterator Pattern",
                    "Mediator Pattern",
                    "Memento Pattern",
                    "Observer Pattern",
                    "State Pattern",
                    "Strategy Pattern",
                    "Template Method Pattern",
                    "Visitor Pattern"
                };

            Random rand = new Random();
            int result = rand.Next(0, 22);
            randomtext.Text = patterns[result];
        }
        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(10);
            dispatcherTimer.Start();
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Stop();
        }

    }
}
  
