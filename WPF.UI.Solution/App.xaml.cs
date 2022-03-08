using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static WPF.UI.Solution.Utility.Global;

namespace WPF.UI.Solution
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static System.Collections.ObjectModel.ObservableCollection<Data> CodeList = new System.Collections.ObjectModel.ObservableCollection<Data> {
                     new Data() {  ID=1,Name="Welcome",Account="1779751****",Password="12355****@qq.com",Info="👋纸上得来终觉浅，绝知此事要躬行"}
                    ,new Data() {  ID=2,Name="Base",Account="1779751****",Password="12355****@qq.com",Info="🚀 Deploy"}
                    ,new Data() {  ID=3,Name="Design",Account="1779751****",Password="12355****@qq.com",Info="⬆️ Update dependencies"}
                    ,new Data() {  ID=4,Name="DataGrid",Account="1779751****",Password="12355****@qq.com",Info="🐛 Loader > Fix"}
                    ,new Data() {  ID=5,Name="Design",Account="1779751****",Password="12355****@qq.com",Info="🥚 2追求极致，永臻完美"}
                    ,new Data() {  ID=6,Name="Design",Account="1779751****",Password="12355****@qq.com",Info="💄 站点 > 文件树 >"}
                    ,new Data() {  ID=7,Name="Design",Account="1779751****",Password="12355****@qq.com",Info="🍱 站点 > 文件树 > 添的支持"}
                    ,new Data() {  ID=8,Name="Design",Account="1779751****",Password="12355****@qq.com",Info="质的飞跃 ✨"}
                };
        public static System.Collections.ObjectModel.ObservableCollection<TextBlock> LogMsgs = new System.Collections.ObjectModel.ObservableCollection<TextBlock>();//日志显示类
        public static System.Collections.ObjectModel.ObservableCollection<TextBlock> ExceptionLogMsgs = new System.Collections.ObjectModel.ObservableCollection<TextBlock>();//异常日志显示类
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            InitExceptionHandle();
        }
        public static void Close(int exitCode = 0)
        {
            Environment.Exit(exitCode);
        }
        private static void OnUnhandledException(Exception e)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                lock (App.Current)
                {
                    System.Console.WriteLine("Exception #{0}", e);
                    TextBlock MessageList = new TextBlock();
                    MessageList.Text = "[APP 错误异常] " + DateTime.Now.ToString() + "|" + e.Message;
                    MessageList.Background = Brushes.Red;
                    App.ExceptionLogMsgs.Add(MessageList);
                    //  App.Close();

                }
            });
        }
        private void InitExceptionHandle()
        {
            this.DispatcherUnhandledException += (o, args) =>
            {
                args.Handled = true;
                OnUnhandledException(args.Exception);
            };
            TaskScheduler.UnobservedTaskException += (o, args) =>
            {
                args.SetObserved();//设置该异常已察觉（这样处理后就不会引起程序崩溃）
                OnUnhandledException(args.Exception);
            };
            AppDomain.CurrentDomain.UnhandledException += (o, args) =>
            {
                if (args.ExceptionObject is Exception e)
                {
                    OnUnhandledException(e);
                }
                else
                {
                    System.Console.WriteLine("Exception #{0}", args.ExceptionObject);
                    TextBlock MessageList = new TextBlock();
                    MessageList.Text = "[APP 错误异常] " + DateTime.Now.ToString() + "|" + args.ExceptionObject;
                    MessageList.Background = Brushes.Red;
                    App.ExceptionLogMsgs.Add(MessageList);

                }
            };
        }
    }
}
