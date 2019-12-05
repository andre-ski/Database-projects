namespace Deliverable2_Login
{
    partial class ChildInfo
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
            this.listBoxChildInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxChildInfo
            // 
            this.listBoxChildInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChildInfo.FormattingEnabled = true;
            this.listBoxChildInfo.ItemHeight = 14;
            this.listBoxChildInfo.Location = new System.Drawing.Point(29, 90);
            this.listBoxChildInfo.Name = "listBoxChildInfo";
            this.listBoxChildInfo.Size = new System.Drawing.Size(1363, 452);
            this.listBoxChildInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(231, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Children Registered In Database";
            // 
            // ChildInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxChildInfo);
            this.Name = "ChildInfo";
            this.Text = "ChildInfo";
            this.Load += new System.EventHandler(this.ChildInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChildInfo;
        private System.Windows.Forms.Label label1;
    }
}