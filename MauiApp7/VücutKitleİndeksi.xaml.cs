namespace MauiApp7;

public partial class VücutKitleİndeksi : ContentPage
{
    public VücutKitleİndeksi()
    {
        InitializeComponent();
    }
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {

        double weight = WeightSlider.Value;
        double height = HeightSlider.Value;


        double bmi = weight / (height * height);


        ResultLabel.Text = $"Vücut Kitle İndeksi: {bmi:F2}";

        string category = "";
        if (bmi < 16)
        {
            category = "İleri düzeyde zayıf";
        }
        else if (bmi >= 16 && bmi < 17)
        {
            category = "Orta düzeyde zayıf";
        }
        else if (bmi >= 17 && bmi < 18.5)
        {
            category = "Hafif düzeyde zayıf";
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            category = "Normal kilolu";
        }
        else if (bmi >= 25 && bmi < 30)
        {
            category = "Hafif şişman / Fazla kilolu";
        }
        else if (bmi >= 30 && bmi < 35)
        {
            category = "1. Derecede obez";
        }
        else if (bmi >= 35 && bmi < 40)
        {
            category = "2. Derecede obez";
        }
        else
        {
            category = "3. Derecede obez / Morbid obez";
        }


        VkiCategoryValueLabel.Text = category;
    }
}