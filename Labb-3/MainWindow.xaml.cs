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

            //Bookings.Add();
            //Bookings.Add();
            //Bookings.Add();

            //Bookings.

        }

        private bool isTableAvailable(int tableNumber, DateTime timeSlot)
        {
            foreach (var booking in Bookings)
            {
                if (booking.Date == timeSlot && booking.TableNumber == tableNumber)
                {
                    return false;
                }
            }
            return true;
        }


        private void btnbook_Click(object sender, RoutedEventArgs e)
        {
            var timeSlot = dtpSelecter.SelectedDate.Value;

            bool ifTableAvailable = isTableAvailable(Int32.Parse(ComboBoxTablenumber.Text), timeSlot);

            if (ifTableAvailable)
            {
                var presentBooking = new Booking
                                (txtCustommerName.Text,
                                Convert.ToInt32(ComboBoxTablenumber.Text),
                                dtpSelecter.SelectedDate.Value,
                                ComboBoxTime.Text);

                Bookings.Add(presentBooking);

                MessageBox.Show("Ditt bord har reserverats, hoppas du får en trevlig sittning");

            }
            else
            {
                MessageBox.Show("Inga bord är tillgängliga vid " + ComboBoxTime.Text + ", välj en annan tid");
            }
        }


        private void btnShowBookings_Click(object sender, RoutedEventArgs e)
        {
            lstboxListBookings.Items.Clear();

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
            lstboxListBookings.Items.Remove(lstboxListBookings.SelectedItem.ToString);
        }
    }
}
