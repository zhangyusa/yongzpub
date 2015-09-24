namespace YongTest.CSharp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entityFrameworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getContractNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getContractNoAsyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getContractNoAndBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 315);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entityFrameworkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entityFrameworkToolStripMenuItem
            // 
            this.entityFrameworkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getContractNoToolStripMenuItem,
            this.getContractNoAsyncToolStripMenuItem,
            this.getContractNoAndBalanceToolStripMenuItem});
            this.entityFrameworkToolStripMenuItem.Name = "entityFrameworkToolStripMenuItem";
            this.entityFrameworkToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.entityFrameworkToolStripMenuItem.Text = "Entity Framework";
            // 
            // getContractNoToolStripMenuItem
            // 
            this.getContractNoToolStripMenuItem.Name = "getContractNoToolStripMenuItem";
            this.getContractNoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.getContractNoToolStripMenuItem.Tag = "GetContractNo";
            this.getContractNoToolStripMenuItem.Text = "Get Contract No";
            this.getContractNoToolStripMenuItem.Click += new System.EventHandler(this.mMenuItemClickHandler);
            // 
            // getContractNoAsyncToolStripMenuItem
            // 
            this.getContractNoAsyncToolStripMenuItem.Name = "getContractNoAsyncToolStripMenuItem";
            this.getContractNoAsyncToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.getContractNoAsyncToolStripMenuItem.Tag = "GetContractNoAsync";
            this.getContractNoAsyncToolStripMenuItem.Text = "Get Contract No Async";
            this.getContractNoAsyncToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // getContractNoAndBalanceToolStripMenuItem
            // 
            this.getContractNoAndBalanceToolStripMenuItem.Name = "getContractNoAndBalanceToolStripMenuItem";
            this.getContractNoAndBalanceToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.getContractNoAndBalanceToolStripMenuItem.Tag = "GetContractNoAndBalance";
            this.getContractNoAndBalanceToolStripMenuItem.Text = "Get Contract No and Balance";
            this.getContractNoAndBalanceToolStripMenuItem.Click += new System.EventHandler(this.mMenuItemClickHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entityFrameworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getContractNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getContractNoAsyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getContractNoAndBalanceToolStripMenuItem;
    }
}

