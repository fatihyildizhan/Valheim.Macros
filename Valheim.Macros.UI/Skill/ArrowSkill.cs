using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Valheim.Macros.UI.Skill
{
    public class ArrowSkill
    {
        public bool IsBreak { get; set; }

        public async Task StartArrowAsync()
        {
            Console.WriteLine("5 secs left to arrow");
            await Task.Delay(5000);

            int counter = 0;

            while (true)
            {
                if (IsBreak)
                {
                    SendKeys.Flush();
                    IsBreak = false;
                    break;
                }

                if (counter == 300)
                {
                    await Task.Delay(4000);
                    counter = 0;
                }
                else
                {
                    counter++;
                    SendKeys.Send("U");
                    await Task.Delay(100);
                }
            }
        }

        public void Stop()
        {
            IsBreak = true;
        }
    }
}