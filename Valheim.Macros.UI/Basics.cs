using System;
using System.Windows.Forms;
using System.Threading.Tasks;
// team
using Valheim.Macros.UI.Skill;

namespace Valheim.Macros.UI
{
    public partial class Basics : Form
    {
        public Basics()
        {
            InitializeComponent();
        }

        // skills
        JumpSkill jump = new JumpSkill();
        RunSkill run = new RunSkill();
        PrivacySkill privacy = new PrivacySkill();

        private async void btnJumpStart_Click(object sender, EventArgs e)
        {
            btnJumpStart.Enabled = false;
            await jump.StartJumpAsync();
        }

        private async void btnJumpStop_Click(object sender, EventArgs e)
        {
            jump.Stop();

            await Task.Delay(1000);
            btnJumpStart.Enabled = true;
        }

        private async void btnRunStart_Click(object sender, EventArgs e)
        {
            btnRunStart.Enabled = false;
            await run.StartRunAsync();
        }

        private async void btnRunStop_Click(object sender, EventArgs e)
        {
            run.Stop();

            await Task.Delay(1000);
            btnRunStart.Enabled = true;
        }

        private async void btnPrivacyStart_Click(object sender, EventArgs e)
        {
            btnPrivacyStart.Enabled = false;
            await privacy.StartPrivacyAsync();
        }

        private async void btnPrivacyStop_Click(object sender, EventArgs e)
        {
            privacy.Stop();

            await Task.Delay(1000);
            btnPrivacyStart.Enabled = true;
        }
    }
}
