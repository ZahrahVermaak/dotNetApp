using dotNetApp.Models;
using dotNetApp.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderingPage : ContentPage
    {

        
        public OrderingPage()
        {
            InitializeComponent();

            BindingContext = new OrderItem();
        }

        private async void OrderButton_Clicked(object sender, EventArgs e)
        {

            OrderItem dbOrder = (OrderItem) BindingContext;

            dotNetDatabase db =  dotNetDatabase.Instance;

            dbOrder.OrderDate = DateTime.Now;
  

            db.SavedOrder(dbOrder);
            // await Navigation.PushAsync(new History());

            await DisplayAlert("Orders", "Your Order Has Been Saved. Thank You!.", "Ok");
           

        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /*protected async override void OnAppearing()
        {
            base.OnAppearing();

            dotNet dot = await GetOrder();

            BindingContext = dot;

            dotNetDatabase db = dotNetDatabase.Instance();

            Models.dotNet dbOrder = new Models.dotNet();
            dbOrder.OrderDate = DateTime.Now;
            dbOrder.OrderDate = Order.order;

            db.SavedOrders(dbOrder);

            //return
        
        
           
        }*/
    }
}