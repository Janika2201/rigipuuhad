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
    public partial class Uusaasta : ContentPage
    {
        public Uusaasta()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Pip.ScaleTo(2, 2000);
            await Pip.ScaleTo(1, 2000);
        }
    }
}