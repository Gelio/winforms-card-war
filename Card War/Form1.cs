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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += confirmClosing;
            this.openNewGameWindow();
        }

        private void confirmClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(this, "Do you really want to exit?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("War card game, created for Windows Programming class");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openNewGameWindow()
        {
            NewGameWindow newGame = new NewGameWindow();
            newGame.FormClosing += confirmClosing;
            newGame.FormClosed += NewGame_FormClosed;
            newGame.newGameStarted += newGameStarted;
            newGame.Show();
        }

        private void NewGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormClosing -= confirmClosing;
            this.Close();
        }

        private void newGameStarted(object sender, EventArgs e)
        {
            NewGameWindow newGame = sender as NewGameWindow;
            newGame.FormClosing -= confirmClosing;
            newGame.FormClosed -= NewGame_FormClosed;
            newGame.Close();
            Opacity = 100;
            ShowInTaskbar = true;
            this.Show();
            this.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            ShowInTaskbar = false;
        }
    }
}
