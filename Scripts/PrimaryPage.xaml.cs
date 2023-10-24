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
using System.Data.Entity.ModelConfiguration.Conventions;

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
                App.DB.User.Remove(user);
                Maneger.MainFrame.Navigate(new EditPage(user));
                
            }
        }

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {

            List<User> ListUsers = new List<User>();
            List<User> NewUser = App.DB.User.ToList();
            if (TBSearch.Text != "" | DPSourseDate.SelectedDate != null)
            {
                string inputText = TBSearch.Text.ToLower().Replace(" ", "");
                if (TBSearch.Text != "" && DPSourseDate.SelectedDate != null)
                {
                   
                    ListUsers = new List<User>();
                    for (int i = 0; i < NewUser.Count; i++)
                    {
                        string userText = (NewUser[i].Name + NewUser[i].Sename + NewUser[i].Surname).ToLower().Replace(" ", "");
                       
                        if (userText == inputText & NewUser[i].Date==DPSourseDate.SelectedDate)
                        {
                            ListUsers.Add(NewUser[i]);
                        };
                    }; 
                    if (ListUsers.Count==0)
                    {
                        for (int i = 0; i < NewUser.Count; i++)
                        {
                            if(NewUser[i].Name == TBSearch.Text || NewUser[i].Surname == TBSearch.Text || NewUser[i].Sename == TBSearch.Text)
                            {
                                if (DPSourseDate.SelectedDate == NewUser[i].Date)
                                {
                                    ListUsers.Add(NewUser[i]);
                                }
                            };
                        };
                    };
                };
                if (TBSearch.Text != "" && DPSourseDate.SelectedDate==null)
                {
                    ListUsers = new List<User>();
                    for (int i = 0; i < NewUser.Count; i++)
                    {
                        string userText = (NewUser[i].Name + NewUser[i].Sename + NewUser[i].Surname).ToLower().Replace(" ", "");
                        
                        if (userText == inputText)
                        {
                            ListUsers.Add(NewUser[i]);
                        };
                    };
                    if (ListUsers.Count == 0)
                    {
                        for (int i = 0; i < NewUser.Count; i++)
                        {
                            if (NewUser[i].Name == TBSearch.Text || NewUser[i].Surname == TBSearch.Text || NewUser[i].Sename == TBSearch.Text)
                            {
                                ListUsers.Add(NewUser[i]);
                            };
                        };
                    };
                };

                if (DPSourseDate.SelectedDate != null && TBSearch.Text =="")
                {
                    ListUsers = new List<User>();
                    for (int i = 0; i < NewUser.Count; i++)
                    {
                        if (NewUser[i].Date == DPSourseDate.SelectedDate)
                        {
                            ListUsers.Add(NewUser[i]);
                        }
                    }
                };

                if (ListUsers.Count>0 )
                {
                    DGAllApplication.ItemsSource = ListUsers;
                    BGoBack.Visibility = Visibility;
                }
                else
                {
                    MessageBox.Show("User not founted");
                 
                }
            }
            else
            {
                MessageBox.Show("Line is null");
            }
        }


        private void BGoBack_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            TBSearch.Text = "";
            DPSourseDate.SelectedDate = null;
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
