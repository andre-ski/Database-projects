namespace Deliverable2_Login
{
    partial class ToyCategory
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
            this.comboBoxToy = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.listBoxToy = new System.Windows.Forms.ListBox();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.buttonAvailable = new System.Windows.Forms.Button();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxToy
            // 
            this.comboBoxToy.FormattingEnabled = true;
            this.comboBoxToy.Location = new System.Drawing.Point(252, 22);
            this.comboBoxToy.Name = "comboBoxToy";
            this.comboBoxToy.Size = new System.Drawing.Size(151, 21);
            this.comboBoxToy.TabIndex = 0;
            this.comboBoxToy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(27, 22);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(219, 22);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category Selection:";
            // 
            // listBoxToy
            // 
            this.listBoxToy.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxToy.FormattingEnabled = true;
            this.listBoxToy.ItemHeight = 14;
            this.listBoxToy.Location = new System.Drawing.Point(31, 60);
            this.listBoxToy.Name = "listBoxToy";
            this.listBoxToy.Size = new System.Drawing.Size(605, 368);
            this.listBoxToy.TabIndex = 2;
            this.listBoxToy.SelectedIndexChanged += new System.EventHandler(this.listBoxToy_SelectedIndexChanged);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.Location = new System.Drawing.Point(31, 448);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(132, 58);
            this.buttonBorrow.TabIndex = 3;
            this.buttonBorrow.Text = "Borrow Toy";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Request Rural Delivery";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(533, 480);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(103, 26);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 15;
            this.listBoxStatus.Location = new System.Drawing.Point(521, 25);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(115, 19);
            this.listBoxStatus.TabIndex = 7;
            this.listBoxStatus.SelectedIndexChanged += new System.EventHandler(this.listBoxStatus_SelectedIndexChanged);
            // 
            // buttonAvailable
            // 
            this.buttonAvailable.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvailable.Location = new System.Drawing.Point(307, 448);
            this.buttonAvailable.Name = "buttonAvailable";
            this.buttonAvailable.Size = new System.Drawing.Size(132, 58);
            this.buttonAvailable.TabIndex = 8;
            this.buttonAvailable.Text = "Show Available";
            this.buttonAvailable.UseVisualStyleBackColor = true;
            this.buttonAvailable.Click += new System.EventHandler(this.buttonAvailable_Click);
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember.Location = new System.Drawing.Point(478, 446);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(64, 16);
            this.labelMember.TabIndex = 9;
            this.labelMember.Text = "Member:";
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberID.Location = new System.Drawing.Point(548, 446);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(80, 16);
            this.labelMemberID.TabIndex = 10;
            this.labelMemberID.Text = "member_id";
            this.labelMemberID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelMemberID.Click += new System.EventHandler(this.labelMemberID_Click);
            // 
            // ToyCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 540);
            this.Controls.Add(this.labelMemberID);
            this.Controls.Add(this.labelMember);
            this.Controls.Add(this.buttonAvailable);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.listBoxToy);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxToy);
            this.Name = "ToyCategory";
            this.Text = "ToyCategory";
            this.Load += new System.EventHandler(this.ToyCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxToy;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ListBox listBoxToy;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button buttonAvailable;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelMemberID;
    }
}