namespace transFormat
{
    using System;
    using System.Windows.Forms;
    using System.Threading;

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///<summary>
            ///开始监控共享文件夹
            /// </summary>
            MThread mThread = new MThread();
            ThreadStart entry = new ThreadStart(mThread.Monitor);
            Thread workThread = new Thread(entry);
            workThread.IsBackground = true;
            workThread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new SearchForm());
        }
    }
}
