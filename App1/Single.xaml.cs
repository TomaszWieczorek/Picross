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
    public sealed partial class Single : Page
    {
            public Single()
            {           
                this.InitializeComponent();
                this.NavigationCacheMode = NavigationCacheMode.Required;
            }
            protected override void OnNavigatedTo(NavigationEventArgs e)
            {
                // TODO: Prepare page for display here.

                // TODO: If your application contains multiple pages, ensure that you are
                // handling the hardware Back button by registering for the
                // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
                // If you are using the NavigationHelper provided by some templates,
                // this event is handled for you.
            }
            private char ktoRuch;
            public void ruchKomputer()
            {
                int[,] tab = new int[3, 3];
                

                Random rnd = new Random();
                bool udane = false;
                do
                {
                    if (Convert.ToString(btn1x1.Content) == "") tab[0, 0] = 0;
                    else if (Convert.ToString(btn1x1.Content) == "X") tab[0, 0] = 1;
                    else if (Convert.ToString(btn1x1.Content) == "O") tab[0, 0] = 2;
                    if (Convert.ToString(btn1x2.Content) == "") tab[0, 1] = 0;
                    else if (Convert.ToString(btn1x2.Content) == "X") tab[0, 1] = 1;
                    else if (Convert.ToString(btn1x2.Content) == "O") tab[0, 1] = 2;
                    if (Convert.ToString(btn1x3.Content) == "") tab[0, 2] = 0;
                    else if (Convert.ToString(btn1x3.Content) == "X") tab[0, 2] = 1;
                    else if (Convert.ToString(btn1x3.Content) == "O") tab[0, 2] = 2;
                    if (Convert.ToString(btn2x1.Content) == "") tab[1, 0] = 0;
                    else if (Convert.ToString(btn2x1.Content) == "X") tab[1, 0] = 1;
                    else if (Convert.ToString(btn2x1.Content) == "O") tab[1, 0] = 2;
                    if (Convert.ToString(btn2x2.Content) == "") tab[1, 1] = 0;
                    else if (Convert.ToString(btn2x2.Content) == "X") tab[1, 1] = 1;
                    else if (Convert.ToString(btn2x2.Content) == "O") tab[1, 1] = 2;
                    if (Convert.ToString(btn2x3.Content) == "") tab[1, 2] = 0;
                    else if (Convert.ToString(btn2x3.Content) == "X") tab[1, 2] = 1;
                    else if (Convert.ToString(btn2x3.Content) == "O") tab[1, 2] = 2;
                    if (Convert.ToString(btn3x1.Content) == "") tab[2, 0] = 0;
                    else if (Convert.ToString(btn3x1.Content) == "X") tab[2, 0] = 1;
                    else if (Convert.ToString(btn3x1.Content) == "O") tab[2, 0] = 2;
                    if (Convert.ToString(btn3x2.Content) == "") tab[2, 1] = 0;
                    else if (Convert.ToString(btn3x2.Content) == "X") tab[2, 1] = 1;
                    else if (Convert.ToString(btn3x2.Content) == "O") tab[2, 1] = 2;
                    if (Convert.ToString(btn3x3.Content) == "") tab[2, 2] = 0;
                    else if (Convert.ToString(btn3x3.Content) == "X") tab[2, 2] = 1;
                    else if (Convert.ToString(btn3x3.Content) == "O") tab[2, 2] = 2;
                    int liczba = rnd.Next(0, 8);
                    //czy komputer wygrywa
                    //poziomo 1 rzad
                    if (tab[0, 0] == 2 && tab[0, 1] == 2 && tab[0, 2] != 1 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 0] == 2 && tab[0, 2] == 2 && tab[0, 1] != 1 && tab[0, 1] == 0)
                    {
                        btn1x2.Content = "O";
                        btn1x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 1] == 2 && tab[0, 2] == 2 && tab[0, 0] != 1 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    //poziomo 2 rzad
                    else if (tab[1, 0] == 2 && tab[1, 1] == 2 && tab[1, 2] != 1 && tab[1, 2] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 0] == 2 && tab[1, 2] == 2 && tab[1, 1] != 1 && tab[1, 1] != 2 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 2 && tab[1, 2] == 2 && tab[1, 0] != 1 && tab[1, 0] == 0)
                    {
                        btn2x1.Content = "O";
                        btn2x1.IsEnabled = false;
                        udane = true;
                    }
                    //poziomo 3 rzad
                    else if (tab[2, 0] == 2 && tab[2, 1] == 2 && tab[2, 2] != 1 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[2, 0] == 2 && tab[2, 2] == 2 && tab[2, 1] != 1 && tab[2, 1] == 0)
                    {
                        btn3x2.Content = "O";
                        btn3x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[2, 1] == 2 && tab[2, 2] == 2 && tab[2, 0] != 1 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    //pionowo 1 kolumna
                    else if (tab[0, 0] == 2 && tab[1, 0] == 2 && tab[2, 0] != 1 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 0] == 2 && tab[2, 0] == 2 && tab[1, 0] != 1 && tab[1, 0] == 0)
                    {
                        btn2x1.Content = "O";
                        btn2x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 0] == 2 && tab[2, 0] == 2 && tab[0, 0] != 1 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    //pionowo 2 kolumna
                    else if (tab[0, 1] == 2 && tab[1, 1] == 2 && tab[2, 1] != 1 && tab[2, 1] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 1] == 2 && tab[2, 1] == 2 && tab[1, 1] != 1 && tab[1, 1] != 2 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 2 && tab[2, 1] == 2 && tab[0, 1] != 1 && tab[0, 1] == 0)
                    {
                        btn1x2.Content = "O";
                        btn1x2.IsEnabled = false;
                        udane = true;
                    }
                    //pionowo 3 kolumna
                    else if (tab[0, 2] == 2 && tab[1, 2] == 2 && tab[2, 2] != 1 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 2] == 2 && tab[2, 2] == 2 && tab[1, 2] != 1 && tab[1, 2] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 2] == 2 && tab[2, 2] == 2 && tab[0, 2] != 1 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    //skos lewa gora prawy dol
                    else if (tab[0, 0] == 2 && tab[2, 2] == 2 && tab[1, 1] != 1 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 0] == 2 && tab[1, 1] == 2 && tab[2, 2] != 1 && tab[2, 2] != 2 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 2 && tab[2, 2] == 2 && tab[0, 0] != 1 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    //skos prawa gora lewy dol
                    else if (tab[0, 2] == 2 && tab[1, 1] == 2 && tab[2, 0] != 1 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 2] == 2 && tab[2, 0] == 2 && tab[1, 1] != 1 && tab[1, 1] != 2 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 2 && tab[2, 0] == 2 && tab[0, 2] != 1 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    //nastepnie czy gracz wygrywa
                    //poziomo 1 rzad
                    else if (tab[0, 0] == 1 && tab[0, 1] == 1 && tab[0, 2] != 1 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 0] == 1 && tab[0, 2] == 1 && tab[0, 1] != 1 && tab[0, 1] == 0)
                    {
                        btn1x2.Content = "O";
                        btn1x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 1] == 1 && tab[0, 2] == 1 && tab[0, 0] != 1 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    //poziomo 2 rzad
                    else if (tab[1, 0] == 1 && tab[1, 1] == 1 && tab[1, 2] != 1 && tab[1, 2] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 0] == 1 && tab[1, 2] == 1 && tab[1, 1] != 1 && tab[1, 1] != 2 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 1 && tab[1, 2] == 1 && tab[1, 0] != 1 && tab[1, 0] == 0)
                    {
                        btn2x1.Content = "O";
                        btn2x1.IsEnabled = false;
                        udane = true;
                    }
                    //poziomo 3 rzad
                    else if (tab[2, 0] == 1 && tab[2, 1] == 1 && tab[2, 2] != 1 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[2, 0] == 1 && tab[2, 2] == 1 && tab[2, 1] != 1 && tab[2, 1] == 0)
                    {
                        btn3x2.Content = "O";
                        btn3x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[2, 1] == 1 && tab[2, 2] == 1 && tab[2, 0] != 1 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    //pionowo 1 kolumna
                    else if (tab[0, 0] == 1 && tab[1, 0] == 1 && tab[2, 0] != 1 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 0] == 1 && tab[2, 0] == 1 && tab[1, 0] != 1 && tab[1, 0] == 0)
                    {
                        btn2x1.Content = "O";
                        btn2x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 0] == 1 && tab[2, 0] == 1 && tab[0, 0] != 1 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    //pionowo 2 kolumna
                    else if (tab[0, 1] == 1 && tab[1, 1] == 1 && tab[2, 1] != 1 && tab[2, 1] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 1] == 1 && tab[2, 1] == 1 && tab[1, 1] != 1 && tab[1, 1] != 2 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 1 && tab[2, 1] == 1 && tab[0, 1] != 1 && tab[0, 1] == 0)
                    {
                        btn1x2.Content = "O";
                        btn1x2.IsEnabled = false;
                        udane = true;
                    }
                    //pionowo 3 kolumna
                    else if (tab[0, 2] == 1 && tab[1, 2] == 1 && tab[2, 2] != 1 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 2] == 1 && tab[2, 2] == 1 && tab[1, 2] != 1 && tab[1, 2] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 2] == 1 && tab[2, 2] == 1 && tab[0, 2] != 1 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    //skos lewa gora prawy dol
                    else if (tab[0, 0] == 1 && tab[2, 2] == 1 && tab[1, 1] != 1 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 0] == 1 && tab[1, 1] == 1 && tab[2, 2] != 1 && tab[2, 2] != 2 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 1 && tab[2, 2] == 1 && tab[0, 0] != 1 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    //skos prawa gora lewy dol
                    else if (tab[0, 2] == 1 && tab[1, 1] == 1 && tab[2, 0] != 1 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[0, 2] == 1 && tab[2, 0] == 1 && tab[1, 1] != 1 && tab[1, 1] != 2 && tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (tab[1, 1] == 1 && tab[2, 0] == 1 && tab[0, 2] != 1 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    //losowo
                    else if (tab[1, 1] == 0)
                    {
                        btn2x2.Content = "O";
                        btn2x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 0 && tab[0, 0] == 0)
                    {
                        btn1x1.Content = "O";
                        btn1x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 1 && tab[0, 1] == 0)
                    {
                        btn1x2.Content = "O";
                        btn1x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 2 && tab[0, 2] == 0)
                    {
                        btn1x3.Content = "O";
                        btn1x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 3 && tab[1, 0] == 0)
                    {
                        btn2x1.Content = "O";
                        btn2x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 4 && tab[1, 2] == 0)
                    {
                        btn2x3.Content = "O";
                        btn2x3.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 5 && tab[2, 0] == 0)
                    {
                        btn3x1.Content = "O";
                        btn3x1.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 6 && tab[2, 1] == 0)
                    {
                        btn3x2.Content = "O";
                        btn3x2.IsEnabled = false;
                        udane = true;
                    }
                    else if (liczba == 7 && tab[2, 2] == 0)
                    {
                        btn3x3.Content = "O";
                        btn3x3.IsEnabled = false;
                        udane = true;
                    }
                } while (udane == false);
                ktoRuch = 'X';
                btnStart.Content = "Restart";
                Sprawdz();
            }
            private void Sprawdz()
            {
                if (Convert.ToString(btn1x1.Content) == "X" && 
                    Convert.ToString(btn1x2.Content) == "X" && 
                    Convert.ToString(btn1x3.Content) == "X")
                        Wynik('W',btn1x1, btn1x2, btn1x3);
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
                        ruchKomputer();


            }
            private void Wynik(char wyn, Button btn1, Button btn2, Button btn3)
            {
                txtWynik.Visibility = Visibility.Visible;
                txtWynik.Foreground = new SolidColorBrush(Colors.Red);
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
                    btn1.Background = new SolidColorBrush(Colors.Green);
                    btn2.Background = new SolidColorBrush(Colors.Green);
                    btn3.Background = new SolidColorBrush(Colors.Green);
                    txtWynik.Text = gracz.playerX + " wins!";
                }
                else if (wyn == 'L')
                {
                    btn1.Background = new SolidColorBrush(Colors.Red);
                    btn2.Background = new SolidColorBrush(Colors.Red);
                    btn3.Background = new SolidColorBrush(Colors.Red);
                    txtWynik.Text = gracz.playerX + " lose!";
                }
                btnStart.IsEnabled = true;
                btnStart.Content = "New game";
            }
            private void Draw()
        {
            txtWynik.Visibility = Visibility.Visible;
            txtWynik.Foreground = new SolidColorBrush(Colors.Red);
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
            
            txtWynik.Text = "Draw!";
            btnStart.IsEnabled = true;
            btnStart.Content = "New game";
        }
            private void btn_Click(object sender, RoutedEventArgs e)
            {
                Button btn = sender as Button;
                btn.Content = "X";
                ktoRuch = 'O';
                btn.IsEnabled = false;
                Sprawdz();
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
                btnStart.Content = "Restart";
                txtWynik.Visibility = Visibility.Collapsed;
                Random rnd1 = new Random();
                int kto = rnd1.Next(2);
                if (kto == 0)
                {
                    ktoRuch = 'X';
                    Sprawdz();
                }
                else if (kto == 1)
                {
                    ktoRuch = 'O';
                    Sprawdz();
                }

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
                Frame.Navigate(typeof(MainPage));
            }
        }
    }

