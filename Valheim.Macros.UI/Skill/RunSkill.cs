using System;
using System.Windows.Forms;
using System.Threading.Tasks;
// team
using Valheim.Macros.UI.Extensions;

namespace Valheim.Macros.UI.Skill
{
    public class RunSkill
    {
        public bool IsBreak { get; set; }

        public async Task StartRunAsync()
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

                Keyboard.HoldKey((byte)Keys.LShiftKey, 15000);
                await Task.Delay(10);
                Keyboard.HoldKey((byte)Keys.W, 15000);
                Console.WriteLine("relax");
                await Task.Delay(3200);
            }
        }

        public void Stop()
        {
            IsBreak = true;
        }
    }
}