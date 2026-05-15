using System.ComponentModel;

namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
    int totalPrice;
    public NewPage2()
    {
        InitializeComponent();
        _viewModel = new OrderViewModel();
        BindingContext = _viewModel;
    }
    private OrderViewModel _viewModel;
    public class OrderViewModel : INotifyPropertyChanged
    {
        private string _selectedPacket;
        public string selectedPacket
        {
            get => _selectedPacket;
            set
            {
                _selectedPacket = value;
                OnPropertyChanged(nameof(selectedPacket));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    private void Register(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(nameSurnameEntry.Text) && !string.IsNullOrEmpty(emailEntry.Text) && itemPicker.SelectedIndex >= 0)
        {
            DisplayAlert("Rejestracja", $"Zarejestrowano: {nameSurnameEntry.Text} {emailEntry.Text} na {itemPicker.SelectedItem.ToString()} łączna cena to {totalPrice} zł", "OK");
        }
        else
        {
            DisplayAlert("Rejestracja nieudana ", $"Proszę o wypełnienie każdego pola", "OK");
        }
    }
    private void calculatePrice(object sender, EventArgs e)
    {
        int basePrice = 0;
        int pricePerAdittionalPerson = 100;
        int numberOfAdditionalPeople = (int)additionalPepole.Value;
        switch (_viewModel.selectedPacket)
        {
            case "Basic":
                basePrice = 200;
                break;
            case "Standard":
                basePrice = 350;
                break;
            case "Premium":
                basePrice = 500;
                break;
        }
        totalPrice = basePrice + (pricePerAdittionalPerson * numberOfAdditionalPeople);

        resultLabel.Text = $"Cena całkowita: {totalPrice} zł";

    }
}

/*
***********************************************
    nazwa funkcji: Register
    opis funkcji: Funkcja obsługuje zdarzenie kliknięcia przycisku rejestracji. 
    Sprawdza czy pola imienia i nazwiska, adresu email oraz wybór elementu 
    w kontrolce Picker zostały wypełnione. Jeśli wszystkie pola są poprawne 
    wyświetla komunikat z informacją o udanej rejestracji wraz z wybraną opcją 
    oraz obliczoną ceną całkowitą. W przeciwnym przypadku wyświetla komunikat 
    o konieczności uzupełnienia wszystkich pól formularza.
    parametry: sender – obiekt wywołujący zdarzenie
               e – dane zdarzenia
    zwracany typ i opis: Brak
    autor: Wiktor
************************************************
***********************************************
    nazwa funkcji: calculatePrice
    opis funkcji: Funkcja oblicza całkowitą cenę wybranego pakietu. 
    Pobiera wybrany pakiet z ViewModelu (Basic, Standard, Premium) 
    i na jego podstawie ustala cenę bazową. Następnie odczytuje 
    liczbę dodatkowych osób z kontrolki Stepper i oblicza koszt 
    dodatkowy (100 zł za osobę). Wynik końcowy jest zapisywany 
    w zmiennej totalPrice oraz wyświetlany w kontrolce Label.
    parametry: sender – obiekt wywołujący zdarzenie
               e – dane zdarzenia
    zwracany typ i opis: Brak
    autor: Wiktor
************************************************
***********************************************
    nazwa funkcji: OnPropertyChanged
    opis funkcji: Funkcja informuje mechanizm powiązań danych 
    (data binding) o zmianie wartości właściwości w ViewModelu. 
    Wywołuje zdarzenie PropertyChanged przekazując nazwę zmienionej 
    właściwości, dzięki czemu interfejs użytkownika może zostać 
    automatycznie zaktualizowany.
    parametry: propertyName – nazwa właściwości, której wartość uległa zmianie
    zwracany typ i opis: Brak
    autor: Wiktor
************************************************
*/
