using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    /// <summary>
    /// //Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        liczenie liczenie = new liczenie();//tworzymy objekt klasy liczenie
        bool gdzieWpisać = true;
        bool czyWyczyścićPasekWyniku = false;//jeśli jest równe true, to przy wpisaniu liczby pasek wyniku zostanie wyczyszczony
        public MainWindow()
        {
            InitializeComponent();
        }

        private void liczba_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
                pasekWyniku.Text = (sender as Button).Content.ToString();
            else
                pasekWyniku.Text += (sender as Button).Content.ToString();
            czyWyczyścićPasekWyniku = false;
        }

        private void przecinek_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
                pasekWyniku.Text = "0,";
            else
                pasekWyniku.Text += ",";
            czyWyczyścićPasekWyniku = false;
        }

        private void działanie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.działanie = (sender as Button).Content.ToString()[0];
            czyWyczyścićPasekWyniku = true;//czyścimy pasek tekstowy
            gdzieWpisać = false;
        }

        private void wynik_Click(object sender, RoutedEventArgs e)
        {
            gdzieWpisać = true;
            liczenie.a = liczenie.licz();
            pasekWyniku.Text = liczenie.a.ToString();//wyświetlamy wynik
            czyWyczyścićPasekWyniku = true;
        }

        private void pasekWyniku_TextChanged(object sender, TextChangedEventArgs e)
        {


            try
            {
                if (gdzieWpisać)
                    liczenie.a = double.Parse(pasekWyniku.Text);
                else
                    liczenie.b = double.Parse(pasekWyniku.Text);
            }
            catch (FormatException)//jeśli wprowadzono błędnie liczbę wykonuje poniższy kod
            {
                if (pasekWyniku.Text != "")
                    MessageBox.Show("Nie wpisano prawidłowo liczby", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);//komunikat o błędzie, ale tylko, jeśli pole nie jest puste
            }

        }


        private void czyszczenie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.a = liczenie.b = 0;
            liczenie.działanie = ' ';
            pasekWyniku.Text = "";
            czyWyczyścićPasekWyniku = false;
            gdzieWpisać = true;
        }
    }
}
