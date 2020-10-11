using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace snegovik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public object Yellow { get; private set; }
        public object Green { get; private set; }
        public bool vkl { get; private set; }

        private async void On_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
            bool vkl = true;
            while (vkl != false)
            {
                h.BackgroundColor = Color.Red;
                bb.BackgroundColor = Color.Green;
                f.BackgroundColor = Color.Purple;
                await Task.Run(() => System.Threading.Thread.Sleep(5));
                for (int i = 0; i < 3; i++)
                {
                    h.BackgroundColor = Color.Orange;
                    bb.BackgroundColor = Color.Red;
                    f.BackgroundColor = Color.Yellow;
                    await Task.Run(() => System.Threading.Thread.Sleep(5));
                }

                h.BackgroundColor = Color.Green;
                bb.BackgroundColor = Color.Purple;
                f.BackgroundColor = Color.Red;
                await Task.Run(() => System.Threading.Thread.Sleep(5));

            }



        }
        private async void Off_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");

            h.Opacity = 0;
            bb.Opacity = 0;
            f.Opacity = 0;
            vkl = false;

        }


        Random rnd = new Random();
        private async void Ran_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");

            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            h.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            bb.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            f.BackgroundColor = Color.FromRgb(r, g, b);

        }
        private async void Ras_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");

            bool vkl = true;
            while (vkl != false)
            {
                h.Opacity = 0;
                bb.BackgroundColor = Color.Aqua;
                f.BackgroundColor = Color.Aqua;
                await Task.Run(() => System.Threading.Thread.Sleep(500));
                for (int i = 0; i < 3; i++)
                {
                    h.Opacity = 0;
                    bb.Opacity = 0;
                    f.BackgroundColor = Color.Aqua;
                    await Task.Run(() => System.Threading.Thread.Sleep(500));
                }

                h.Opacity = 0;
                bb.Opacity = 0;
                f.Opacity = 0;
                await Task.Run(() => System.Threading.Thread.Sleep(500));


            }



        }


        private async void qq_Clicked_1(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
            h.Opacity = 1;
            bb.Opacity = 1;
            f.Opacity = 1;
            vkl = false;


        }
    }
}