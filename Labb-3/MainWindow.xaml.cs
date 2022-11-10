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
        public int TableNumber { get; }
        public int Time { get; }
        public int Date { get; }

        public MainWindow()
        {
            InitializeComponent();

            Bookings = new List<Booking>();

            for (int iterator = 1; iterator <= 3; iterator++)
            {
                var booking = new Booking("Name" + Convert.ToString(iterator), 1, new DateTime(2022, 11, 11), Convert.ToString(16 + iterator) + ":00");

                Bookings.Add(booking);
            }
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
            try
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
            catch (Exception MissingInputData)
            {
                //MessageBox.Show(MissingInputData.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("Alla fält måste vara ifyllda för att göra en bokningsförfrågan", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnShowBookings_Click(object sender, RoutedEventArgs e)
        {
            lstboxListBookings.Items.Clear();

            foreach (var booking in Bookings)
            {
                lstboxListBookings.Items.Add(booking);
            }
        }


        private void btnCancelBooking_Click(object sender, RoutedEventArgs e)
        {
            var booking = (Booking) lstboxListBookings.SelectedItem;

            if (booking != null)
            {
                Bookings.Remove(booking);
                MessageBox.Show("Booking cancelled");

                //    lstboxListBookings.Items.Clear();

                //    foreach (var allbookings in Bookings)
                //    {
                //        lstboxListBookings.Items.Add(booking);
                //    }
            }
            else MessageBox.Show("Välj en bokning");
        }
    }
}
