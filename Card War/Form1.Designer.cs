namespace Card_War
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cpuCards = new System.Windows.Forms.Button();
            this.cpuScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.cpuCard = new System.Windows.Forms.Button();
            this.userCards = new System.Windows.Forms.Button();
            this.roundNumberLabel = new System.Windows.Forms.Label();
            this.userScore = new System.Windows.Forms.Label();
            this.userCard = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.cpuCards, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuScore, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.user, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cpuCard, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.userCards, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.roundNumberLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.userScore, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.userCard, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 446);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cpuCards
            // 
            this.cpuCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuCards.Location = new System.Drawing.Point(3, 23);
            this.cpuCards.Name = "cpuCards";
            this.cpuCards.Size = new System.Drawing.Size(224, 173);
            this.cpuCards.TabIndex = 0;
            this.cpuCards.Text = "CPU cards";
            this.cpuCards.UseVisualStyleBackColor = true;
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuScore.Location = new System.Drawing.Point(464, 20);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(226, 179);
            this.cpuScore.TabIndex = 2;
            this.cpuScore.Text = "CPU points:          x";
            this.cpuScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Dock = System.Windows.Forms.DockStyle.Right;
            this.user.Location = new System.Drawing.Point(661, 425);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(29, 21);
            this.user.TabIndex = 1;
            this.user.Text = "User";
            // 
            // cpuCard
            // 
            this.cpuCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuCard.Location = new System.Drawing.Point(233, 23);
            this.cpuCard.Name = "cpuCard";
            this.cpuCard.Size = new System.Drawing.Size(225, 173);
            this.cpuCard.TabIndex = 4;
            this.cpuCard.UseVisualStyleBackColor = true;
            // 
            // userCards
            // 
            this.userCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userCards.Location = new System.Drawing.Point(464, 249);
            this.userCards.Name = "userCards";
            this.userCards.Size = new System.Drawing.Size(226, 173);
            this.userCards.TabIndex = 0;
            this.userCards.Text = "User cards";
            this.userCards.UseVisualStyleBackColor = true;
            this.userCards.Click += new System.EventHandler(this.userCards_Click);
            // 
            // roundNumberLabel
            // 
            this.roundNumberLabel.AutoSize = true;
            this.roundNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundNumberLabel.Location = new System.Drawing.Point(233, 199);
            this.roundNumberLabel.Name = "roundNumberLabel";
            this.roundNumberLabel.Size = new System.Drawing.Size(225, 47);
            this.roundNumberLabel.TabIndex = 6;
            this.roundNumberLabel.Text = "Round: x of x";
            this.roundNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userScore
            // 
            this.userScore.AutoSize = true;
            this.userScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userScore.Location = new System.Drawing.Point(3, 246);
            this.userScore.Name = "userScore";
            this.userScore.Size = new System.Drawing.Size(224, 179);
            this.userScore.TabIndex = 3;
            this.userScore.Text = "User points:       x";
            this.userScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userCard
            // 
            this.userCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCard.Location = new System.Drawing.Point(233, 249);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(225, 173);
            this.userCard.TabIndex = 5;
            this.userCard.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "War card game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cpuCards;
        private System.Windows.Forms.Label cpuScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userScore;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button cpuCard;
        private System.Windows.Forms.Button userCard;
        private System.Windows.Forms.Button userCards;
        private System.Windows.Forms.Label roundNumberLabel;
    }
}

