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

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PrinterControl
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        private string UID { set; get; }
        private string UPW { set; get; }
        private bool check = false;
        
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBConn dbconn = new DBConn();
            UID = this.ID.Text;
            UPW = this.PASSWD.Text;
            try
            {
                dbconn.DBOpen();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbconn.myconn;
                cmd.CommandText = "SELECT * FROM member WHERE id = @id";
                cmd.Parameters.Add("@id", MySqlDbType.VarChar, 50);
                cmd.Parameters[0].Value = UID;
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    check = true;
                    if ((string)r["passwd"] == UPW)
                    {
                        dbconn.myconn.Close();
                        Global.LOGIN(UID);
                        Global.nav(this, "mainPage.xaml");
                        /*
                        Uri uri = new Uri("mainPage.xaml", UriKind.Relative);
                        try
                        {
                            NavigationService.GetNavigationService(this).Navigate(new Uri("mainPage.xaml", UriKind.Relative));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        */
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀립니다.");
                    }
                }
                if(check == false)
                {
                    MessageBox.Show("아이디가 존재하지 않습니다.");
                }
                check = false;

            }
            catch (MySqlException MSE)
            {
                MessageBox.Show(MSE.ToString());
            }
            finally
            {
                dbconn.myconn.Close();
            }
            
        }

        private void GotoRGT_Click(object sender, RoutedEventArgs e)
        {
            Global.nav(this, "register.xaml");
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

        private void GotoMain_Click(object sender, RoutedEventArgs e)
        {
            Global.nav(this, "mainPage.xaml");
            /*
            Uri uri = new Uri("mainPage.xaml", UriKind.Relative);
            try
            {
                NavigationService.GetNavigationService(this).Navigate(new Uri("mainPage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }
    }
}
