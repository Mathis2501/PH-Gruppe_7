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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PrettyHair.Business;
using DomainLayer;

namespace GuiLayer.Views
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : UserControl
    {
        BusinessFacade Controler;
        public ProductsView()
        {
            Controler = BusinessFacade.GetInstance;
            InitializeComponent();

            List<Product> Liste = Controler.ShowProduct();
            dataGrid.ItemsSource = Liste;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddProduct AddProd = new AddProduct();
            AddProd.ShowDialog();
        }
    }
}
