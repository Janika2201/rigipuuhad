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
    public partial class Iseseisvuspaev : ContentPage
    {
        public Iseseisvuspaev()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            img.Opacity = 0;
            await img.FadeTo(1, 4000);
        }
    }
}