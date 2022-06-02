using dotNetApp.Models;
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
    public partial class History : ContentPage
    {
        public History()
        {
            InitializeComponent();
        }

        private List<OrderItem> _order;

        public List<OrderItem> Order
        {
            get { return _order; }
            set
            {
                _order = value;

                OnPropertyChanged();
            }
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            dotNetDatabase db = dotNetDatabase.Instance;

            Order = db.GetOrders();

            BindingContext = this;
        }

    }
}