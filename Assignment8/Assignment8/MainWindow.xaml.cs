using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Threading;

namespace Assignment8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer Timer { get; }
        private TimeManager Manager { get; }
        public DateTime LastTickTime { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DropShadowEffect dropShadow = new DropShadowEffect();
            dropShadow.Color = Colors.Black;
            StackPanel.Effect = new DropShadowEffect();
            GuiClock.Effect = new DropShadowEffect();
            ClickMeButton.Effect = new DropShadowEffect();
            IDateTime timeInterface = new TimeManager.Time();
            Manager = new TimeManager(timeInterface);
            MyClock clock = new MyClock();
            clock.AddEvent((sender, e) => { GuiClock.Text = clock.CurrentTime.ToString(); });
        }

        private void TimerButton_OnClick(object sender, RoutedEventArgs e)
        {
            DropShadowEffect dropShadow = new DropShadowEffect {ShadowDepth = 10};

            ListOfItems.Effect = dropShadow;
            if (!Manager.Running)
            {
                LastTickTime = Manager.StartTimer();
                ListOfItems.Items.Add($"Timer Started: {LastTickTime}");
                ClickMeButton.Content = "Stop Timer";
            }
            else
            {
                DateTime startTime = LastTickTime;
                LastTickTime = Manager.StopTimer();
                TimeSpan timeInterval = LastTickTime.Subtract(startTime);
                ListOfItems.Items.Add(
                    $"Timer Stopped:{LastTickTime} {Environment.NewLine}" +
                    $"Elapsed Time:" +
                    $"{timeInterval.Hours} Hours, " +
                    $"{timeInterval.Minutes} Minutes," +
                    $" and {timeInterval.TotalSeconds} seconds" +
                    $"{Environment.NewLine}");
                ClickMeButton.Content = "Start Timer";

            }

        }

    }
}
