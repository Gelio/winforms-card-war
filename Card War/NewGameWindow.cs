using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_War
{
    public partial class NewGameWindow : Form
    {
        public event EventHandler newGameStarted;

        public NewGameWindow()
        {
            InitializeComponent();
        }

        private bool ValidateData()
        {
            if (username.Text.Length < 3)
            {
                MessageBox.Show(this, "User name must have at least 3 characters");
                return false;
            }

            if (cpuName.Text.Length < 3)
            {
                MessageBox.Show(this, "CPU name must have at least 3 characters");
                return false;
            }

            int roundsCount = (int)numberOfRounds.Value;
            if (roundsCount <= 0)
            {
                MessageBox.Show(this, "You must play at least one round");
                return false;
            }

            return true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateData())
                newGameStarted?.Invoke(this, e);
        }
    }
}
