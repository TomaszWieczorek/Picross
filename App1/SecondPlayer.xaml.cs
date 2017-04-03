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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondPlayer : Page
    {
        public bool czyOkienko = false;
        public SecondPlayer()
        {
            this.InitializeComponent();
            if (gracz.wybor == 'M') btnNazwaO.Content = "Player vs Player";
            if (gracz.wybor == 'S') btnNazwaO.Content = "Player vs AI";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void btnUsunO_Click(object sender, RoutedEventArgs e)
        {
            txtNazwaO.Text = "";
        }

        private void buttonExitO_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private async void btnZatwierdzO_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox;
            if (czyOkienko == false)
            {
                if (txtNazwaO.Text.Length > 10)
                {
                    msgbox = new MessageDialog("The name is too long!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else if (txtNazwaO.Text.Length < 3)
                {
                    msgbox = new MessageDialog("The name is too short!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else
                {
                    msgbox = new MessageDialog("The name is correct!\nWelcome " + txtNazwaO.Text + "!\nYour color is red\nGOOD LUCK!", "Information");
                    await msgbox.ShowAsync();
                    gracz.playerO = txtNazwaO.Text;
                    Frame.Navigate(typeof(Multi));
                }
            }
            else
            {
                gracz.playerO = txtNazwaO.Text;
                Frame.Navigate(typeof(Multi));
            }
        }

        private async void txtNazwaO_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.Escape)
            {
                txtNazwaO.IsEnabled = false;
                txtNazwaO.IsEnabled = true;
                MessageDialog msgbox;

                if (txtNazwaO.Text.Length > 10)
                {
                    msgbox = new MessageDialog("The name is too long!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();                    
                }
                else if (txtNazwaO.Text.Length < 3)
                {
                    msgbox = new MessageDialog("The name is too short!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else
                {
                    msgbox = new MessageDialog("The name is correct!\nWelcome " + txtNazwaO.Text + "!\nGOOD LUCK!", "Information");
                    await msgbox.ShowAsync();
                    czyOkienko = true;
                }
            }
        }
    }
}
