using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoomReservationSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Creating an object of WCF service client
        ServiceReference.RoomReservationServiceClient reservationServiceClient = new ServiceReference.RoomReservationServiceClient();

        public MainWindow()
        {
            InitializeComponent();
            datePickercheckIn.DisplayDateStart = DateTime.Now;
            datePickercheckOut.DisplayDateStart = DateTime.Now;

            // populate the room types combobox
            BindingSource bs = new BindingSource();
            bs.DataSource = reservationServiceClient.GetRoomTypes();
            comboRoomTypes.ItemsSource = bs;
            comboRoomTypes.SelectedIndex = 0;

            // populate the user email addresses combobox
            List<string> emails = new List<string>();
            foreach (ServiceReference.User user in reservationServiceClient.GetUsers())
            {
                emails.Add(user.UserId);
            }
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = emails;
            comboUserEmails.ItemsSource = bs2;
            comboUserEmails.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            String response = reservationServiceClient.RegisterUser(email, name, phone, address);
            lblResponse.Content = response;

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void btnSearchRooms_Click(object sender, RoutedEventArgs e)
        {
            String roomType = comboRoomTypes.Text;
            DateTime checkIn;
            DateTime checkOut;

            if (datePickercheckIn.SelectedDate.HasValue && datePickercheckOut.SelectedDate.HasValue)
            {
                checkIn = datePickercheckIn.SelectedDate.Value;
                checkOut = datePickercheckOut.SelectedDate.Value;
                ServiceReference.Room[] room = reservationServiceClient.GetAvailableRooms(roomType, checkIn, checkOut);

                // attach room item source to the listBox
                listBoxRooms.ItemsSource = room;

            }
            else
            {   // ask to provide valid inputs
            }

        }

        void btnClick(object sender, RoutedEventArgs e)
        {
            comboAdults.SelectedIndex = 0;
            comboChildren.SelectedIndex = 0;
            popupReservation.IsOpen = true;
           

           
        }

        private void btnSubmitReservation_Click(object sender, RoutedEventArgs e)
        {
            //string roomNo =  
            int adults = int.Parse(comboAdults.Text);
            int children = int.Parse(comboChildren.Text);
            //double reservationCost
            string userEmail = comboUserEmails.Text;
            //DateTime checkIn = datePickercheckIn.SelectedDate.Value;
            //DateTime checkOut = datePickercheckOut.SelectedDate.Value;

            // reservationServiceClient.ReserveRoom
        }

        private void btnCancelReservation_Click(object sender, RoutedEventArgs e)
        {
            popupReservation.IsOpen = false;
        }
    }
}
