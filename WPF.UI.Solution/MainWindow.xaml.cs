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
using WPF.UI.Solution.Utility;

namespace WPF.UI.Solution
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Threading.Mutex mutex;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 只能运行一个exe
        /// </summary>
        private void CheckExe()
        {
            bool ret;
            mutex = new System.Threading.Mutex(true, "System", out ret);
            if (!ret)
            {
                System.Windows.MessageBox.Show("已有一个程序实例运行，请勿重新运行");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// MenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.MenuItem menuItem = (System.Windows.Controls.MenuItem)sender;
            switch (menuItem.CommandParameter.ToString())
            {
                case "MenuItem":
                    LogMessages.ShowLog("MenuItem ", "DEBUG");
                    break;
                case "Log":
                    Console.WriteLine("Log");
                    Frame.Content = new View.Log();
                    break;
                case "Set":
                    Console.WriteLine("Set");
                    break;
                case "Help":
                    Console.WriteLine("Help");
                    break;
                case "About":
                    Console.WriteLine("About");
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CheckExe();
            Frame.Content = new View.Welcome();
        }

        /// <summary>
        /// MenuRadioButtom_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuRadioButtom_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.RadioButton radio = (System.Windows.Controls.RadioButton)sender;
            switch (radio.CommandParameter.ToString())
            {
                case "Welcome":
                    Frame.Content = new View.Welcome();
                    break;
                case "Base":
                    Frame.Content = new View.Base();
                    break;
                case "Test":
                    Frame.Content = new View.Test();
                    break;
                case "DataGrid":
                    Frame.Content = new View.DataGrid();
                    break;
                case "ListView":
                    Frame.Content = new View.ListView();
                    break;
                case "Notifiaction":
                    Frame.Content = new View._Notification();
                    break;
                case "VirtualizingWrapPanel":
                    Frame.Content = new View._VirtualizingWrapPanel();
                    break;
                    
            }
        }

        //closed Notifications
        protected override void OnClosed(System.EventArgs e)
        {
            View._Notification.growlNotifications.Close();
            base.OnClosed(e);
        }
    }
}
