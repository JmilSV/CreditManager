namespace BankBlack30102016
{
    partial class ViewMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_Debitors = new System.Windows.Forms.GroupBox();
            this.dgv_Debitors = new System.Windows.Forms.DataGridView();
            this.grb_DebitorInfo = new System.Windows.Forms.GroupBox();
            this.label_PersonalIdNumber = new System.Windows.Forms.Label();
            this.label_SurName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.txb_PersonalIdNumber = new System.Windows.Forms.TextBox();
            this.txb_SurName = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.txb_FIrstName = new System.Windows.Forms.TextBox();
            this.grb_Credits = new System.Windows.Forms.GroupBox();
            this.dgv_Credits = new System.Windows.Forms.DataGridView();
            this.grb_Payments = new System.Windows.Forms.GroupBox();
            this.dgv_Payments = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grb_Debitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debitors)).BeginInit();
            this.grb_DebitorInfo.SuspendLayout();
            this.grb_Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).BeginInit();
            this.grb_Payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorToolStripMenuItem,
            this.CreditToolStripMenuItem,
            this.PaymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // AddToFileToolStripMenuItem
            // 
            this.AddToFileToolStripMenuItem.Name = "AddToFileToolStripMenuItem";
            this.AddToFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AddToFileToolStripMenuItem.Text = "Записати у файл";
            this.AddToFileToolStripMenuItem.Click += new System.EventHandler(this.AddToFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorToolStripMenuItem
            // 
            this.debitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorToolStripMenuItem.Name = "debitorToolStripMenuItem";
            this.debitorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.debitorToolStripMenuItem.Text = "Дебітор";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Додати нового дебітора";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // CreditToolStripMenuItem
            // 
            this.CreditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCreditToolStripMenuItem});
            this.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem";
            this.CreditToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.CreditToolStripMenuItem.Text = "Кредит";
            // 
            // AddNewCreditToolStripMenuItem
            // 
            this.AddNewCreditToolStripMenuItem.Name = "AddNewCreditToolStripMenuItem";
            this.AddNewCreditToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.AddNewCreditToolStripMenuItem.Text = "Видати новий кредит";
            this.AddNewCreditToolStripMenuItem.Click += new System.EventHandler(this.AddNewCreditToolStripMenuItem_Click);
            // 
            // PaymentToolStripMenuItem
            // 
            this.PaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewPaymentToolStripMenuItem});
            this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            this.PaymentToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.PaymentToolStripMenuItem.Text = "Платіж";
            // 
            // AddNewPaymentToolStripMenuItem
            // 
            this.AddNewPaymentToolStripMenuItem.Name = "AddNewPaymentToolStripMenuItem";
            this.AddNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.AddNewPaymentToolStripMenuItem.Text = "Додати новий платіж";
            this.AddNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.AddNewPaymentToolStripMenuItem_Click);
            // 
            // grb_Debitors
            // 
            this.grb_Debitors.Controls.Add(this.dgv_Debitors);
            this.grb_Debitors.Location = new System.Drawing.Point(39, 39);
            this.grb_Debitors.Name = "grb_Debitors";
            this.grb_Debitors.Size = new System.Drawing.Size(243, 134);
            this.grb_Debitors.TabIndex = 1;
            this.grb_Debitors.TabStop = false;
            this.grb_Debitors.Text = "Дебітори";
            // 
            // dgv_Debitors
            // 
            this.dgv_Debitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Debitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Debitors.Location = new System.Drawing.Point(3, 16);
            this.dgv_Debitors.Name = "dgv_Debitors";
            this.dgv_Debitors.Size = new System.Drawing.Size(237, 115);
            this.dgv_Debitors.TabIndex = 0;
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
            this.grb_DebitorInfo.Controls.Add(this.txb_FIrstName);
            this.grb_DebitorInfo.Location = new System.Drawing.Point(288, 39);
            this.grb_DebitorInfo.Name = "grb_DebitorInfo";
            this.grb_DebitorInfo.Size = new System.Drawing.Size(401, 134);
            this.grb_DebitorInfo.TabIndex = 2;
            this.grb_DebitorInfo.TabStop = false;
            this.grb_DebitorInfo.Text = "Інформація про дебітора";
            // 
            // label_PersonalIdNumber
            // 
            this.label_PersonalIdNumber.AutoSize = true;
            this.label_PersonalIdNumber.Location = new System.Drawing.Point(19, 106);
            this.label_PersonalIdNumber.Name = "label_PersonalIdNumber";
            this.label_PersonalIdNumber.Size = new System.Drawing.Size(128, 13);
            this.label_PersonalIdNumber.TabIndex = 7;
            this.label_PersonalIdNumber.Text = "Ідентифікаційний номер";
            // 
            // label_SurName
            // 
            this.label_SurName.AutoSize = true;
            this.label_SurName.Location = new System.Drawing.Point(19, 80);
            this.label_SurName.Name = "label_SurName";
            this.label_SurName.Size = new System.Drawing.Size(67, 13);
            this.label_SurName.TabIndex = 6;
            this.label_SurName.Text = "По батькові";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(19, 54);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(48, 13);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Фамілія";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(19, 26);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(26, 13);
            this.label_FirstName.TabIndex = 4;
            this.label_FirstName.Text = "Ім\'я";
            // 
            // txb_PersonalIdNumber
            // 
            this.txb_PersonalIdNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PersonalIdNumber.Location = new System.Drawing.Point(153, 99);
            this.txb_PersonalIdNumber.Name = "txb_PersonalIdNumber";
            this.txb_PersonalIdNumber.ReadOnly = true;
            this.txb_PersonalIdNumber.Size = new System.Drawing.Size(230, 20);
            this.txb_PersonalIdNumber.TabIndex = 3;
            // 
            // txb_SurName
            // 
            this.txb_SurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SurName.Location = new System.Drawing.Point(153, 73);
            this.txb_SurName.Name = "txb_SurName";
            this.txb_SurName.ReadOnly = true;
            this.txb_SurName.Size = new System.Drawing.Size(230, 20);
            this.txb_SurName.TabIndex = 2;
            // 
            // txb_LastName
            // 
            this.txb_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_LastName.Location = new System.Drawing.Point(153, 47);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.ReadOnly = true;
            this.txb_LastName.Size = new System.Drawing.Size(230, 20);
            this.txb_LastName.TabIndex = 1;
            // 
            // txb_FIrstName
            // 
            this.txb_FIrstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_FIrstName.Location = new System.Drawing.Point(153, 19);
            this.txb_FIrstName.Name = "txb_FIrstName";
            this.txb_FIrstName.ReadOnly = true;
            this.txb_FIrstName.Size = new System.Drawing.Size(230, 20);
            this.txb_FIrstName.TabIndex = 0;
            // 
            // grb_Credits
            // 
            this.grb_Credits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Credits.Controls.Add(this.dgv_Credits);
            this.grb_Credits.Location = new System.Drawing.Point(39, 179);
            this.grb_Credits.Name = "grb_Credits";
            this.grb_Credits.Size = new System.Drawing.Size(650, 131);
            this.grb_Credits.TabIndex = 2;
            this.grb_Credits.TabStop = false;
            this.grb_Credits.Text = "Кредити";
            // 
            // dgv_Credits
            // 
            this.dgv_Credits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Credits.Location = new System.Drawing.Point(3, 16);
            this.dgv_Credits.Name = "dgv_Credits";
            this.dgv_Credits.Size = new System.Drawing.Size(644, 112);
            this.dgv_Credits.TabIndex = 1;
            this.dgv_Credits.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Credits_CellEnter);
            // 
            // grb_Payments
            // 
            this.grb_Payments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Payments.Controls.Add(this.dgv_Payments);
            this.grb_Payments.Location = new System.Drawing.Point(39, 316);
            this.grb_Payments.Name = "grb_Payments";
            this.grb_Payments.Size = new System.Drawing.Size(647, 186);
            this.grb_Payments.TabIndex = 2;
            this.grb_Payments.TabStop = false;
            this.grb_Payments.Text = "Платежі";
            // 
            // dgv_Payments
            // 
            this.dgv_Payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Payments.Location = new System.Drawing.Point(3, 16);
            this.dgv_Payments.Name = "dgv_Payments";
            this.dgv_Payments.Size = new System.Drawing.Size(641, 167);
            this.dgv_Payments.TabIndex = 1;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 532);
            this.Controls.Add(this.grb_DebitorInfo);
            this.Controls.Add(this.grb_Credits);
            this.Controls.Add(this.grb_Payments);
            this.Controls.Add(this.grb_Debitors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewMain";
            this.Text = "Кредитний менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewMain_FormClosing);
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_Debitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Debitors)).EndInit();
            this.grb_DebitorInfo.ResumeLayout(false);
            this.grb_DebitorInfo.PerformLayout();
            this.grb_Credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).EndInit();
            this.grb_Payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_Debitors;
        private System.Windows.Forms.GroupBox grb_DebitorInfo;
        private System.Windows.Forms.Label label_PersonalIdNumber;
        private System.Windows.Forms.Label label_SurName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox txb_PersonalIdNumber;
        private System.Windows.Forms.TextBox txb_SurName;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.TextBox txb_FIrstName;
        private System.Windows.Forms.GroupBox grb_Credits;
        private System.Windows.Forms.GroupBox grb_Payments;
        public System.Windows.Forms.DataGridView dgv_Debitors;
        private System.Windows.Forms.DataGridView dgv_Credits;
        private System.Windows.Forms.DataGridView dgv_Payments;
        private System.Windows.Forms.ToolStripMenuItem CreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToFileToolStripMenuItem;
    }
}

