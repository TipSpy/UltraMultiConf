using System;
using System.Drawing;
using System.Windows.Forms;

namespace UltraMultiConf.Classes
{
    class Logger
    {
        public static RichTextBox LogRTB;
        public static void Log(string message)
        {
            WriteLine(message, Color.White);
        }
        public static void Info(string message)
        {
            WriteLine(message, Color.Cyan);
        }
        public static void List(string message)
        {
            WriteLine(message, Color.Blue);
        }
        public static void Good(string message)
        {
            WriteLine(message, Color.Lime);
        }
        public static void Warning(string message)
        {
            WriteLine(message, Color.Orange);
        }
        public static void Error(string message)
        {
            WriteLine(message, Color.Red);
        }
        private static void WriteLine(string message, Color color)
        {
            Action append = new Action(() => {
                LogRTB.SelectionColor = color;
                LogRTB.AppendText(DateTime.Now.ToLocalTime().ToShortTimeString() + ": " + message + "\n");
                LogRTB.ScrollToCaret();
            });
            if (LogRTB.InvokeRequired)
            {
                LogRTB.Invoke(append);
            }
            else
            {
                append.Invoke();
            }
        }
    }
}
