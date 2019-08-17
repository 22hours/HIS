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

namespace HISClient
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Login(object sender, RoutedEventArgs e)
        {
            string Uid = idBox.Text;
            Application.Current.Properties["id"] = Uid;
            string Upw = pwBox.Password.ToString();
            string parameter = Uid + "/" + Upw;
            ((App)Application.Current).SendData(parameter, "<LOG>");
        }
        public void Register(object sender, RoutedEventArgs e)
        {
            string Uid = REG_idBox.Text;
            string Upw = REG_pwBox.Password.ToString();
            string Upw2 = REG_pwReBox.Password.ToString();
            string Uname = REG_nameBox.Text;
            string Umajor = REG_majorBox.Text;
            if (Uid == "" || Upw == "" || Upw2 == "" || Uname == "" || Umajor == "")
            {
                MessageBox.Show("입력 덜햇다");
                return;
            }
            if (Upw.Equals(Upw2))
            {
                string parameter = Uid + "/" + Upw + "/" + Uname + "/" + Umajor;
                ((App)Application.Current).SendData(parameter, "<REG>");
            }

        }
    }
}
