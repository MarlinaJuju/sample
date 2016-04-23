using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pi_Basket
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ButStart.Click += ButStart_Click;
            ButHighScore.Click += ButHighScore_Click;
            ButType.Click += ButType_Click;
        }

        private void ButType_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TypeMenu));
        }

        private void ButHighScore_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HighScoreMenu));
        }

        private void ButStart_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SubmitMenu));
        }
    }
}
