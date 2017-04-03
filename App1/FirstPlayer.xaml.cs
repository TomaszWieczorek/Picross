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
using System.Windows;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FirstPlayer : Page
    {
        public bool czyOkienko = false;
        public FirstPlayer()
        {
            this.InitializeComponent();
            if (gracz.wybor == 'M') btnNazwa.Content = "Player vs Player";
            if (gracz.wybor == 'S') btnNazwa.Content = "Player vs AI";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnUsun_Click(object sender, RoutedEventArgs e)
        {
            txtNazwaX.Text = "";
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private async void btnZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox;
            if (czyOkienko == false)
            {
                if (txtNazwaX.Text.Length > 10)
                {
                    msgbox = new MessageDialog("The name is too long!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else if (txtNazwaX.Text.Length < 3)
                {
                    msgbox = new MessageDialog("The name is too short!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else
                {
                    msgbox = new MessageDialog("The name is correct!\nWelcome " + txtNazwaX.Text + "!\nYour color is green\nGOOD LUCK!", "Information");
                    await msgbox.ShowAsync();
                    gracz.playerX = txtNazwaX.Text;
                    if (gracz.wybor == 'S') Frame.Navigate(typeof(Single));
                    if (gracz.wybor == 'M') Frame.Navigate(typeof(SecondPlayer));
                }
            }
            else
            {
                gracz.playerX = txtNazwaX.Text;
                if (gracz.wybor == 'S') Frame.Navigate(typeof(Single));
                if (gracz.wybor == 'M') Frame.Navigate(typeof(SecondPlayer));
            }
            
        }

        private async void txtNazwaX_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                MessageDialog msgbox;
                txtNazwaX.IsEnabled = false;
                txtNazwaX.IsEnabled = true;
                if (txtNazwaX.Text.Length > 10)
                {
                    msgbox = new MessageDialog("The name is too long!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else if (txtNazwaX.Text.Length < 3)
                {
                    msgbox = new MessageDialog("The name is too short!\nChoose another name!", "Warning!");
                    await msgbox.ShowAsync();
                }
                else
                {
                    czyOkienko = true;
                    msgbox = new MessageDialog("The name is correct!\nWelcome " + txtNazwaX.Text + "!\nGOOD LUCK!", "Information");
                    await msgbox.ShowAsync();
                }
            }
        }
    }
}
