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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void  Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void rotationx_Clicked(object sender, EventArgs e)
        {
            await rotationx.RotateXTo(360, 2000, Easing.CubicIn);
        }

        private async void rotationy_Clicked(object sender, EventArgs e)
        {
            await rotationy.RotateYTo(360, 2000, Easing.BounceOut);
        }
    }
}