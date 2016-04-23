using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pi_Basket
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartMenu : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        DateTimeOffset startTime;
        DateTimeOffset lastTime;
        int timesTicked;
        int timesToTick;
        DateTimeOffset stopTime;
        int now = 0;
        bool stop;

        public StartMenu()
        {
            this.InitializeComponent();
            ButSubmit.IsEnabled = false;
            ButSubmit.Click += ButSubmit_Click;
            ButStart.Click += ButStart_Click;
        }

        private void ButStart_Click(object sender, RoutedEventArgs e)
        {
            ButStart.Content = "Starting";
            ButStart.IsEnabled = false;
            timesToTick = 40;
            timesTicked = 1;
            TBlockMenu.Text = "40 second(s)";
            stop = false;
            DispatcherTimerSetup();
        }

        private void ButSubmit_Click(object sender, RoutedEventArgs e)
        {
            stop = false;
            Frame.Navigate(typeof(MainPage));
            
        }

        private void TBlockMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            startTime = DateTimeOffset.Now;
            lastTime = startTime;
            dispatcherTimer.Start();

            //IsEnabled should now be true after calling start
        }
        void dispatcherTimer_Tick(object sender, object e)
        {
            DateTimeOffset time = DateTimeOffset.Now;
            TimeSpan span = time - lastTime;
            lastTime = time;
            now = timesToTick - timesTicked;
            //Time since last tick should be very very close to Interval
            TBlockMenu.Text = now.ToString()+" second(s)";
            timesTicked++;

            //masukkan get dan ubah nilai

            if (timesTicked > timesToTick || stop)
            {
                stopTime = time;
                dispatcherTimer.Stop();
                //IsEnabled should now be false after calling stop
                span = stopTime - startTime;
                TBlockMenu.Text = "Finish";
                ButStart.IsEnabled = true;
                ButSubmit.IsEnabled = true;

            }
        }
    }
}
