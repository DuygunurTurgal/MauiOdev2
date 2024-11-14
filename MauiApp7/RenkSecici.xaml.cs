namespace MauiApp7;

public partial class RenkSecici : ContentPage
{
    public RenkSecici()
    {
        InitializeComponent();
    }

    private void OnColorSliderChanged(object sender, ValueChangedEventArgs e)
    {

        UpdateColorPreview();
    }

    private void UpdateColorPreview()
    {

        int red = (int)RedSlider.Value;
        int green = (int)GreenSlider.Value;
        int blue = (int)BlueSlider.Value;


        Color color = Color.FromRgb(red, green, blue);


        ColorPreview.Color = color;


        ColorCodeLabel.Text = $"Renk Kodu: #{red:X2}{green:X2}{blue:X2}";
    }

    private void OnRandomColorButtonClicked(object sender, EventArgs e)
    {

        Random random = new Random();
        int red = random.Next(0, 256);
        int green = random.Next(0, 256);
        int blue = random.Next(0, 256);


        RedSlider.Value = red;
        GreenSlider.Value = green;
        BlueSlider.Value = blue;


        UpdateColorPreview();
    }
}