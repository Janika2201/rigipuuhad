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
    public partial class Taasiseseisvumispaev : ContentPage
    {
        public Taasiseseisvumispaev()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double r = Math.Min(stek.Width, stek.Height) / 2;
            img.AnchorY = r / img.Height;
            await img.RotateTo(360, 1000);
        }
    }
}