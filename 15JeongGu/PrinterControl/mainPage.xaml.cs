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

namespace PrinterControl
{
    /// <summary>
    /// mainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class mainPage : Page
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void LGN_Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("login.xaml", UriKind.Relative);
            try
            {
                NavigationService.GetNavigationService(this).Navigate(new Uri("login.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }

    

}
