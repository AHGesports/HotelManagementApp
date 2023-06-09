﻿using HotelAppClassLibrary.Databases;
using HotelAppClassLibrary.Models;
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
using Microsoft.Extensions.Configuration.UserSecrets;


namespace Hotel.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDatabaseData _db;
        public MainWindow(IDatabaseData db)
        {
            InitializeComponent();
            _db = db;
            
        }

        private void LastNameButton_Click(object sender, RoutedEventArgs e)
        {

           List<FullBookingModel> bookings = _db.SearchForBookings(LastNameBox.Text);        

           BookingsList.ItemsSource = bookings;
                

        }
    }
}
