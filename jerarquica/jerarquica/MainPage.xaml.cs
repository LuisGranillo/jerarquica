using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jerarquica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await rotation.RotateTo(360, 2000,Easing.BounceOut);
        }

        private void boton1_Clicked(object sender, EventArgs e)
        {
            boton1.ScaleTo(2, 2000, Easing.BounceOut);
        }

        private void boton2_Clicked(object sender, EventArgs e)
        {
            boton2.ScaleTo(2, 2000, Easing.BounceIn);
        }

        private void boton3_Clicked(object sender, EventArgs e)
        {
            boton3.ScaleTo(2, 2000, Easing.CubicIn);
        }

        private void boton4_Clicked(object sender, EventArgs e)
        {
            boton4.ScaleTo(2, 2000, Easing.CubicInOut);
        }

        private void boton5_Clicked(object sender, EventArgs e)
        {
            boton5.ScaleTo(2, 2000, Easing.Linear);
        }

        private void boton6_Clicked(object sender, EventArgs e)
        {
            boton6.ScaleTo(2, 2000, Easing.SinIn);
        }

        private void boton6_Clicked_1(object sender, EventArgs e)
        {

        }

        private void boton7_Clicked(object sender, EventArgs e)
        {
            boton7.ScaleTo(2, 2000, Easing.SinInOut);

        }

        private void Boton8_Clicked(object sender, EventArgs e)
        {
            boton8.ScaleTo(2, 2000, Easing.SinOut);

        }

        private void boton9_Clicked(object sender, EventArgs e)
        {
            boton9.ScaleTo(2, 2000, Easing.SinOut);

        }

        private void boton10_Clicked(object sender, EventArgs e)
        {
            boton10.ScaleTo(2, 2000, Easing.SpringIn);

        }

        private void boton11_Clicked(object sender, EventArgs e)
        {
            boton11.ScaleTo(2, 2000, Easing.SpringOut);

        }

        private void boton12_Clicked(object sender, EventArgs e)
        {
            boton12.ScaleTo(2, 2000, Easing.SinIn);

        }
    }
}
