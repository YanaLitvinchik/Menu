namespace GameButton
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Speed = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedOne = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedThree = new System.Windows.Forms.ToolStripMenuItem();
            this.HelloButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.GameMenu,
            this.Speed});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GameMenu
            // 
            this.GameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(50, 20);
            this.GameMenu.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start ";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // Speed
            // 
            this.Speed.Checked = true;
            this.Speed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Speed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedOne,
            this.SpeedTwo,
            this.SpeedThree});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(51, 20);
            this.Speed.Text = "Speed";
            // 
            // SpeedOne
            // 
            this.SpeedOne.Checked = true;
            this.SpeedOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeedOne.Name = "SpeedOne";
            this.SpeedOne.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.SpeedOne.Size = new System.Drawing.Size(152, 22);
            this.SpeedOne.Text = "1";
            this.SpeedOne.Click += new System.EventHandler(this.SpeedOne_Click);
            // 
            // SpeedTwo
            // 
            this.SpeedTwo.Name = "SpeedTwo";
            this.SpeedTwo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.SpeedTwo.Size = new System.Drawing.Size(152, 22);
            this.SpeedTwo.Text = "2";
            this.SpeedTwo.Click += new System.EventHandler(this.SpeedTwo_Click);
            // 
            // SpeedThree
            // 
            this.SpeedThree.Name = "SpeedThree";
            this.SpeedThree.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.SpeedThree.Size = new System.Drawing.Size(152, 22);
            this.SpeedThree.Text = "3";
            this.SpeedThree.Click += new System.EventHandler(this.SpeedThree_Click);
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(127, 123);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(55, 42);
            this.HelloButton.TabIndex = 1;
            this.HelloButton.Text = "Hello";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            this.HelloButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 274);
            this.Controls.Add(this.HelloButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GameMenu;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Speed;
        private System.Windows.Forms.ToolStripMenuItem SpeedOne;
        private System.Windows.Forms.ToolStripMenuItem SpeedTwo;
        private System.Windows.Forms.ToolStripMenuItem SpeedThree;
        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Timer timer1;
    }
}

