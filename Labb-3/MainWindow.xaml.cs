using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace Labb_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Booking> Bookings { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Bookings = new List<Booking>();
        }

        private void btnbook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowBookings_Click(object sender, RoutedEventArgs e)
        {
            foreach (var Booking in Bookings)
            {

            }
        }

        private void btnCancelBooking_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Booking
    {
        public int TableNumber { get; set; }
        public DateTime Date { get; set; }
        public Booking (int tablenNumber, DateTime datetime)
        {
            TableNumber = tablenNumber;
            Date = datetime;
        }
    }
}
