using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DomainLayer;
using PrettyHair.Business;

namespace GuiLayer.Views
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        private BusinessFacade Controller;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int i;
            double d;
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxPrice.Text) && !string.IsNullOrEmpty(textBoxDescription.Text) && !string.IsNullOrEmpty(textBoxAmount.Text))
            {
                if (int.TryParse(textBoxAmount.Text, out i) && double.TryParse(textBoxPrice.Text, out d))
                {
                    Product Prod = new Product(textBoxName.Text, d, textBoxDescription.Text, i);
                    Controller.SaveProduct(Prod);
                    this.Hide();
                }
            }
        }
    }
}
