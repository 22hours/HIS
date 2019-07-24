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
        SerialPort device = new SerialPort();

        public static void scanPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                MessageBox.Show(port);
            }
            string query = "SELECT PNPDeviceID FROM Win32_Printer";
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

        /// method to retrieve the selected HDD's serial number
        ///

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


        }



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
