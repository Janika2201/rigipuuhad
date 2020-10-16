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
    public partial class Joululaupaev : ContentPage
    {
        public Joululaupaev()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}