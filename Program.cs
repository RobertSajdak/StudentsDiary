using System;
using System.IO;
using System.Windows.Forms;

namespace StudentsDiary
{
    static class Program
    {
        public static string FilePath =
            Path.Combine(Environment.CurrentDirectory, "students.txt");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}