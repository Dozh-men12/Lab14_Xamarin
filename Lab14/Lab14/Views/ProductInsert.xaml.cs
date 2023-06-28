using Lab14.Model;
using Lab14.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductInsert : ContentPage
    {
        public ProductInsert()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            List<Product> products = new List<Product>();

            for (int i = 0; i < 3; i++)
                products.Add(new Product { });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(products);


        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            lvPr.ItemsSource = service.Get();
        }
    }
}