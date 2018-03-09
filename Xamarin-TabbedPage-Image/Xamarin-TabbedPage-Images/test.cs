using System;
using Xamarin.Forms;
namespace XamarinTabbedPageImages
{
    public class test : TabbedPage
    {


        public test()
        {
            var image = new Image { Source = "image.jpg" };
            var image2 = new Image { Source = ImageSource.FromResource("XamarinTabbedPageImages.image.jpg") };
            var webImage = new Image { Source = "https://xamarin.com/content/images/pages/forms/example-app.png" };

           

            this.Title = "TabbedPage";
            this.Children.Add(new ContentPage
            {
                Title = "page1",
                Icon = "ic_home",

                Content = new StackLayout
                {
                    Padding = 50,
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                          image
                        }

                }

            });
            this.Children.Add(new ContentPage
            {
                Title = "page2",
                Icon = "ic_collections",
                Content = new StackLayout
                {
                    Padding = 50,
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                       image2
                     }
                }



            });

            this.Children.Add(new ContentPage
            {
                Title = "page3",
                Icon = "ic_description",
                Content = new StackLayout
                {
                    Padding = 50,
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        webImage
                     }
                }



            });

           


        }
    }
}
