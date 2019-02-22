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
using System.IO;
using Microsoft.Win32;


namespace WPFUserRegSytem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        Class1 kc;
        public MainWindow()
        {
            InitializeComponent();
            kc = new Class1();
            //sexDropDown();
            ////foreach (var item in comboBoxDataSource)
            //{
            //    combo1.Items.Add(item);
            //}
        }

        private void ViewProfile_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
               
        //public void sexDropDown()
        //{
        //    comboBoxDataSource.Add("Male");
        //    comboBoxDataSource.Add("Female");

        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select an image from your computer";
            ofd.Filter = "All Support image image|*.jpeg;*.jpg;*.png";
            if (ofd.ShowDialog() == true)
            {
                Images.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kc.Name = Username.Text;
            //kc.Password = passwordBox.Password;
            kc.Age = DateTime.Now.Year - DatePic.SelectedDate.Value.Year;
            //kc.Sex = combo1.Text;
            kc.Picturepath = Images.Source.ToString();
            kc.Phone = phoneNumber.Text;
            if (chADVENTURE.IsChecked == true)
            {
                kc.Genre[0] = "Adventure";
            }
            //if (chHORROR.IsChecked == true)
            //{
            //    kc.Genre[1] = "Horror";
            //}
            if (chSCFI.IsChecked == true)
            {
                kc.Genre[2] = "SCFI";
            }
            if (six.IsChecked == true)
            {
                kc.AgeRange = "0-6";
            }
            if (sevenToTwelve.IsChecked == true)
            {
                kc.AgeRange = "7-12";
            }
            if (eighteen.IsChecked == true)
            {
                kc.AgeRange = "18+";
            }
            //MessageBox.Show(combo1.Text);
            kc.saveData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Please enter your username");
            string username = mbr.ToString();
            //User mc = new User(); how it should be done properly call another object
            string[] sr = File.ReadAllLines("UserData.csv");// new array reading filepath csv, each line being an array
            string[] str = sr[0].Split(',');// another array where we can 
            Username.Text = str[0];
            {

            }

        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
