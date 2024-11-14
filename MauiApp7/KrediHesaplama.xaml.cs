using System;

namespace MauiApp7
{
    public partial class KrediHesaplama : ContentPage
    {
        public KrediHesaplama()
        {
            InitializeComponent();
        }

        private void HesaplaButton_Clicked(object sender, EventArgs e)
        {
            double anapara = double.Parse(KrediTutarEntry.Text);
            double oran = double.Parse(FaizOraniEntry.Text);
            int vade = int.Parse(VadeEntry.Text);


            double KKDF = 0;
            double BSMV = 0;


            switch (KrediTuruPicker.SelectedItem as string)
            {
                case "İhtiyaç Kredisi":
                    KKDF = 0.15;
                    BSMV = 0.18;
                    break;
                case "Konut Kredisi":
                    KKDF = 0.0;
                    BSMV = 0.0;
                    break;
                case "Taşıt Kredisi":
                    KKDF = 0.15;
                    BSMV = 0.05;
                    break;
                case "Ticari Kredi":
                    KKDF = 0.0;
                    BSMV = 0.05;
                    break;
            }


            double brutFaiz = (oran + (oran * BSMV) + (oran * KKDF)) / 100;


            double taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) /
                             (Math.Pow(1 + brutFaiz, vade) - 1)) * anapara;


            TaksitLabel.Text = $"Aylık Taksit: {taksit:C2}";
        }
    }
}