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
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        BusinessFacade Controler;
        public CustomerView()
        {
            Controler = BusinessFacade.GetInstance;
            InitializeComponent();

            List<Customer> Liste = Controler.ShowCustomer();
            dataGrid.ItemsSource = Liste;
        }

   /*     private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchWord = txtSearch.Text;

            try
            {
                foreach (DataGridRow row in dataGrid.Items)
                {

                    row.IsSelected = false;
                    if
                        (row.
                        Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[1].Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[2].Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[3].Value.ToString().ToLower().Contains(searchWord.ToLower()))
                    {
                        row.IsSelected = true;
                    }
                }
            }
            catch (Exception)
            { }
        }*/
    }
}
