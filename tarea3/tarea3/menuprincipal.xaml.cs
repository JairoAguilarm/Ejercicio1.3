using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menuprincipal : ContentPage
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private async void toolmenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage()); 


        }

        private async void liestapersonas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var per = (personas)e.Item;
            MainPage page = new MainPage();
            page.BindingContext = per;
            await Navigation.PushAsync(page);   
           // await DisplayAlert("Aviso", "La persona que selecciono es: " + per.nombre +" " +per.apellido,"Ok");
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listapersonas.ItemsSource = await App.dbpersona.obtnerlistapersonas();
        }
    }
}