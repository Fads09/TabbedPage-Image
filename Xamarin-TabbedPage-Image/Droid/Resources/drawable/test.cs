using System;
using Xamarin.Forms;
namespace XamarinTabbedPageImages
{
    public class test : TabbedPage
    {


        public test()
        {
            var image = new Image { Source = "image.jpg" };
            var image2 = new Image { Source = ImageSource.FromResource("test1.image.jpg") };
            var image3 = new Image { Source = " https://i2.wp.com/programmingwithmosh.com/wp-content/uploads/2016/08/Xamarin-logo.png" };
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
                            image3
                    }

                }

            });


        }
    }
}
