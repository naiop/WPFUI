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

namespace WPF.UI.Solution.View
{
    /// <summary>
    /// Log.xaml 的交互逻辑
    /// </summary>
    public partial class Log : Page
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Loaded_Log(object sender, RoutedEventArgs e)
        {
            MessageList.ItemsSource = App.LogMsgs;
        }

        private void MItem_ClearClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.MenuItem menuItem = (System.Windows.Controls.MenuItem)sender;
            switch (menuItem.CommandParameter.ToString())
            {
                case "Exception":
                    App.ExceptionLogMsgs.Clear();
                    break;
                case "interactive":
                    App.LogMsgs.Clear();
                    break;
               
            }
        }
    }
}
