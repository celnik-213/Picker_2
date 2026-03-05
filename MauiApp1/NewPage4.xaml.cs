namespace MauiApp1;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
        InitializeComponent();
        string[] links = new string[] {
            "https://scontent-waw2-1.xx.fbcdn.net/v/t39.30808-6/607373330_25469869649308012_6305556779473668981_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=13d280&_nc_ohc=z9smJQLLNyAQ7kNvwGCzjDk&_nc_oc=Admp9L8KUpBZ7SUvb2AG5k0Pn8uIkOgqGHwLAyOznZLOX0ZFGEmXuynx8iDSaTLTsO4&_nc_zt=23&_nc_ht=scontent-waw2-1.xx&_nc_gid=SkMwqyK-7pL7FiTJBqS3kw&_nc_ss=8&oh=00_AfzLByN2jDVMJGI3jWN4rP67F647K_523VERZBstsqTQJQ&oe=69AF05C1",
            "https://scontent-waw2-2.xx.fbcdn.net/v/t39.30808-6/605880953_25469957115965932_7087894742365371431_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=13d280&_nc_ohc=d5LZ4jiyRD8Q7kNvwHB5aYB&_nc_oc=AdlxjfBxU1qBKIaW41EpvpXPqulxvHYQBLqgUiYIMUiwC12cBD0UxUrE30odtxfWdPY&_nc_zt=23&_nc_ht=scontent-waw2-2.xx&_nc_gid=GnsxC7pAhdD0hwQrUsBXWw&_nc_ss=8&oh=00_AfyWf8ph2aDeIY4UEklpRQik0Djy4PkG9TITiZJgk9WuFg&oe=69AF1F5D",
            "https://scontent-waw2-2.xx.fbcdn.net/v/t39.30808-6/606011185_25469930465968597_61249660399999879_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=13d280&_nc_ohc=Mw9zgbKNv78Q7kNvwG2l0rc&_nc_oc=AdkKKpMlfs70QhG_gckv4QVuEJGh40OPxxOqnunJGsW3pDgifZZ8zzrI9Jyd62bY_Wc&_nc_zt=23&_nc_ht=scontent-waw2-2.xx&_nc_gid=eLxmEAtJ0sYBjB3GrW8CPQ&_nc_ss=8&oh=00_AfxIFmnXaZlnWrdPMWF1cIjwut-KR0-AFgZ_ArqGJqkoPQ&oe=69AF19C4",
            "https://scontent-waw2-1.xx.fbcdn.net/v/t39.30808-6/606036108_25469888509306126_5049462749974144936_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=13d280&_nc_ohc=zSl-4kBvm_sQ7kNvwHlzbef&_nc_oc=AdnstDbIlrlFDKF7iXlbm2WSA1uDJnysUPs-quIMTdRWkvaY2wDk2-bx4cedRKB50iE&_nc_zt=23&_nc_ht=scontent-waw2-1.xx&_nc_gid=Cxut1cjZk6Rx_dmclkXqBQ&_nc_ss=8&oh=00_Afz9_cjALFIJNBumY1i2UKoIsMBtyr9sJO1SxyNm3sbH5g&oe=69AF0DF2",
            "https://scontent-waw2-2.xx.fbcdn.net/v/t39.30808-6/491424103_9552181928170039_1810100544485762663_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=7b2446&_nc_ohc=7t23SZB7sJAQ7kNvwFJ5DEY&_nc_oc=AdkQ5edZPf2_ma9hrGqVArnk9brPiTpjFmiPpcDiDEXjGLV4ByTzPFql7t_l6O76S1w&_nc_zt=23&_nc_ht=scontent-waw2-2.xx&_nc_gid=B_w0Q-ndxlYIGk_4axlTxA&_nc_ss=8&oh=00_AfwoAEx4npV1nwU67thPtLRDTfAen-ySPPQTJW6qMxRIyQ&oe=69AEF0FA"
        };
        string[] descriptions =
        {
                "Zdjêcie 1 - Sor w Egipcie",
                "Zdjêcie 2 - Sor w Piaskowcu",
                "Zdjêcie 3 - Sor na Budowie",
                "Zdjêcie 4 - Sor w Kapoku stra¿ackim",
                "Zdjêcie 5 - Sor w Górach"
    
        };
        for (int i = 0; i < links.Length; i++)
        {
            int index = i;

            var image = new Image
            {
                Source = new UriImageSource
                {
                    Uri = new Uri(links[i]),
                    CachingEnabled = true,
                    CacheValidity = TimeSpan.FromDays(3)
                },
                Aspect = Aspect.AspectFit,
                HeightRequest = 200,
                WidthRequest = 300
            };

            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                await DisplayAlert("Wybrano obraz", $"Klikn¹³eœ obraz {index + 1}", "OK");
            };

            image.GestureRecognizers.Add(tap);

            var frame = new Frame
            {
                CornerRadius = 15,
                Padding = 0,
                HasShadow = true,
                Content = image
            };

            var label = new Label
            {
                Text = descriptions[i],
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center
            };

            GalleryLayout.Children.Add(frame);
            GalleryLayout.Children.Add(label);
        }
    }
}