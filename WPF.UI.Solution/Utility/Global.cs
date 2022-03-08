using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.UI.Solution.Utility
{
    public class Global
    {
        public class Data
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Account { get; set; }
            public string Password { get; set; }
            public string Info { get; set; }
        }
        public static void WinMessage(string msg, string caption = "操作提示")
        {
            MessageBox.Show(msg, caption, MessageBoxButton.OK);
        }

    }
    
}
