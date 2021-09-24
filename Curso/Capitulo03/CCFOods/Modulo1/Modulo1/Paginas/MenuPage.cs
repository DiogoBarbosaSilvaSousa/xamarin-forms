using Modulo1.Paginas.Garcons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Modulo1.Paginas
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu de Opções";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Button()
                    {
                        Text = "Garçons",
                        Image = "waiter.png",
                        Command = new Command(()=> Navigation.PushAsync(new GarconsPage()))
                    }

                }
            };
        }
    }
}