using ProtectionApp.Classes;
using ProtectionApp.Models;
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

namespace ProtectionApp.Scripts
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Blogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder erors = new StringBuilder();
            if (TBid.Text == null)
            {
                erors.Append("Line is null");
            }
            else if (App.DB.Group.FirstOrDefault(x => x.id == TBid.Text) != null)
            {
                Maneger.MainFrame.Navigate(new PrimaryPage());
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
    }
}
