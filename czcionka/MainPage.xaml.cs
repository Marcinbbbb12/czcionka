namespace czcionka
{
    public partial class MainPage : ContentPage
    {
        // Indeks śledzący, który cytat jest obecnie wyświetlany
        int quoteIndex = 0;

        // Tablica dostępnych cytatów
        readonly string[] quotes = { "Dzień dobry", "Good morning", "Buenos dias" };

        public MainPage()
        {
            InitializeComponent();

            // Ustawienie początkowego rozmiaru i wartości etykiety przy starcie aplikacji
            // (Zapewnienie działania funkcji suwaka dla stanu początkowego)
            SizeValueLabel.Text = SizeSlider.Value.ToString("F0");
            QuoteLabel.FontSize = SizeSlider.Value;
        }

       
        private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        {
            
            int integerValue = (int)Math.Round(e.NewValue);

            
            SizeValueLabel.Text = integerValue.ToString();

            
            QuoteLabel.FontSize = integerValue;
        }

        
        private void OnChangeTextClicked(object? sender, EventArgs e)
        {
            
            quoteIndex++;

           
            if (quoteIndex >= quotes.Length)
            {
                quoteIndex = 0;
            }

           
            QuoteLabel.Text = quotes[quoteIndex];

           
            ChangeTextBtn.Text = "Zmień tekst";
        }
    }
}