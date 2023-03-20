using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Danhsachthisinh());
            //Application.Run(new QuanLy());
            //Application.Run(new Thi());
            //Application.Run(new Quanlycauhoi());
            //Application.Run(new Dienthongtin());
            //Application.Run(new Xemketquathichung());
            //Application.Run(new Doimatkhau());
        }
    }
}
