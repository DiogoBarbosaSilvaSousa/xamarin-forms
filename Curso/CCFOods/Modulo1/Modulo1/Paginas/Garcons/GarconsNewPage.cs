using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Modulo1.Paginas.Garcons
{
    public class GarconsNewPage : ContentPage
    {
        public GarconsNewPage()
        {
            Content = new StackLayout { Children = { new Label { Text = "Hello ContentPage" } } };
        }

    }
}
