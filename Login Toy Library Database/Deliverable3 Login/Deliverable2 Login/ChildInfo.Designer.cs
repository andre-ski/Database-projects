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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxChildInfo
            // 
            this.listBoxChildInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChildInfo.FormattingEnabled = true;
            this.listBoxChildInfo.ItemHeight = 14;
            this.listBoxChildInfo.Location = new System.Drawing.Point(29, 60);
            this.listBoxChildInfo.Name = "listBoxChildInfo";
            this.listBoxChildInfo.Size = new System.Drawing.Size(1344, 452);
            this.listBoxChildInfo.TabIndex = 0;
            this.listBoxChildInfo.SelectedIndexChanged += new System.EventHandler(this.listBoxChildInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registered Children";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(1270, 581);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(103, 26);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember.Location = new System.Drawing.Point(1175, 542);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(112, 16);
            this.labelMember.TabIndex = 10;
            this.labelMember.Text = "Staff Member:";
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffID.Location = new System.Drawing.Point(1293, 542);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(80, 16);
            this.labelStaffID.TabIndex = 11;
            this.labelStaffID.Text = "member_id";
            this.labelStaffID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ChildInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 619);
            this.Controls.Add(this.labelStaffID);
            this.Controls.Add(this.labelMember);
            this.Controls.Add(this.buttonLogOut);
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
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelStaffID;
    }
}