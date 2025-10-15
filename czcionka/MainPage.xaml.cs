using System.Runtime.CompilerServices;

namespace czcionka
{
    public partial class MainPage : ContentPage
    {
        int quoteIndex = 0;


        readonly string[] quotes = { "Dzień dobry", "Good morning", "Buenos dias" };

        public MainPage()
        {
            InitializeComponent();


            SizeValueLabel.Text = SizeSlider.Value.ToString("F0");
            QuoteLabel.FontSize = SizeSlider.Value;
        }

       
        private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        {
            
            int integerValue = (int)Math.Round(e.NewValue);

            
            SizeValueLabel.Text = integerValue.ToString();

            
            QuoteLabel.FontSize = integerValue;
        }


        private void OnSliderValueChanged1(object? sender, ValueChangedEventArgs e)
        {
            int b = (int)e.NewValue;
            ColorLabel.TextColor = Color.FromRgb(b, 255 - b, (b / 2));

        }


        private void OnChangeTextClicked(object? sender, EventArgs e)
        {
            
            quoteIndex++;

           
            if (quoteIndex >= quotes.Length)
            {
                quoteIndex = 0;
            }

           
            QuoteLabel.Text = quotes[quoteIndex];

           
            ChangeTextBtn.Text = ">>";
        }
    }
}