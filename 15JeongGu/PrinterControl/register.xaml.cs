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
    /// Page2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page2 : Page
    {
        private string UID { get; set; }
        private string UPW { get; set; }
        private bool checkIdInput = false;

        public Page2()
        {
            InitializeComponent();
        }

        private void IDCHECK_Click(object sender, RoutedEventArgs e)
        {
            if(ID.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            if (ID.Text.Length < 4)
            {
                MessageBox.Show("아이디는 4글자 이상 입력해주세요.");
                return;
            }

            bool IDCHECK = false;
            UID = this.ID.Text;
            DBConn dbconn = new DBConn();
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
                IDCHECK = true;
                checkIdInput = false;
                MessageBox.Show("현재 사용되는 아이디입니다.");
            }
            if (IDCHECK == false)
            {
                checkIdInput = true;
                MessageBox.Show("사용가능한 아이디입니다.");
            }
            dbconn.myconn.Close();
            IDCHECK = false;
        }

        private void REGISTER_Click(object sender, RoutedEventArgs e)
        {
            if(ID.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            if (checkIdInput == false)
            {
                MessageBox.Show("아이디 중복 체크를 해주세요.");
                return;
            }
            if (PASSWD.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }
            if (PASSWD.Text.Length < 4 || PASSWD.Text.Length >10)
            {
                MessageBox.Show("비밀번호는 4~10개까지 입력해주세요.");
                return;
            }


            UPW = this.PASSWD.Text;
            DBConn dbconn = new DBConn();
            dbconn.DBOpen();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbconn.myconn;
                cmd.CommandText = "INSERT INTO member(id,passwd) VALUES(@id,@passwd)";
                cmd.Parameters.Add("@id", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@passwd", MySqlDbType.VarChar, 50);
                cmd.Parameters[0].Value = UID;
                cmd.Parameters[1].Value = UPW;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("생성 불가능" + " (" + ex.Message + ")");
            }
            finally
            {
                dbconn.myconn.Close();
                MessageBox.Show("회원가입 완료. OMG, HOLY SHIT, WTF");
                Uri uri = new Uri("mainPage.xaml", UriKind.Relative);
                try
                {
                    NavigationService.GetNavigationService(this).Navigate(new Uri("mainPage.xaml", UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIdInput = false;
        }

        private void GotoMain_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("mainPage.xaml", UriKind.Relative);
            try
            {
                NavigationService.GetNavigationService(this).Navigate(new Uri("mainPage.xaml", UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
