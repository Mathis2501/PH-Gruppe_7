﻿using System;
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
using DomainLayer;
using PrettyHair.Business;

namespace GuiLayer.Views
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : UserControl
    {
        BusinessFacade Controler;
        public OrderView()
        {
            InitializeComponent();
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        //private void Refresh()
        //{
        //    List<Order> Liste = Controler.ShowOrders();
        //    dataGrid.ItemsSource = Liste;
        //}
    }
}
