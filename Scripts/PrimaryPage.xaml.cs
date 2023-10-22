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
using ProtectionApp.Models;
using ProtectionApp.Classes;

namespace ProtectionApp.Scripts
{
    /// <summary>
    /// Логика взаимодействия для PrimaryPage.xaml
    /// </summary>
    public partial class PrimaryPage : Page
    {
        public PrimaryPage()
        {

            InitializeComponent();
            DGAllApplication.ItemsSource = App.DB.User.ToList();
           

        }

        private void BWatchApplication_Click(object sender, RoutedEventArgs e)
        {
            Maneger.MainFrame.Navigate(new ApprovedApplication());
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            if (DGAllApplication.SelectedItem is User user)
            { 
                Maneger.MainFrame.Navigate(new EditPage(user));
            }
        }

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {

            List<User> NewUser = new List<User>();
            StringBuilder erors = new StringBuilder();
            if (TBSearch.Text == null)
            {
                erors.Append("Line is null");
            }
            else if (App.DB.User.FirstOrDefault(x => x.Name == TBSearch.Text || x.Sename == TBSearch.Text || x.Surname== TBSearch.Text) != null)
            {
                List<User> ListUsers = App.DB.User.ToList();
                for (int i = 0; i < ListUsers.Count; i++)
                {
                    if (ListUsers[i].Name == TBSearch.Text|| ListUsers[i].Surname== TBSearch.Text|| ListUsers[i].Sename== TBSearch.Text)
                    {
                        NewUser.Add(ListUsers[i]);
                    }
                }
                DGAllApplication.ItemsSource = NewUser;
                BGoBack.Visibility = Visibility;

            }
            else
            {
                erors.Append("User is not found");
            }
            if (erors.Length > 1)
            {
                MessageBox.Show(erors.ToString());
            }
        }


        private void BGoBack_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            BGoBack.Visibility = Visibility.Hidden;
        }
       

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            DGAllApplication.ItemsSource = App.DB.User.ToList();
        }

        private void BEAdd_Click(object sender, RoutedEventArgs e)
        {
            Maneger.MainFrame.Navigate(new EditPage(null));
        }
    }
}
