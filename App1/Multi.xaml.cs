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
using Windows.UI;
using Windows.UI.Text;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Multi : Page
    {
        public string playerX = gracz.playerX;
        public Multi()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            btn1x1.Content = null;
            btn1x2.Content = null;
            btn1x3.Content = null;
            btn2x1.Content = null;
            btn2x2.Content = null;
            btn2x3.Content = null;
            btn3x1.Content = null;
            btn3x2.Content = null;
            btn3x3.Content = null;
            btn1x1.IsEnabled = false;
            btn1x2.IsEnabled = false;
            btn1x3.IsEnabled = false;
            btn2x1.IsEnabled = false;
            btn2x2.IsEnabled = false;
            btn2x3.IsEnabled = false;
            btn3x1.IsEnabled = false;
            btn3x2.IsEnabled = false;
            btn3x3.IsEnabled = false;
            btnKogoRuchTekst.Visibility = Visibility.Visible;
            btnKogoRuch.Visibility = Visibility.Visible;
            btnStart.Content = "New game";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        public char ktoRuch;
        private void Wynik(char wyn, Button btn1, Button btn2, Button btn3)
        {
            txtWynik.Visibility = Visibility.Visible;
            txtWynik.FontSize = 35;
            txtWynik.FontWeight = FontWeights.Bold;
            txtWynik.TextAlignment = TextAlignment.Center;

            btn1x1.IsEnabled = false;
            btn1x2.IsEnabled = false;
            btn1x3.IsEnabled = false;
            btn2x1.IsEnabled = false;
            btn2x2.IsEnabled = false;
            btn2x3.IsEnabled = false;
            btn3x1.IsEnabled = false;
            btn3x2.IsEnabled = false;
            btn3x3.IsEnabled = false;
            if (wyn == 'W')
            {
                txtWynik.Foreground = new SolidColorBrush(Colors.Green);
                btn1.Background = new SolidColorBrush(Colors.Green);
                btn2.Background = new SolidColorBrush(Colors.Green);
                btn3.Background = new SolidColorBrush(Colors.Green);
                txtWynik.Text = gracz.playerX + " wins!";
            }
            else if (wyn == 'L')
            {
                txtWynik.Foreground = new SolidColorBrush(Colors.Red);
                btn1.Background = new SolidColorBrush(Colors.Red);
                btn2.Background = new SolidColorBrush(Colors.Red);
                btn3.Background = new SolidColorBrush(Colors.Red);
                txtWynik.Text = gracz.playerO + " wins!";
            }
            btnKogoRuchTekst.Visibility = Visibility.Collapsed;
            btnKogoRuch.Visibility = Visibility.Collapsed;
            btnStart.IsEnabled = true;
            btnStart.Content = "New game";
        }        
        public void Draw()
        {
            txtWynik.Visibility = Visibility.Visible;
            txtWynik.Foreground = new SolidColorBrush(Colors.Blue);
            txtWynik.FontSize = 35;
            txtWynik.TextAlignment = TextAlignment.Center;
            txtWynik.FontWeight = FontWeights.Bold;
            txtWynik.Text = "Draw!";
            btn1x1.IsEnabled = false;
            btn1x2.IsEnabled = false;
            btn1x3.IsEnabled = false;
            btn2x1.IsEnabled = false;
            btn2x2.IsEnabled = false;
            btn2x3.IsEnabled = false;
            btn3x1.IsEnabled = false;
            btn3x2.IsEnabled = false;
            btn3x3.IsEnabled = false;
            btnKogoRuchTekst.Visibility = Visibility.Collapsed;
            btnKogoRuch.Visibility = Visibility.Collapsed;
            btnStart.IsEnabled = true;
            btnStart.Content = "New game";
        }
        private void Sprawdz()
        {
            if (Convert.ToString(btn1x1.Content) == "X" &&
                    Convert.ToString(btn1x2.Content) == "X" &&
                    Convert.ToString(btn1x3.Content) == "X")
                Wynik('W', btn1x1, btn1x2, btn1x3);
            else
                if (Convert.ToString(btn2x1.Content) == "X" &&
                    Convert.ToString(btn2x2.Content) == "X" &&
                    Convert.ToString(btn2x3.Content) == "X")
                Wynik('W', btn2x1, btn2x2, btn2x3);
            else
                if (Convert.ToString(btn3x1.Content) == "X" &&
                    Convert.ToString(btn3x2.Content) == "X" &&
                    Convert.ToString(btn3x3.Content) == "X")
                Wynik('W', btn3x1, btn3x2, btn3x3);
            else
                if (Convert.ToString(btn1x1.Content) == "X" &&
                    Convert.ToString(btn2x1.Content) == "X" &&
                    Convert.ToString(btn3x1.Content) == "X")
                Wynik('W', btn1x1, btn2x1, btn3x1);
            else
                if (Convert.ToString(btn1x2.Content) == "X" &&
                    Convert.ToString(btn2x2.Content) == "X" &&
                    Convert.ToString(btn3x2.Content) == "X")
                Wynik('W', btn1x2, btn2x2, btn3x2);
            else
                if (Convert.ToString(btn1x3.Content) == "X" &&
                    Convert.ToString(btn2x3.Content) == "X" &&
                    Convert.ToString(btn3x3.Content) == "X")
                Wynik('W', btn1x3, btn2x3, btn3x3);
            else
                if (Convert.ToString(btn1x1.Content) == "X" &&
                    Convert.ToString(btn2x2.Content) == "X" &&
                    Convert.ToString(btn3x3.Content) == "X")
                Wynik('W', btn1x1, btn2x2, btn3x3);
            else
                if (Convert.ToString(btn1x3.Content) == "X" &&
                    Convert.ToString(btn2x2.Content) == "X" &&
                    Convert.ToString(btn3x1.Content) == "X")
                Wynik('W', btn1x3, btn2x2, btn3x1);
            else
                if (Convert.ToString(btn1x1.Content) == "O" &&
                    Convert.ToString(btn1x2.Content) == "O" &&
                    Convert.ToString(btn1x3.Content) == "O")
                Wynik('L', btn1x1, btn1x2, btn1x3);
            else
                if (Convert.ToString(btn2x1.Content) == "O" &&
                    Convert.ToString(btn2x2.Content) == "O" &&
                    Convert.ToString(btn2x3.Content) == "O")
                Wynik('L', btn2x1, btn2x2, btn2x3);
            else
                if (Convert.ToString(btn3x1.Content) == "O" &&
                    Convert.ToString(btn3x2.Content) == "O" &&
                    Convert.ToString(btn3x3.Content) == "O")
                Wynik('L', btn3x1, btn3x2, btn3x3);
            else
                if (Convert.ToString(btn1x1.Content) == "O" &&
                    Convert.ToString(btn2x1.Content) == "O" &&
                    Convert.ToString(btn3x1.Content) == "O")
                Wynik('L', btn1x1, btn2x1, btn3x1);
            else
                if (Convert.ToString(btn1x2.Content) == "O" &&
                    Convert.ToString(btn2x2.Content) == "O" &&
                    Convert.ToString(btn3x2.Content) == "O")
                Wynik('L', btn1x2, btn2x2, btn3x2);
            else
                if (Convert.ToString(btn1x3.Content) == "O" &&
                    Convert.ToString(btn2x3.Content) == "O" &&
                    Convert.ToString(btn3x3.Content) == "O")
                Wynik('L', btn1x3, btn2x3, btn3x3);
            else
                if (Convert.ToString(btn1x1.Content) == "O" &&
                    Convert.ToString(btn2x2.Content) == "O" &&
                    Convert.ToString(btn3x3.Content) == "O")
                Wynik('L', btn1x1, btn2x2, btn3x3);
            else
                if (Convert.ToString(btn1x3.Content) == "O" &&
                    Convert.ToString(btn2x2.Content) == "O" &&
                    Convert.ToString(btn3x1.Content) == "O")
                Wynik('L', btn1x3, btn2x2, btn3x1);
            else
                if ((Convert.ToString(btn1x1.Content) == "X" || Convert.ToString(btn1x1.Content) == "O") &&
                    (Convert.ToString(btn1x2.Content) == "X" || Convert.ToString(btn1x2.Content) == "O") &&
                    (Convert.ToString(btn1x3.Content) == "X" || Convert.ToString(btn1x3.Content) == "O") &&
                    (Convert.ToString(btn2x1.Content) == "X" || Convert.ToString(btn2x1.Content) == "O") &&
                    (Convert.ToString(btn2x2.Content) == "X" || Convert.ToString(btn2x2.Content) == "O") &&
                    (Convert.ToString(btn2x3.Content) == "X" || Convert.ToString(btn2x3.Content) == "O") &&
                    (Convert.ToString(btn3x1.Content) == "X" || Convert.ToString(btn3x1.Content) == "O") &&
                    (Convert.ToString(btn3x2.Content) == "X" || Convert.ToString(btn3x2.Content) == "O") &&
                    (Convert.ToString(btn3x3.Content) == "X" || Convert.ToString(btn3x3.Content) == "O"))
                Draw();
            else 
                if (ktoRuch == 'O')
                {
                    btnKogoRuch.Content = 'O';
                }
            else 
                if (ktoRuch == 'X')
                {
                    btnKogoRuch.Content = 'X';
                }
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btn1x1.Content = null;
            btn1x2.Content = null;
            btn1x3.Content = null;
            btn2x1.Content = null;
            btn2x2.Content = null;
            btn2x3.Content = null;
            btn3x1.Content = null;
            btn3x2.Content = null;
            btn3x3.Content = null;
            btn1x1.IsEnabled = true;
            btn1x2.IsEnabled = true;
            btn1x3.IsEnabled = true;
            btn2x1.IsEnabled = true;
            btn2x2.IsEnabled = true;
            btn2x3.IsEnabled = true;
            btn3x1.IsEnabled = true;
            btn3x2.IsEnabled = true;
            btn3x3.IsEnabled = true;
            btn1x1.Background = new SolidColorBrush();
            btn1x2.Background = new SolidColorBrush();
            btn1x3.Background = new SolidColorBrush();
            btn2x1.Background = new SolidColorBrush();
            btn2x2.Background = new SolidColorBrush();
            btn2x3.Background = new SolidColorBrush();
            btn3x1.Background = new SolidColorBrush();
            btn3x2.Background = new SolidColorBrush();
            btn3x3.Background = new SolidColorBrush();
            txtWynik.Foreground = new SolidColorBrush(Colors.Black);
            btnStart.Content = "Restart";
            txtWynik.Visibility = Visibility.Collapsed;
            btnKogoRuchTekst.Visibility = Visibility.Visible;
            btnKogoRuch.Visibility = Visibility.Visible;
            Random rnd1 = new Random();
            int kto = rnd1.Next(2);
            if (kto == 0)
            {
                ktoRuch = 'X';
                btnKogoRuch.Content = "O";
                Sprawdz();
            }
            else if (kto == 1)
            {
                ktoRuch = 'O';
                btnKogoRuch.Content = "O";
                Sprawdz();
            }
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (ktoRuch == 'X')
            {
                btn.Content = "X";
                ktoRuch = 'O';
            }
            else
            {
                btn.Content = "O";
                ktoRuch = 'X';
            }
            btn.IsEnabled = false;
            Sprawdz();
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            btn1x1.Content = null;
            btn1x2.Content = null;
            btn1x3.Content = null;
            btn2x1.Content = null;
            btn2x2.Content = null;
            btn2x3.Content = null;
            btn3x1.Content = null;
            btn3x2.Content = null;
            btn3x3.Content = null;
            btn1x1.IsEnabled = false;
            btn1x2.IsEnabled = false;
            btn1x3.IsEnabled = false;
            btn2x1.IsEnabled = false;
            btn2x2.IsEnabled = false;
            btn2x3.IsEnabled = false;
            btn3x1.IsEnabled = false;
            btn3x2.IsEnabled = false;
            btn3x3.IsEnabled = false;
            btnStart.Content = "New game";
            txtWynik.Visibility = Visibility.Collapsed;
            btnKogoRuch.Visibility = Visibility.Visible;
            btnKogoRuchTekst.Visibility = Visibility.Visible;
            Frame.Navigate(typeof(MainPage));
        }
    }
}
