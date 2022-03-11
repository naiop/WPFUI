using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// _VirtualizingWrapPanel.xaml 的交互逻辑
    /// </summary>
    public partial class _VirtualizingWrapPanel : Page
    {
        public ObservableCollection<string> li = new ObservableCollection<string>();
        public _VirtualizingWrapPanel()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 50; i++)
            {
                li.Add(i.ToString());
            }
            listB.ItemsSource = li;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            li.Clear();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            li.Add("334");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            li.RemoveAt(2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(li.Count.ToString());
        }

        private void btnAddIndex3(object sender, RoutedEventArgs e)
        {
            li.Insert(3, "333333");
        }

        private void editindex(object sender, RoutedEventArgs e)
        {
            li[2] += "44444";
        }
    }
}
