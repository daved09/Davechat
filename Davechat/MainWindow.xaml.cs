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

namespace Davechat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private networking.Networkmanager networkmanager;

        private usercontroll.UserData user;

        public MainWindow()
        {
            InitializeComponent();
            Initalize();
        }

        private void Initalize()
        {
            user = new usercontroll.UserData();
            RefreshUserDataToGui();
        }

        private void RefreshUserDataToGui()
        {
            lblUsername.Content = user.UserName;
        }
        

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if((!Keyboard.IsKeyDown(Key.LeftShift)) && (!Keyboard.IsKeyDown(Key.RightShift)))
            {
                if (e.Key == Key.Enter)
                {
                    SendMessage(txtMessage.Text);
                }
            }
        }

        private void SendMessage(string msg)
        {
            txtMessage.Clear();
            txtHistory.AppendText(user.UserName + ": " + msg + Environment.NewLine);
        }

        private void ChangeUserName()
        {
            if (!txtUsername.Text.Equals(""))
            {
                user.UserName = txtUsername.Text;
            }
            RefreshUserDataToGui();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHost_Click(object sender, RoutedEventArgs e)
        {
            ChangeUserName();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtHistory.Clear();
        }
    }
}
