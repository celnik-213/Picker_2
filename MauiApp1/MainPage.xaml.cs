using System.Globalization;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        void SubmitButton(object sender, EventArgs e)
        {
            if (Specjalizacja.SelectedItem == null)
            {
                DisplayAlert("Błąd", "Proszę wypełnić pole specjalizacja", "OK");
                return;
            }

            var specjalizacja2 = Specjalizacja.SelectedItem.ToString();

            string data2 = Data.Date.ToString();
            string godzina2 = Godzina.Time.ToString();

            if (Data.Date < DateTime.Today)
            {
                DisplayAlert("Błąd", "Data nie może być wcześniejsza niż dzisiaj", "OK");
            }

            DisplayAlert("Potwierdzenie rezerwacji",
                $"Wizyta u: {specjalizacja2}\ndnia: {data2}\no godzinie: {godzina2}", "Potwierdź");
        }

    }
}

/*
    ***********************************************
    nazwa funkcji: SubmitButton
    opis funkcji: Funkcja pobiera dane z formularza i wyświetla je w formie alertu, a także sprawdza czy pole specjalizacja jest wypełnione oraz czy data nie jest wcześniejsza niż dzisiaj.
    parametry: brak
    zwracany typ i opis: brak 
    autor: Wiktor Mańkut
    ************************************************
    */