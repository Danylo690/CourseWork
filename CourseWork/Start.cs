using CourseWork.Classes;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    public static class Start
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
