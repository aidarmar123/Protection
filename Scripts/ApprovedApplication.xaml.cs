using ProtectionApp.Classes;
using ProtectionApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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


namespace ProtectionApp.Scripts
{
    /// <summary>
    /// Логика взаимодействия для ApprovedApplication.xaml
    /// </summary>
    public partial class ApprovedApplication : Page
    {
        
        public ApprovedApplication()
        {
            
            InitializeComponent();

            Refresh();
        }

       

        private void BEntry_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (DGApprovedApplication.SelectedItem is User user)
            {
              
                if (user.TimeEntry == null)
                {
                    
                    System.Media.SystemSounds.Beep.Play();
                    App.DB.User.FirstOrDefault(x => x.id == user.id).TimeEntry = DateTime.Now;
                    try
                    {
                        App.DB.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Data not save");
                    }
                   
                }
                else if (user.TimeEntry != null)
                {
                    
                    System.Media.SystemSounds.Beep.Play();
                    App.DB.User.FirstOrDefault(x => x.id == user.id).TimeExit = DateTime.Now;
                    try
                    {
                        App.DB.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Data not save");
                    };

                }
                else
                {
                    MessageBox.Show("User not selected");
                }
                Refresh();
            }
        }

        private void Refresh()
        {
            List<User> NewListUsers = new List<User>();
            List<User> ListUsers = App.DB.User.ToList();
            for (int i = 0; i < ListUsers.Count; i++)
            {
                if (ListUsers[i].StateId == 1 & ListUsers[i].TimeExit == null)
                {
                    NewListUsers.Add(ListUsers[i]);

                }

            }

            DGApprovedApplication.ItemsSource = NewListUsers;
        }

        private void BGoBack_Click(object sender, RoutedEventArgs e)
        {
            Maneger.MainFrame.GoBack();
        }

       
    }
}
