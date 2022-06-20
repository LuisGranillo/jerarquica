using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jerarquica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void translation_Clicked(object sender, EventArgs e)
        {
            await translation.TranslateTo(26,-26,250,Easing.SpringOut);
           
        }

        private   void translationy_Clicked(object sender, EventArgs e)
        {
        }

        private async void translation2_Clicked(object sender, EventArgs e)
        {
            await translationarriba.TranslateTo(50, 100, 250, Easing.CubicInOut);
        }
    }
}