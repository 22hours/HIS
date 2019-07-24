using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace PrinterControl
{
    public class Global
    {
        public static string ID = "";
        public static bool checkLogin = false;

        public Global()
        {

        }

        public static void LOGIN(string id)
        {
            ID = id;
            checkLogin = true;
        }

        public static void LOGOUT()
        {
            ID = "";
            checkLogin = false;
        }
        
        public static void nav(DependencyObject page, string s)
        {
            Uri uri = new Uri(s, UriKind.Relative);
            try
            {
                
                NavigationService.GetNavigationService(page).Navigate(new Uri(s, UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
