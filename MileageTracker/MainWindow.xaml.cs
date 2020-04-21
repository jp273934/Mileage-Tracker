﻿using MileageTracker.Repository.Entities;
using MileageTracker.Repository.Repositories;
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

namespace MileageTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MileageRepository _repository;

        public MainWindow()
        {
            InitializeComponent();
            _repository = new MileageRepository();
            LoadGrid();
        }

        private void LoadGrid()
        {
            var mileage = _repository.GetAllMileages();

            MileageGrid.ItemsSource = mileage;
            TotalMilesLabel.Content = mileage.Sum(m => m.Miles) + " miles";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var date = Convert.ToDateTime(DeliveryDateDatePicker.SelectedDate);
            var miles = Convert.ToDouble(MileageTotalTextbox.Text);

            var mileage = new Mileage { DeliveryDate = date, Miles = miles };

            _repository.AddMileageRecord(mileage);

            LoadGrid();
            MessageBox.Show("Hello");

        }
    }
}
