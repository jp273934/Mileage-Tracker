using MileageTracker.Repository.Entities;
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
        public MainWindow()
        {
            InitializeComponent();

            var mileage = new List<Mileage>
            {
                new Mileage{ DeliveryDate = DateTime.Today, Miles = 1.0},
                new Mileage{ DeliveryDate = DateTime.Today, Miles = 3.0}
            };

            MileageGrid.ItemsSource = mileage;
        }
    }
}
