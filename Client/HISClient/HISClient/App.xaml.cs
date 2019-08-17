using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Windows;

namespace HISClient
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            StartSocket();
        }

        public bool flag = false;
        public static string id ="123";
        public static string name ="123";
        public static string major ="!23";
        public static string money = " 123";

        public void setID(string v)
        {
            id = v;
        }

        public string getID()
        {
            return id;
        }

        public void setName(string v)
        {
           name = v;
        }

        public string getName()
        {
            return name;
        }

        public void setMajor(string v)
        {
            major = v;
        }

        public string getMajor()
        {
            return major;
        }

        public void setMoney(string v)
        {
            money = v;
        }
        public string getMoney()
        {
            return money;
        }

        public void closeApp()
        {
        }

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

            public string UID { get => uID; set => uID = value; }
            public string UNAME { get => uNAME; set => uNAME = value; }
            public string UMAJOR { get => uMAJOR; set => uMAJOR = value; }
            public string UMONEY { get => uMONEY; set => uMONEY = value; }
        }

        public void ToggleFlag()
        {
            flag = true;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            if (flag)
            {
                e.ApplicationExitCode = 1;
            }
            else
            {
                e.ApplicationExitCode = 0;
            }
        }

        Uinfo ui;

        public Uinfo GetInfo()
        {
            return ui;
        }

    [System.Security.SecurityCritical]
   

        public string GetName()
        {
            return ui.UNAME;
        }

        public string GetMajor()
        {
            return ui.UMAJOR;
        }

        public string GetMoney()
        {
            return ui.UMONEY;
        }
        public void LoadMainView()
        {
            Window newW = new MainView();
            newW.Show();
        }

        public void SetInfo(string id, string name, string major, string money)
        {
            ui.UID = id;
            ui.UNAME = name;
            ui.UMAJOR = major;
            ui.UMONEY = money;
        }

        public void StartMainWindow()
        {
         
        }

        MainSock Msock = new MainSock();
        public bool nowConnect = false;
        public string nowConnectStatus = "false";


        public void StartSocket()
        {
            if (nowConnect == true) return;
            Msock.UserName = "Winterlood";
            Msock.makeSock();
            if (Msock.StartConnect())
            {
                MessageBox.Show("Success to Socket Connection!");
                nowConnect = true;
            }
            else
            {
                MessageBox.Show("Socket Connection Failed!");
                nowConnect = false;
            }
        }

        public void SendData(string text, string type)
        {
            if (nowConnect == false) StartSocket();
            if (type.Equals("<LOG>"))
                Msock.OnSendData(text, "<LOG>");
            else if (type.Equals("<REG>"))
                Msock.OnSendData(text, "<REG>");
            else if (type.Equals("<INF>"))
                Msock.OnSendData(text, "<INF>");
        }
        
        public void SendData(string text)
        {
            if (nowConnect == false) StartSocket();
            Msock.OnSendData(text, "<MSG>");
        }

    }
}
