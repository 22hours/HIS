using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO.Ports;

namespace PrinterControl
{
    class PrinterDevicePortEventMonitor
    {
        public static void GetHDDSerialNumber(string drive)
        {
            string query1 = "SELECT * FROM Win32_PrintJob";

            ManagementObjectSearcher mso1 = new ManagementObjectSearcher(query1);
            ManagementObjectCollection aa = mso1.Get();
            //ManagementObject MO = new ManagementObject();
            foreach (ManagementObject mo in aa)
            {
                //MO.InvokeMethod("Pause", mo, null);
                MessageBox.Show("\nTotalPages = " + mo.Properties["TotalPages"].Value.ToString());
            }
        }


        /*
        SerialPort device = new SerialPort();

        public static void scanPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                MessageBox.Show(port);
            }
            string query = "SELECT device FROM Win32_Printer";
            ManagementObjectSearcher mso = new ManagementObjectSearcher(query);
            foreach (ManagementObject mo in mso.Get())
            {
                MessageBox.Show(mo.ToString());
            }

        }

        public static void catchPrint()
        {
            string query1 = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher mso1 = new ManagementObjectSearcher(query1);
            foreach (ManagementObject mo in mso1.Get())

            {
                MessageBox.Show(mo.ToString());
            }
        }
        */

        /// method to retrieve the selected HDD's serial number
        ///

        /*
        /// Drive letter to retrieve serial number for
        public static void GetHDDSerialNumber(string drive)
        {

            

            //check to see if the user provided a drive letter
            //if not default it to "C"
            if (drive == "" || drive == null)
            {
                drive = "C";
            }
            //create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL

            //ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            //bind our management object
            disk.Get();
            //return the serial number
            //MessageBox.Show(disk["VolumeSerialNumber"].ToString());
            string query = "SELECT * FROM Win32_Printer";
            ManagementObjectSearcher mso = new ManagementObjectSearcher(query);
            foreach (ManagementObject mo in mso.Get())

            {
                MessageBox.Show(mo.ToString());
            }
            


            //ManagementScope oMs = new ManagementScope("\\\\DESKTOP-V07PAKS\\root\\cimv2");
            //ManagementScope oMs = new ManagementScope(@"\\" + COMPUTERNAME + @"\root\cimv2");
            //oMs.Connect();
            //var osQuery = new SelectQuery("Win32_OperatingSystem");
            //ManagementObjectSearcher mso1 = new ManagementObjectSearcher(oMs,osQuery);

            string query1 = "SELECT * FROM Win32_PrintJob";
            
            ManagementObjectSearcher mso1 = new ManagementObjectSearcher(query1);
            ManagementObjectCollection aa = mso1.Get();
            ManagementObject MO = new ManagementObject();
            foreach (ManagementObject mo in aa)
            {
                MessageBox.Show("JobId = " + mo.Properties["JobId"].Value.ToString()
                    + "\nTotalPages = " + mo.Properties["TotalPages"].Value.ToString() 
                    + "\n PagesPrinted = " + mo.Properties["PagesPrinted"].Value.ToString());            
            }
            
            

        }
        */
        /*
        public static void asdf()
        {
            
            string query = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher mso = new ManagementObjectSearcher(query);
            foreach (ManagementObject mo in mso.Get())
            {
                //while (true)
                {
                    
                    MessageBox.Show(mo["TotalPages"].ToString());
                }

            }
            

            ManagementEventWatcher manEWatch;
            ManagementScope oMs = new ManagementScope("\\\\FAN\\root\\cimv2"); 
            //ManagementScope oMs = new ManagementScope(@"\\" + COMPUTERNAME + @"\root\cimv2");
            oMs.Connect();
            manEWatch = new ManagementEventWatcher(oMs, new EventQuery("SELECT * FROM    __InstanceCreationEvent WITHIN 0.1 WHERE TargetInstance ISA 'Win32_PrintJob'"));
            manEWatch.EventArrived += new EventArrivedEventHandler(mewPrintJobs_EventArrived);
            manEWatch.Start();
        }
        static void mewPrintJobs_EventArrived(object sender, EventArrivedEventArgs e)
        {
            foreach (PropertyData prop in e.NewEvent.Properties)
            {
                string val = prop.Value == null ? "null" : prop.Value.ToString();

            }

            ManagementBaseObject printJob = (ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value;
            string v = "";
            foreach (PropertyData propp in printJob.Properties)
            {
                string name = propp.Name;
                string val = propp.Value == null ? "null" : propp.Value.ToString();
                val += "\n";
                v += name + ":" + val;

            }
            MessageBox.Show(v);
        }
        */
        
        /*
        [DllImport("winspool.drv")]
        private static extern bool OpenPrinter(string printerName, out IntPtr phPrinter, ref PrinterDefaults printerDefaults);
        [DllImport("winspool.drv")]
        private static extern bool ClosePrinter(IntPtr phPrinter);
        [DllImport("winspool.drv", CharSet = CharSet.Unicode)]
        private static extern bool XcvDataW(IntPtr hXcv, string pszDataName, IntPtr pInputData, UInt32 cbInputData, out IntPtr pOutputData, UInt32 cbOutputData, out UInt32 pcbOutputNeeded, out UInt32 pdwStatus);
        ManagementObject portObject = portClass.CreateInstance();
        */
    }
}
