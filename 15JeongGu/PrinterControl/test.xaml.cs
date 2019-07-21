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
using System.Windows.Shapes;
using System.Windows.Navigation;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PrinterControl
{
    /// <summary>
    /// test.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
        }
        private void btnloaddata_Click(object sender, RoutedEventArgs e)
        {
            DBConn dbconn = new DBConn();
            try
            {
                dbconn.DBOpen();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbconn.myconn;
                cmd.CommandText = "SELECT * FROM member WHERE id = @id";
                cmd.Parameters.Add("@id", MySqlDbType.VarChar, 45);
                cmd.Parameters[0].Value = "5";
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds, "LoadDataBinding");
                dataGridCustomers.DataContext = ds;
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





    }
}
