using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rigipuuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nelipuhade : ContentPage
    {
        public Nelipuhade()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            img.Opacity = 0;
            await img.FadeTo(1, 4000);
        }
    }
}