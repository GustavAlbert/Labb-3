using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using MyClasses_Labb3;

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
            var booking =   new Booking
                            (txtCustommerName.Text, 
                            Convert.ToInt32(ComboBoxTablenumber.Text), 
                            dtpSelecter.SelectedDate.Value, 
                            ComboBoxTime.Text);

            Bookings.Add(booking);
        }

        private void btnShowBookings_Click(object sender, RoutedEventArgs e)
        {
            foreach (var Booking in Bookings)
            {
                lstboxListBookings.Items.Add
                ("Namn; " + Booking.Name + 
                " Datum; " + Booking.Date.ToShortDateString() + " Klockan " + Booking.Time + 
                " Bord " + Booking.TableNumber);
            }
        }

        private void btnCancelBooking_Click(object sender, RoutedEventArgs e)
        {

        }
    }



    //public class Booking
    //{
    //    public string Name { get; set; }
    //    public int TableNumber { get; set; }
    //    public DateTime Date { get; set; }
    //    public Booking (string name, int tablenNumber, DateTime datetime)
    //    {
    //        Name = name;
    //        TableNumber = tablenNumber;
    //        Date = datetime;
    //    }
    //    public string ListBookings()
    //    {
            
    //    }
    //}
}
