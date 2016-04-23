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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pi_Basket
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SubmitMenu : Page
    {
        public SubmitMenu()
        {
            this.InitializeComponent();
            TBlockAlert.Text = "";
            TBNick.Focus(FocusState.Programmatic);
            ButSubmit.Click += ButSubmit_Click;
            
        }

        private void ButSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (TBNick.Text == null || TBNick.Text=="")
            {
                TBlockAlert.Text="* Id couldn't be empty";
            }
            else
            {
                //TBNick.Text="";
                //TBNick.Focus(FocusState.Programmatic);
                //TBlockAlert.Text = "Change your name";

                Frame.Navigate(typeof(StartMenu));
            }
        }
    }
}
