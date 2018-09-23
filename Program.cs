using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Bilgisayar_Console_App
{
    
    class Program
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        static void Main(string[] args)
        {
			Console.Write("\t\tUygulamamıza Hoşgeldiniz\n"); 
            char secim;
            Console.Write("1-Bilgisayarı Kapat\n2-Bilgisayarı Yeniden Başlat\n3-Bilgisayarı Kilitle\n4-Bilgisayar Oturumu Kapat\nSeçim: ");
            secim = char.Parse(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    System.Diagnostics.Process.Start("shutdown.exe", "-s -t 00");
                    break;
                case '2':
                    System.Diagnostics.Process.Start("shutdown.exe", "-r -t 00");
                    break;
                case '3':
                    LockWorkStation();
                    break;
                case '4':
                    ExitWindowsEx(0, 0);
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim Yapıldı!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
