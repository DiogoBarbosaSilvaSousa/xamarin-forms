using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Modulo1.Paginas.Garcons
{
    public class GarconsListPage : ContentPage
    {
        public GarconsListPage()
        {
            Content = GetGarcons();
        }

        private  ListView GetGarcons()
        {
            var garcons = new ListView();
            garcons.ItemsSource = new string[] {
             "Brauzio",  "Asdrugio", "Entencius", "Gesfredio", "Cartucious",  "Gesfrundio",   "Adoliterio",   "Kentencio",  "Castrogildo", "Gesifrelio"
            };

            return garcons;
        }
    }
}
