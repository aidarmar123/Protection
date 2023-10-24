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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProtectionApp.Classes;
using ProtectionApp.Models;

namespace ProtectionApp.Scripts
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public User newUser = new User();
        bool IsEdit = false;
        public EditPage(User selectedUser)
        {
            InitializeComponent();
            
            State.ItemsSource = App.DB.State.ToList();
            if (selectedUser != null)
            {
                IsEdit = true;
                newUser = selectedUser;
                TBName.Text = newUser.Name;
                TBSename.Text = newUser.Sename;
                TBSurname.Text = newUser.Surname;
                TBVisitPurpose.Text = newUser.VisitPurpose;
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {

            if (App.DB.User.FirstOrDefault(x => x.id == newUser.id) == null)
            {
                newUser.VisitPurpose = TBVisitPurpose.Text;
            }
            else
            {
                App.DB.User.FirstOrDefault(x => x.id == newUser.id).VisitPurpose = TBVisitPurpose.Text;
            }

            if (State.SelectedItem != null)
            {
                if (App.DB.User.FirstOrDefault(x => x.id == newUser.id) == null)
                {
                    newUser.StateId = State.SelectedIndex+1 ;
                }
                else
                {
                    App.DB.User.FirstOrDefault(x => x.id == newUser.id).StateId = State.SelectedIndex + 1;
                };
            }
            else if (TBName.Text != "")
            {
                if (App.DB.User.FirstOrDefault(x => x.id == newUser.id) == null)
                {
                    newUser.Name = TBName.Text;
                }
                else
                {
                    App.DB.User.FirstOrDefault(x => x.id == newUser.id).Name = TBName.Text;
                };
            }
            else if (TBSename.Text != "")
            {
                if (App.DB.User.FirstOrDefault(x => x.id == newUser.id) == null)
                {
                    newUser.Sename = TBSename.Text;
                }
                else
                {
                    App.DB.User.FirstOrDefault(x => x.id == newUser.id).Sename = TBSename.Text;
                };
            }
            else if (TBSurname.Text != "")
            {
                if (App.DB.User.FirstOrDefault(x => x.id == newUser.id) == null)
                {
                    newUser.Surname = TBSurname.Text;
                }
                else
                {
                    App.DB.User.FirstOrDefault(x => x.id == newUser.id).Surname = TBSurname.Text;
                };
            }
            else
            {
                MessageBox.Show("Not all line are filled");
            };
            if (!IsEdit)
            {
                App.DB.User.Add(newUser);
            }
            try
            {
                App.DB.SaveChanges();
                Maneger.MainFrame.GoBack();
            }
            catch
            {
                MessageBox.Show("Data not save");
            }
        }
    }
}