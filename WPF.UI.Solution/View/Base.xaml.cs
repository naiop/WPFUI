using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Base.xaml 的交互逻辑
    /// </summary>
    public partial class Base : Page
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_Loaded(object sender, RoutedEventArgs e)
        {
            Func<string> wait = () =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(200); //毫秒
                    this.progressBar1.Dispatcher.BeginInvoke((System.Threading.ThreadStart)delegate { this.progressBar1.Value = i; });
                }
                return "ok";
            };
            wait.BeginInvoke(new AsyncCallback(result =>
            {

                ThreadPool.QueueUserWorkItem(delegate
                {
                    System.Threading.SynchronizationContext.SetSynchronizationContext(new
                      System.Windows.Threading.DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                    System.Threading.SynchronizationContext.Current.Post(p1 =>
                    {
                        //这里写 其它线程进行添加删除操作
                        string flag = wait.EndInvoke(result);
                        
                        
                    }, null);
                });

            }), null);

        }
    }
}
