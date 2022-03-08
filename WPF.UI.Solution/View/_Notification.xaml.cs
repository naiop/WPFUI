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
using WPF.GrowlNotification;

namespace WPF.UI.Solution.View
{
    /// <summary>
    /// _Notification.xaml 的交互逻辑
    /// </summary>
    public partial class _Notification : Page
    {
        private const double topOffset = 20;
        private const double leftOffset = 380;
        public static GrowlNotifiactions growlNotifications = new GrowlNotifiactions();
        public _Notification()
        {
            InitializeComponent();
            growlNotifications.Top = SystemParameters.WorkArea.Top + topOffset;
            growlNotifications.Left = SystemParameters.WorkArea.Left + SystemParameters.WorkArea.Width - leftOffset;

        }

        private void ButtonClick_Notification(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
            switch (button.CommandParameter.ToString())
            {
                case "1":
                    growlNotifications.AddNotification(new Notification { Title = "Mesage #1", ImageUrl = "pack://application:,,,/Img/Notification/notification-icon.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });

                    break;
                case "2":
                    growlNotifications.AddNotification(new Notification { Title = "Mesage #2", ImageUrl = "pack://application:,,,/Img/Notification/microsoft-windows-8-logo.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });

                    break;
                case "3":
                    growlNotifications.AddNotification(new Notification { Title = "Mesage #3", ImageUrl = "pack://application:,,,/Img/Notification/facebook-button.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });

                    break;
                case "4":
                    growlNotifications.AddNotification(new Notification { Title = "Mesage #4", ImageUrl = "pack://application:,,,/Img/Notification/Radiation_warning_symbol.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });

                    break;

            }
        }
        //protected override void OnClose(System.EventArgs e)
        //{
        //    growlNotifications.Close();
        //    base.OnClosed(e);
        //}
    }
}
