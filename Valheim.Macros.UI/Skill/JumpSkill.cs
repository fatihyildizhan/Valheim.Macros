using System;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Valheim.Macros.UI.Skill
{
    public class JumpSkill
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //public static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        public bool IsBreak { get; set; }

        public async Task StartJumpAsync()
        {
            Console.WriteLine("5 secs left");
            await Task.Delay(5000);

            while (true)
            {
                if (IsBreak)
                {
                    SendKeys.Flush();
                    IsBreak = false;
                    break;
                }

                //const int WM_SYSKEYDOWN = 0x0104;
                //const int VK_SPACE = 0x20;

                //IntPtr WindowToFind = FindWindow(null, "notes");
                //PostMessage(WindowToFind, WM_SYSKEYDOWN, VK_SPACE, 0);
                //await Task.Delay(2500);
                

                //Process p = Process.GetProcessesByName("valheim").FirstOrDefault();
                //if (p != null)
                //{
                //    IntPtr handle = p.MainWindowHandle;

                    

                //    PostMessage(handle, WM_SYSKEYDOWN, VK_SPACE, 0);

                //    //SendKeys.Send(" ");
                //    await Task.Delay(2500);
                //}
            }
        }

        public void Stop()
        {
            IsBreak = true;
        }
    }
}