using System.ComponentModel;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
    private OrderViewModel _viewModel = new OrderViewModel();
    public RadioButton Ciasto { get; set; }
    public Stepper Stepper { get; set; }

    private bool serWBzegu = false;

    public NewPage1()
    {
        InitializeComponent();
        BindingContext = _viewModel;
    }
    public class OrderViewModel : INotifyPropertyChanged
    {
        private string _Rozmiar;

        public string Rozmiar
        {
            get => _Rozmiar;
            set
            {
                _Rozmiar = value;
                OnPropertyChanged(nameof(Rozmiar));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    void RozmiarChange(object sender, CheckedChangedEventArgs e)
    {
        if (!e.Value) return;

        var rb = (RadioButton)sender;
        _viewModel.Rozmiar = rb.Value?.ToString();
        Liczenie();
    }
    void CiastoChange(object sender, CheckedChangedEventArgs e)
    {
        if (!e.Value) return;

        var rb = (RadioButton)sender;
        serWBzegu = rb.Content.ToString().Contains("serem");
        Liczenie();
    }
    void StepperChange(object sender, ValueChangedEventArgs e)
    {
        Liczenie();
    }
    void Liczenie()
    {
        if (!double.TryParse(_viewModel.Rozmiar, out double rozmiar))
        {
            Cena.Text = "Cena: 0 z³";
            return;
        }

        double cena = rozmiar * Ilosc.Value;

        if (serWBzegu)
            cena += 5 * Ilosc.Value;

        Cena.Text = $"Cena: {cena} z³";
    }
}


/*
***********************************************
    nazwa funkcji: RozmiarChange
    opis funkcji: Funkcja obs³uguje zmianê wybranego rozmiaru pizzy. Pobiera wartoœæ klikniêtego RadioButtona i zapisuje j¹ w ViewModelu, a nastêpnie wywo³uje funkcjê Liczenie(), która oblicza cenê pizzy w zale¿noœci od wybranego rozmiaru, rodzaju ciasta oraz iloœci.
    parametry: sender – obiekt wywo³uj¹cy zdarzenie
               e – informacje o zmianie stanu zaznaczenia
    zwracany typ i opis: Brak
    autor: Wiktor Mañkut & Chat GPT
************************************************
***********************************************
    nazwa funkcji: CiastoChange
    opis funkcji: Funkcja obs³uguje zmianê wybranego ciasta pizzy. Pobiera wartoœæ klikniêtego RadioButtona i zapisuje j¹ w ViewModelu, a nastêpnie wywo³uje funkcjê Liczenie(), która oblicza cenê pizzy w zale¿noœci od wybranego rozmiaru, rodzaju ciasta oraz iloœci.
    parametry: sender – obiekt wywo³uj¹cy zdarzenie
               e – informacje o zmianie stanu zaznaczenia
    zwracany typ i opis: Brak
    autor: Wiktor Mañkut & Chat GPT
************************************************
***********************************************
    nazwa funkcji: StepperChange
    opis funkcji: Funkcja wywo³ywana przy zmianie wartoœci Steppera, który s³u¿y do wyboru iloœci pizzy. Po ka¿dej zmianie wywo³uje funkcjê Liczenie(), która oblicza cenê pizzy w zale¿noœci od wybranego rozmiaru, rodzaju ciasta oraz iloœci.
    parametry: Brak          
    zwracany typ i opis: Brak
    autor: Wiktor Mañkut & Chat GPT
************************************************
***********************************************
    nazwa funkcji: Liczenie
    opis funkcji: Funkcja oblicza cenê pizzy na podstawie wybranego rozmiaru, rodzaju ciasta oraz iloœci sztuk. Pobiera wartoœæ rozmiaru z ViewModelu, sprawdza czy ciasto ma dodatkowy koszt (np. ser w brzegu) i mno¿y cenê przez iloœæ wybran¹ w Stepperze. Wynik wyœwietlany jest w Labelu Cena.
    parametry: Brak
    zwracany typ i opis: Brak
    autor: Wiktor Mañkut & Chat GPT 
************************************************    */