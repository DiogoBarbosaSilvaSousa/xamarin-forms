using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace Modulo1.Paginas.Garcons
{
    public class GarconsPage : TabbedPage
    {
        public GarconsPage()
        {
            Children.Add(new GarconsListPage() { 
                Title = "Listagem",
                Icon = "waiter.png"
            });

            Children.Add(new GarconsNewPage()
            {
                Title = "Inserir Novo",
                Icon = "label_black_new.png"
            });
        }
    }
}
