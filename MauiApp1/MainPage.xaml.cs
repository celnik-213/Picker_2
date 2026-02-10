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
