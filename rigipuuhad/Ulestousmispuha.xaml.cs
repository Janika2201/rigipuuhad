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
    public partial class Ulestousmispuha : ContentPage
    {
        public Ulestousmispuha()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await img.TranslateTo(0, 200, 2000, Easing.BounceIn);
            await img.ScaleTo(2, 2000, Easing.CubicIn);
            await img.RotateTo(360, 2000, Easing.SinInOut);
            await img.ScaleTo(1,2000, Easing.CubicIn);
            await img.TranslateTo(0, 0, 2000, Easing.BounceIn);
        }
    }
}