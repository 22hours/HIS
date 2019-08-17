using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace HISClient
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window
    {
        public class Uinfo: INotifyPropertyChanged
        {
            private string uID;
            private string uNAME;
            private string uMAJOR;
            private string uMONEY;

            public Uinfo(string uID, string uNAME, string uMAJOR, string uMONEY)
            {
                this.UID = uID;
                this.UNAME = uNAME;
                this.UMAJOR = uMAJOR;
                this.UMONEY = uMONEY;
            }

            public Uinfo()
            {

            }
            public string UID { get => uID; set => uID = value; }
            public string UNAME { get => uNAME; set => uNAME = value; }
            public string UMAJOR { get => uMAJOR; set => uMAJOR = value; }
            public string UMONEY { get => uMONEY; set => uMONEY = value; }

            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged(string name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        public string Name;
        public string Money;
        public string Major;
        public MainView()
        {
            string uid = Application.Current.Properties["id"] as string;

            ((App)Application.Current).SendData(uid, "<INF>");
            Uinfo ui = new Uinfo();

            //ui.UNAME = name;
            //ui.UMAJOR = major;
            //ui.UMONEY = money;

            //Name = name;
            //Major= major;
            //Money = money;

            //nameBox.Text = name;
            //majorBox.Text = major;
            //moneyBox.Text = money;

            //nameBox.Text  = ((App)Application.Current).getName();
            //majorBox.Text = ((App)Application.Current).getMajor();
            //moneyBox.Text  = ((App)Application.Current).getMoney();


            //ui.UNAME = ((App)Application.Current).getName();
            //ui.UMAJOR = ((App)Application.Current).getMajor();
            //ui.UMONEY = ((App)Application.Current).getMoney();
            InitializeComponent();
            GridM.DataContext = this;
        }

        public void CloseWPF(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void CloseWPF2(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).ToggleFlag();
            Environment.Exit(0);
        }


        public void GetMyINF(object sender , RoutedEventArgs e)
        {
            nameBox.Text = ((App)Application.Current).getName();
            majorBox.Text =((App)Application.Current).getMajor();
            moneyBox.Text  = ((App)Application.Current).getMoney();
        }
    }
}
