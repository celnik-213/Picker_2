namespace MauiApp1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();

		var Image = new Image
		{
			Source = ImageSource.FromFile("dotnet_bot.png"),
			Aspect = Aspect.AspectFit,
			HeightRequest = 200
		};

		var Image2 = new Image
		{
			Source = new UriImageSource
			{
				Uri = new Uri("https://scontent-waw2-1.xx.fbcdn.net/v/t39.30808-6/606469165_25469967755964868_1245493480733488020_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=13d280&_nc_ohc=nXZvljk_vL0Q7kNvwGS396u&_nc_oc=AdlKntPd4kVQy3BcG7jG12HZX9VBDjQxXWEBYBeL6P0ErrBwUS88IEWLhK1XyjR9IPw&_nc_zt=23&_nc_ht=scontent-waw2-1.xx&_nc_gid=L_Ix5omFINzRLB4mBvUsEg&_nc_ss=8&oh=00_Afywm2277LhD-1DhUFedmAM3ox5Q5qphw2WUB_AsCmBr8g&oe=69AC8DE6"),
				CacheValidity = TimeSpan.FromDays(7),
			},
			Aspect = Aspect.AspectFit,
			HeightRequest = 200
		};
		Zdjecia.Children.Add(Image);
		Zdjecia.Children.Add(Image2);
    }
    void OnOsiolClicked(object sender, EventArgs e)
    {
        if (Shrekgif.Aspect == Aspect.AspectFit)
        {
            Shrekgif.Aspect = Aspect.Fill;
        }
        else if (Shrekgif.Aspect == Aspect.Fill)
        {
            Shrekgif.Aspect = Aspect.AspectFill;
        }
        else if (Shrekgif.Aspect == Aspect.AspectFill)
        {
            Shrekgif.Aspect = Aspect.AspectFit;
        }
        AspectLabel.Text = $"Aktualny tryb wyœwietlania: {Shrekgif.Aspect}";
    }
}
/*
***********************************************
    nazwa funkcji: OnOsiolClicek
    opis funkcji: Funckaj obsługuje zmianę wartości Aspect pomiędzy Aspect.Fill Aspect.AspectFill oraz Aspect.AspectFit po naciśnięciu na zdjęcie.
    parametry: Brak
    zwracany typ i opis: Brak
    autor: Wiktor
************************************************
*/
