namespace main.Frm
{
    partial class adminFrm
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
            this.新增AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增AToolStripMenuItem
            // 
            this.新增AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工ToolStripMenuItem,
            this.房间ToolStripMenuItem,
            this.商品ToolStripMenuItem});
            this.新增AToolStripMenuItem.Name = "新增AToolStripMenuItem";
            this.新增AToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.新增AToolStripMenuItem.Text = "新增（&A）";
            // 
            // 员工ToolStripMenuItem
            // 
            this.员工ToolStripMenuItem.Name = "员工ToolStripMenuItem";
            this.员工ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工ToolStripMenuItem.Text = "员工";
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品ToolStripMenuItem.Text = "商品";
            // 
            // 房间ToolStripMenuItem
            // 
            this.房间ToolStripMenuItem.Name = "房间ToolStripMenuItem";
            this.房间ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间ToolStripMenuItem.Text = "房间";
            // 
            // adminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 556);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminFrm";
            this.Text = "管理员页";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
    }
}