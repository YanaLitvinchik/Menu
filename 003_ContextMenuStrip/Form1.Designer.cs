namespace _003_ContextMenuStrip
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
            this.contextMenuStripForButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonDesigner = new System.Windows.Forms.Button();
            this.туцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.туцтуцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripForButton
            // 
            this.contextMenuStripForButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.туцToolStripMenuItem,
            this.туцтуцToolStripMenuItem});
            this.contextMenuStripForButton.Name = "contextMenuStripForButton";
            this.contextMenuStripForButton.Size = new System.Drawing.Size(118, 48);
            // 
            // buttonDesigner
            // 
            this.buttonDesigner.ContextMenuStrip = this.contextMenuStripForButton;
            this.buttonDesigner.Location = new System.Drawing.Point(68, 68);
            this.buttonDesigner.Name = "buttonDesigner";
            this.buttonDesigner.Size = new System.Drawing.Size(75, 42);
            this.buttonDesigner.TabIndex = 1;
            this.buttonDesigner.Text = "designer\r\nbutton";
            this.buttonDesigner.UseVisualStyleBackColor = true;
            // 
            // туцToolStripMenuItem
            // 
            this.туцToolStripMenuItem.Name = "туцToolStripMenuItem";
            this.туцToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.туцToolStripMenuItem.Text = "&Туц";
            this.туцToolStripMenuItem.Click += new System.EventHandler(this.туцToolStripMenuItem_Click);
            // 
            // туцтуцToolStripMenuItem
            // 
            this.туцтуцToolStripMenuItem.Name = "туцтуцToolStripMenuItem";
            this.туцтуцToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.туцтуцToolStripMenuItem.Text = "Т&уц-туц";
            this.туцтуцToolStripMenuItem.Click += new System.EventHandler(this.туцтуцToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonDesigner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStripForButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripForButton;
        private System.Windows.Forms.ToolStripMenuItem туцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem туцтуцToolStripMenuItem;
        private System.Windows.Forms.Button buttonDesigner;
    }
}

