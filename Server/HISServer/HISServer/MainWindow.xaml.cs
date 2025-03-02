﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace HISServer
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class MainWindow : Window
    {

        public class Uinfo
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
        }
        public class ListItem
        {
            public string text { get; set; }
            public string user { get; set; }
            public ListItem(string user, string text)
            {
                this.text = text;
                this.user = user;
            }
        }
        public class ClientItem
        {
            public string handle { get; set; }
            public string id { get; set; }

            public ClientItem(string id, string handle)
            {
                this.handle = handle;
                this.id = id;
            }
        }
        public class info : INotifyPropertyChanged
        {
            private string ID;
            private string PORT;
            private string IPADDR;
            private string SERVER;
            public string id
            {
                get { return ID; }
                set { this.ID = value; OnPropertyChanged("id"); }
            }
            public string port
            {
                get { return PORT; }
                set { this.PORT = value; OnPropertyChanged("port"); }
            }
            public string ipaddr
            {
                get { return IPADDR; }
                set { this.IPADDR = value; OnPropertyChanged("ipaddr"); }
            }
            public string server
            {
                get { return SERVER; }
                set { this.SERVER = value; OnPropertyChanged("server"); }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged(string name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
        delegate void AddListItem(string id, string text, Boolean flag);
        delegate bool loginDB(string id, string pw);
        delegate void AddClientItem(string id, string handle);
        delegate void ClinetRemoveAt(int index);


        public void clientRemoveAt(int index)
        {
            ClientList.RemoveAt(index);
        }
        public void AddLists(string id, string text, Boolean flag)
        {
            if (flag)
            {
                SendList.Add(new ListItem("[보냄]", text));
                //  SendBox.UpdateLayout();
                // SendBox.ScrollIntoView(SendBox.Items[SendBox.Items.Count - 1]);

            }
            else
            {
                RecieveList.Add(new ListItem("[받음]" + id, text));
                // RecieveBox.UpdateLayout();
                //RecieveBox.ScrollIntoView(RecieveBox.Items[RecieveBox.Items.Count - 1]);

            }
        }



        #region mysql
        private MySqlConnection getConn()
        {
            string strConn = "Server=localhost; Port=3306; Database=testdb; Uid=root;Pwd=123";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        
         private bool Register(string id, string pw, string name, string major)
        {
            string strConn = "Server=localhost; Port=3306; Database=testdb; Uid=root;Pwd=123";
            MySqlConnection conn = new MySqlConnection(strConn);

            AddListItem a = new AddListItem(AddLists);
            this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "입력 받은 ID :  " + id + "  PW : " + pw +"NAME :"+name+"MAJOR : "+major, false);
            try
            {
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "DB Connection Open Try..... " , false);
                conn.Open();
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "DB Connection Open Success " ,false);

                string sql = "INSERT INTO testdb.his (id,password,name,major,money) values ('"+id+"', '"+pw+ "', '" + name + "', '"+major+"', 0)";
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Query  : " + sql, false);
                int res = cmd1.ExecuteNonQuery();
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Read OK" , false);
                if (res == 1)
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Register OK", false);
                    return true;
                }
                else {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Register Fail", false);
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        #region login
        private bool Login(string id, string pw)
        {
            string strConn = "Server=localhost; Port=3306; Database=testdb; Uid=root;Pwd=123";
            MySqlConnection conn = new MySqlConnection(strConn);

            AddListItem a = new AddListItem(AddLists);
            this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "입력 받은 ID :  " + id + "  PW : " + pw, false);
            try
            {
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "DB Connection Open Try..... " + pw, false);
                conn.Open();
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "DB Connection Open Success " + pw, false);

                string sql = "SELECT * FROM testdb.his WHERE id='" + id + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Query  : " + sql, false);

                MySqlDataReader read = cmd1.ExecuteReader();
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Read OK" + pw, false);

                if (read.Read())
                {
                    if ((read["password"] as string).Equals(pw))
                    {
                        this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Login OK" + pw, false);
                        return true;
                    }
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Login Fail" + pw, false);
                    return false;
                }
                else
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Login Fail" + pw, false);

                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        #endregion login
        #endregion
        private void updateMoney (string change, string id)
        {
            string strConn = "Server=localhost; Port=3306; Database=testdb; Uid=root;Pwd=123";
            MySqlConnection conn = new MySqlConnection(strConn);
            AddListItem a = new AddListItem(AddLists);
            try
            {
                conn.Open();

                string sql = "UPDATE testdb.his SET money ='"+change+"' WHERE (id='"+id+"')";
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "sql :  "+sql, false);

                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                int res = cmd1.ExecuteNonQuery();
                if (res == 1)
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Upadte  OK", false);
                }
                else
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Upadte Fail", false);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        private Uinfo GetINF(string id)
        {
            string strConn = "Server=localhost; Port=3306; Database=testdb; Uid=root;Pwd=123";
            MySqlConnection conn = new MySqlConnection(strConn);
            Uinfo res = new Uinfo();

            AddListItem a = new AddListItem(AddLists);
            this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "입력 받은 ID :  " + id + "  PW : ", false);
            try
            {
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "DB Connection Open Try..... " , false);
                conn.Open();
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "DB Connection Open Success " , false);

                string sql = "SELECT * FROM testdb.his WHERE id='" + id + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Query  : " , false);

                MySqlDataReader read = cmd1.ExecuteReader();
                this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Read OK" , false);
                if (read.Read())
                {
                    res.UID = id;
                    res.UNAME = read["name"] as string;
                    res.UMAJOR = read["major"] as string;
                    res.UMONEY = read["money"] as string;
                }
                else
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Login Fail", false);
                }
                return res;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return res;

        }

        public void AddClient(string id, string handle)
        {
            ClientList.Add(new ClientItem(id, handle));
        }

        public ObservableCollection<ListItem> SendList = new ObservableCollection<ListItem>();
        public ObservableCollection<ListItem> RecieveList = new ObservableCollection<ListItem>();
        public ObservableCollection<ClientItem> ClientList = new ObservableCollection<ClientItem>();

        Socket mainSock;
        public class AsyncObject
        {
            public byte[] Buffer;
            public Socket WorkingSocket;
            public readonly int BufferSize;
            public AsyncObject(int bufferSize)
            {
                BufferSize = bufferSize;
                Buffer = new byte[BufferSize];
            }

            public void ClearBuffer()
            {
                Array.Clear(Buffer, 0, BufferSize);
            }
        }
        List<Socket> connectedClients = new List<Socket>();
        bool nowListen = false;
        void AcceptCallback(IAsyncResult ar)
        {
            if (!nowListen)
            {
                myInfo.server = "Server is Shutdown";
                mainSock.BeginAccept(AcceptCallback, null);
                return;
            }
            // 클라이언트의 연결 요청을 수락한다.
            Socket client = mainSock.EndAccept(ar);
            if (!client.Connected)
            {
                return;
            }
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;
            // 연결된 클라이언트 리스트에 추가해준다.
            connectedClients.Add(client);

            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            mainSock.BeginAccept(AcceptCallback, null);

            nowListen = true;
        }

        void DataReceived(IAsyncResult ar)
        {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            if (!obj.WorkingSocket.Connected)
            {

                return;
            }
            // 클라이언트가 보낸 데이터는 obj.Buffer에 바이트 형식으로 저장된다.
            // 따라서 이 데이터는 System.Text.Encoding 클래스의 GetString 함수를 이용하여 문자열로
            // 변환해야 사용이 가능하다.
            string text = System.Text.Encoding.UTF8.GetString(obj.Buffer);
            AddListItem a = new AddListItem(AddLists);
            // 0x01 기준으로 짜른다.
            // tokens[0] - 보낸 사람 IP
            // tokens[1] - 보낸 메세지
            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            try
            {
                string msg = tokens[1];
                string fchk = msg.Substring(0, 5);
                if (fchk.Equals("<SOF>"))
                {
                    AddClientItem c = new AddClientItem(AddClient);
                    this.CList.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddClientItem(c), ip, obj.WorkingSocket.Handle.ToString());
                    Console.WriteLine(ip + "님이 접속하셨습니다.");
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", ip + "님이 접속하셨습니다.", false);
                    for (int i = connectedClients.Count - 1; i >= 0; i--)
                    {
                        Socket socket = connectedClients[i];

                        // 핸들 값을 비교하여 이 데이터를 보낸 소켓인지 구분한다.
                        if (socket.Handle != obj.WorkingSocket.Handle)
                        {
                            // 데이터를 보낸 소켓이 아니라면
                            // 수신받은 데이터를 전달해준다.
                            byte[] acceptCallmsg = Encoding.UTF8.GetBytes("[SERVER]" + '\x01' + ip + "님이 접속하셨습니다");

                            socket.Send(acceptCallmsg);
                        }
                        else
                        {
                        }
                    }
                }
                else if (fchk.Equals("<LOG>"))
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", ip + "로그인 시도 중.", false);
                    string[] logToken = ip.Split('/');
                    string InputId = logToken[0];
                    string InputPw = logToken[1];
                    if (Login(InputId, InputPw))
                    {
                        byte[] acceptCallmsg = Encoding.UTF8.GetBytes("success" + '\x01' + "<LOG>");
                        this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Client 에게 Sucess메세지를 전달합니다", false);

                        obj.WorkingSocket.Send(acceptCallmsg);
                    }
                    else
                    {
                        byte[] acceptCallmsg = Encoding.UTF8.GetBytes("fail" + '\x01' + "<LOG>fail");
                        this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Client 에게 Fail메세지를 전달합니다", false);

                        obj.WorkingSocket.Send(acceptCallmsg);
                    }
                }
                else if (fchk.Equals("<REG>"))
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", ip + "회원가입 시도 중.", false);
                    string[] logToken = ip.Split('/');
                    string InputId = logToken[0];
                    string InputPw = logToken[1];
                    string Inputname = logToken[2];
                    string InputMajor = logToken[3];
                    if (Register(InputId, InputPw,Inputname,InputMajor))
                    {
                        byte[] acceptCallmsg = Encoding.UTF8.GetBytes("success" + '\x01' + "<REG>");
                        this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Client 에게 Sucess메세지를 전달합니다", false);

                        obj.WorkingSocket.Send(acceptCallmsg);
                    }
                    else
                    {
                        byte[] acceptCallmsg = Encoding.UTF8.GetBytes("fail" + '\x01' + "<LOG>fail");
                        this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", "Client 에게 Fail메세지를 전달합니다", false);

                        obj.WorkingSocket.Send(acceptCallmsg);
                    }
                }
                else if (fchk.Equals("<INF>"))
                {
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", ip + "정보 불러오는 중...", false);
                    Uinfo res = GetINF(ip);
                    string result = ip+"/"+res.UNAME + "/" + res.UMAJOR + "/" + res.UMONEY;
                    byte[] acceptCallmsg = Encoding.UTF8.GetBytes(result + '\x01' + "<INF>");
                    obj.WorkingSocket.Send(acceptCallmsg);
                }
                else if (fchk.Equals("<PRT>"))
                {
                    string[] logToken = ip.Split('/');
                    string id = logToken[0];
                    string change = logToken[1];
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", change + "로 머니를 update합니다.", false);
 
                    updateMoney(change,id);
                    byte[] acceptCallmsg = Encoding.UTF8.GetBytes(ip + '\x01' + "<PRT>");
                    obj.WorkingSocket.Send(acceptCallmsg);
                }
                else
                {
                    Console.WriteLine("client Send : {0}", msg);
                    this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), ip, msg, false);
                    // for을 통해 "역순"으로 클라이언트에게 데이터를 보낸다.
                    // 원래 순서대로 리스트를 반복하다 보면 개체가 제거될 때 오류가 발생하게 된다.
                    // 역순으로 반복 루프를 돌면 해결된다.
                    // 이유: 리스트 내 요소가 제거되는 방법이 해당 요소를 뺀 후 뒤의 요소들을 붙이는 방법이기 때문이다.
                    for (int i = connectedClients.Count - 1; i >= 0; i--)
                    {
                        Socket socket = connectedClients[i];

                        // 핸들 값을 비교하여 이 데이터를 보낸 소켓인지 구분한다.
                        if (socket.Handle != obj.WorkingSocket.Handle)
                        {
                            // 데이터를 보낸 소켓이 아니라면
                            // 수신받은 데이터를 전달해준다.
                            socket.Send(obj.Buffer);
                        }
                        else
                        {
                        }
                    }
                }
                // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
                obj.ClearBuffer();

                // 수신 대기
                // AcceptCallback 함수에서의 client와 obj.WorkingSocket은 동일한 소켓 개체이다!
                obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            }
            catch (Exception e)
            {
                for (int i = connectedClients.Count - 1; i >= 0; i--)
                {
                    Socket socket = connectedClients[i];
                    if (socket.Handle == obj.WorkingSocket.Handle)
                    {
                        connectedClients[i].Dispose();
                        connectedClients[i].Close();
                        connectedClients.RemoveAt(i);
                    }
                }
                ClinetRemoveAt cra = new ClinetRemoveAt(clientRemoveAt);
                for (int i = ClientList.Count - 1; i >= 0; i--)
                {
                    string handle = ClientList[i].handle;
                    if (handle.Equals(obj.WorkingSocket.Handle.ToString()))
                    {
                        this.chatBox.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new AddListItem(a), "[SERVER]", ClientList[i].id + "님이 나가셨습니다.", false);
                        this.CList.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new ClinetRemoveAt(cra), i);
                    }
                }
            }
            mainSock.BeginAccept(AcceptCallback, null);
        }

        public void kickHim(object sender, RoutedEventArgs e)
        {

        }

        info myInfo = new info();
        public MainWindow()
        {
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 12345);
            mainSock.Bind(serverEP);
            InitializeComponent();
            DataContext = myInfo;
            this.CList.ItemsSource = ClientList;
            myInfo.server = "Not Running Now";
            this.RecieveBox.ItemsSource = RecieveList;
            // this.SendBox.ItemsSource = SendList;
        }
        public void userInputText_KeyDown(object sender, RoutedEventArgs e)
        {

        }
        public void click_sendMessage(object sender, RoutedEventArgs e)
        {
            AddLists("[보냄]", inputText.Text.ToString(), true);

            OnSendData();
        }
        void OnSendData()
        {
            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound)
            {
                MessageBox.Show("서버가 실행되고 있지 않습니다!");
                return;
            }
            // 보낼 텍스트
            string tts = inputText.Text.Trim();
            string addr = IPAddress.Loopback.ToString();
            if (string.IsNullOrEmpty(tts))
            {
                MessageBox.Show("텍스트 입력 바람!");
                inputText.Focus();
                return;
            }
            byte[] bDts = Encoding.UTF8.GetBytes(userName.Text + '\x01' + tts);
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                socket.Send(bDts);
            }
            inputText.Clear();
        }
        public void startServer(object sender, RoutedEventArgs e)
        {
            if (nowListen)
            {
                MessageBox.Show("Server is already Running...");
                return;
            }

            RecieveList.Add(new ListItem("[SERVER]", "SERVER RUNNING....."));
            myInfo.id = "SERVER";
            myInfo.ipaddr = IPAddress.Loopback.ToString();
            myInfo.port = "12345";
            myInfo.server = "Server Is Running Now!!";
            mainSock.Listen(5);
            mainSock.BeginAccept(AcceptCallback, null);
            nowListen = true;
        }
        public void stopServer(object sender, RoutedEventArgs e)
        {
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                socket.Dispose();
                socket.Close();
            }
            myInfo.server = "Server is Shutdown";
            connectedClients.Clear();
            nowListen = false;
            ClientList.Clear();
        }
        //public static bool IsConnected(this Socket socket)
        //{
        //    try
        //    {
        //        return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
        //    }
        //    catch (SocketException) { return false; }
        //}

        public void closeWindow(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
