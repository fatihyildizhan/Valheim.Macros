﻿using System.Runtime.InteropServices;

namespace Valheim.Macros.UI.Extensions
{
    public class Keyboard
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        const int KEY_DOWN_EVENT = 0x0001; //Key down flag
        const int KEY_UP_EVENT = 0x0002; //Key up flag

        public static void HoldKey(byte key, int duration)
        {
            keybd_event(key, 0, KEY_DOWN_EVENT, 0);
            System.Threading.Thread.Sleep(duration);
            keybd_event(key, 0, KEY_UP_EVENT, 0);
        }
    }
}