using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Second
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DispatcherTimer dispatcherTimerGoMainMenu = new DispatcherTimer();
        readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimerGoMainMenu.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimerGoMainMenu.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimerGoMainMenu.IsEnabled = true;

            ChangeBackgrdound();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            ChangeBackgrdound();
        }

        void ChangeBackgrdound()
        {
            Window1.Background =
                new SolidColorBrush(
                    Color.FromRgb(
                    (byte)random.Next(255),
                    (byte)random.Next(255),
                    (byte)random.Next(255)
                    ));
        }
    }
}
