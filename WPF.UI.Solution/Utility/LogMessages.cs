using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF.UI.Solution.Utility
{
    public class LogMessages
    {
        public static void ShowLog(string strLog, string type)
        {
            string time = DateTime.Now.ToString();// 获取时间
            TextBlock MessageList = new TextBlock();

            if (type == "ERROR")
            {
                MessageList.Text = "[错误] " + time + "|" + strLog;
                MessageList.Background = Brushes.Red;
            }
            else if (type == "DEBUG")
            {
                MessageList.Text = "[日志] " + time + "|" + strLog;
                MessageList.Background = Brushes.PaleGreen;
            }
            else if (type == "WARN")
            {
                MessageList.Text = "[警告] " + time + " | " + strLog;
                MessageList.Background = Brushes.Yellow;
            }
            else
            {
                MessageList.Text = "[未知] " + time + " | " + strLog;
            }

            App.LogMsgs.Add(MessageList);

        }
    }
}
