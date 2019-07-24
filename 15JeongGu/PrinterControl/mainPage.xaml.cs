using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace PrinterControl
{
    /// <summary>
    /// mainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class mainPage : Page
    {
        public event PropertyChangedEventHandler PropertyChanged;
       

        public mainPage()
        {
            InitializeComponent();
            PrinterDevicePortEventMonitor.scanPorts();
            //PrinterDevicePortEventMonitor.GetHDDSerialNumber("C");
            Binding login = new Binding();
            Binding id = new Binding();
            Binding vis = new Binding();

            if (Global.checkLogin == false)
            {
                try
                {
                    login.Source = "Login";
                    this.LOGIN.SetBinding(Button.ContentProperty, login);
                    id.Source = Global.ID;
                    this.ID.SetBinding(TextBlock.TextProperty, id);
                    vis.Source = Visibility.Hidden;
                    this.USER.SetBinding(Label.VisibilityProperty, vis);
                    MessageBox.Show("nonlogin");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                try
                {
                    login.Source = "Logout";
                    this.LOGIN.SetBinding(Button.ContentProperty, login);
                    id.Source = Global.ID;
                    ID.SetBinding(TextBlock.TextProperty, id);
                    vis.Source = Visibility.Visible;
                    USER.SetBinding(Label.VisibilityProperty, vis);
                    MessageBox.Show("login");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            }
        }

        private void LGN_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Global.checkLogin == false)
            {
                Global.nav(this, "login.xaml");
                /*
                Uri uri = new Uri("login.xaml", UriKind.Relative);
                try
                {
                    NavigationService.GetNavigationService(this).Navigate(new Uri("login.xaml", UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                */
            }
            else
            {
                Global.LOGOUT();;


            }
        }

        private void RGT_Button_Click(object sender, RoutedEventArgs e)
        {
            Global.nav(this,"register.xaml");
            /*
            Uri uri = new Uri("register.xaml", UriKind.Relative);
            try
            {
                NavigationService.GetNavigationService(this).Navigate(new Uri("register.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }
    }

    

}
