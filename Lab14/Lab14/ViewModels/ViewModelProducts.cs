using Lab14.Model;
using Lab14.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab14.ViewModels
{
    public class ViewModelProducts : ViewModelBase
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Product> products;
        public List<Product> Products
        {
            get { return this.products; }
            set { SetValue(ref this.products, value); }
        }

        public ICommand SearchCommand { get; set; }

        public ViewModelProducts()
        {

            SearchCommand = new Command(() =>
            {
                ProductService service = new ProductService();
                Products = service.GetByText(Filter);
                if (Products.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }


    }
}
