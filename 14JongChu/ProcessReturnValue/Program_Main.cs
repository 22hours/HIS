using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = new Process();
            proc.StartInfo.FileName = "C:\\Users\\jklh0\\source\\repos\\ConsoleApp5\\ConsoleApp5\\bin\\Debug\\ConsoleApp5.exe";
            proc.Start();
            proc.WaitForExit();

            if(proc.ExitCode == 10)
            {
                Console.WriteLine("code 10");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
