using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcessi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercitazione sulla gestione dei processi");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe", @"\\192.168.5.250\\_Condivisa\\INF\\4 A\\Manuel Pierini\\Tepsit\\AppProcessi\\AppProcessi\\TextFile1.txt");
            Process.Start("Chrome.exe", @"https://it.wikipedia.org/wiki/Federico_Melchiorri");
            var app = new Process();
            app.StartInfo.FileName = "Notepad.exe";
            app.StartInfo.Arguments = @"\\192.168.5.250\\_Condivisa\\INF\\4 A\\Manuel Pierini\\Tepsit\\AppProcessi\\AppProcessi\\TextFile1.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            app.WaitForExit();
            Console.WriteLine("programma terminato");
            Console.ReadLine();
        }
    }
}
