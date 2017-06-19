namespace BankBlack30102016
{
    partial class AddNewDebtor
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
            this.grb_DebitorInfo = new System.Windows.Forms.GroupBox();
            this.label_PersonalIdNumber = new System.Windows.Forms.Label();
            this.label_SurName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.txb_PersonalIdNumber = new System.Windows.Forms.TextBox();
            this.txb_SurName = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.btn_AddNewDebitor = new System.Windows.Forms.Button();
            this.grb_DebitorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_DebitorInfo
            // 
            this.grb_DebitorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_DebitorInfo.Controls.Add(this.label_PersonalIdNumber);
            this.grb_DebitorInfo.Controls.Add(this.label_SurName);
            this.grb_DebitorInfo.Controls.Add(this.label_LastName);
            this.grb_DebitorInfo.Controls.Add(this.label_FirstName);
            this.grb_DebitorInfo.Controls.Add(this.txb_PersonalIdNumber);
            this.grb_DebitorInfo.Controls.Add(this.txb_SurName);
            this.grb_DebitorInfo.Controls.Add(this.txb_LastName);
            this.grb_DebitorInfo.Controls.Add(this.txb_FirstName);
            this.grb_DebitorInfo.Location = new System.Drawing.Point(12, 12);
            this.grb_DebitorInfo.Name = "grb_DebitorInfo";
            this.grb_DebitorInfo.Size = new System.Drawing.Size(409, 134);
            this.grb_DebitorInfo.TabIndex = 3;
            this.grb_DebitorInfo.TabStop = false;
            this.grb_DebitorInfo.Text = "Інформація про дебітора";
            // 
            // label_PersonalIdNumber
            // 
            this.label_PersonalIdNumber.AutoSize = true;
            this.label_PersonalIdNumber.Location = new System.Drawing.Point(19, 102);
            this.label_PersonalIdNumber.Name = "label_PersonalIdNumber";
            this.label_PersonalIdNumber.Size = new System.Drawing.Size(150, 13);
            this.label_PersonalIdNumber.TabIndex = 7;
            this.label_PersonalIdNumber.Text = "Ідентифікаційний номер ФО";
            // 
            // label_SurName
            // 
            this.label_SurName.AutoSize = true;
            this.label_SurName.Location = new System.Drawing.Point(19, 76);
            this.label_SurName.Name = "label_SurName";
            this.label_SurName.Size = new System.Drawing.Size(67, 13);
            this.label_SurName.TabIndex = 6;
            this.label_SurName.Text = "По батькові";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(19, 50);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(48, 13);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Фамілія";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(19, 22);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(26, 13);
            this.label_FirstName.TabIndex = 4;
            this.label_FirstName.Text = "Ім\'я";
            // 
            // txb_PersonalIdNumber
            // 
            this.txb_PersonalIdNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PersonalIdNumber.Location = new System.Drawing.Point(175, 99);
            this.txb_PersonalIdNumber.MaxLength = 10;
            this.txb_PersonalIdNumber.Name = "txb_PersonalIdNumber";
            this.txb_PersonalIdNumber.Size = new System.Drawing.Size(216, 20);
            this.txb_PersonalIdNumber.TabIndex = 3;
            this.txb_PersonalIdNumber.TextChanged += new System.EventHandler(this.txb_PersonalIdNumber_TextChanged);
            this.txb_PersonalIdNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_PersonalIdNumber_KeyPress);
            // 
            // txb_SurName
            // 
            this.txb_SurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SurName.Location = new System.Drawing.Point(175, 73);
            this.txb_SurName.Name = "txb_SurName";
            this.txb_SurName.Size = new System.Drawing.Size(216, 20);
            this.txb_SurName.TabIndex = 2;
            this.txb_SurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_SurName_KeyPress);
            // 
            // txb_LastName
            // 
            this.txb_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_LastName.Location = new System.Drawing.Point(175, 47);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(216, 20);
            this.txb_LastName.TabIndex = 1;
            this.txb_LastName.TextChanged += new System.EventHandler(this.txb_LastName_TextChanged);
            this.txb_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_LastName_KeyPress);
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_FirstName.Location = new System.Drawing.Point(175, 19);
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(216, 20);
            this.txb_FirstName.TabIndex = 0;
            this.txb_FirstName.TextChanged += new System.EventHandler(this.txb_FirstName_TextChanged);
            this.txb_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_FirstName_KeyPress);
            // 
            // btn_AddNewDebitor
            // 
            this.btn_AddNewDebitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNewDebitor.Enabled = false;
            this.btn_AddNewDebitor.Location = new System.Drawing.Point(346, 152);
            this.btn_AddNewDebitor.Name = "btn_AddNewDebitor";
            this.btn_AddNewDebitor.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNewDebitor.TabIndex = 4;
            this.btn_AddNewDebitor.Text = "Додати";
            this.btn_AddNewDebitor.UseVisualStyleBackColor = true;
            this.btn_AddNewDebitor.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewDebtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 190);
            this.Controls.Add(this.btn_AddNewDebitor);
            this.Controls.Add(this.grb_DebitorInfo);
            this.Name = "AddNewDebtor";
            this.Text = "Новий дебітор";
            this.grb_DebitorInfo.ResumeLayout(false);
            this.grb_DebitorInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_DebitorInfo;
        private System.Windows.Forms.Label label_PersonalIdNumber;
        private System.Windows.Forms.Label label_SurName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox txb_PersonalIdNumber;
        private System.Windows.Forms.TextBox txb_SurName;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.TextBox txb_FirstName;
        private System.Windows.Forms.Button btn_AddNewDebitor;
    }
}