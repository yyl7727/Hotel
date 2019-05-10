namespace main.Frm
{
    partial class Main
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
            this.lv_room = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv_room
            // 
            this.lv_room.Location = new System.Drawing.Point(12, 12);
            this.lv_room.Name = "lv_room";
            this.lv_room.Size = new System.Drawing.Size(845, 274);
            this.lv_room.TabIndex = 0;
            this.lv_room.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 510);
            this.Controls.Add(this.lv_room);
            this.Name = "Main";
            this.Text = "XXXX酒店管理系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_room;
    }
}