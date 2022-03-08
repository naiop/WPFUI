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
    /// ListView.xaml 的交互逻辑
    /// </summary>
    public partial class ListView : Page
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void GroupClickedHandler(object sender, MouseButtonEventArgs e)
        {

        }

        private void LsitView_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = App.CodeList;
        }
    }
}
