﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LangCotrol());//彥的測試啟動頁
            //Application.Run(new FrmSearch_Fang());  //坊的測試啟動頁
            Application.Run(new FrmIndex());  //潔的測試啟動頁
            //Application.Run(new Order_Page()); //訂單頁

        }
    }
}
