using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Valheim.Macros.UI.Skill
{
    public class JumpSkill
    {
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

                SendKeys.Send(" ");
                await Task.Delay(2500);
            }
        }

        public void Stop()
        {
            IsBreak = true;
        }
    }
}