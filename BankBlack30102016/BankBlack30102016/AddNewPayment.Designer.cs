namespace BankBlack30102016
{
    partial class AddNewPayment
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
            this.lbl_helpSearch = new System.Windows.Forms.Label();
            this.btn_SearchDebitor = new System.Windows.Forms.Button();
            this.txb_SearchDebitor = new System.Windows.Forms.TextBox();
            this.grb_SearchResults = new System.Windows.Forms.GroupBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.cmb_SearchResults = new System.Windows.Forms.ComboBox();
            this.lbl_SearchDebitor = new System.Windows.Forms.Label();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.txb_Sum = new System.Windows.Forms.TextBox();
            this.grb_AvailableCredits = new System.Windows.Forms.GroupBox();
            this.dgv_AvailableCredits = new System.Windows.Forms.DataGridView();
            this.btn_AddNewPayment = new System.Windows.Forms.Button();
            this.grb_SearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.grb_AvailableCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvailableCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_helpSearch
            // 
            this.lbl_helpSearch.AutoSize = true;
            this.lbl_helpSearch.Location = new System.Drawing.Point(430, 121);
            this.lbl_helpSearch.Name = "lbl_helpSearch";
            this.lbl_helpSearch.Size = new System.Drawing.Size(0, 13);
            this.lbl_helpSearch.TabIndex = 19;
            // 
            // btn_SearchDebitor
            // 
            this.btn_SearchDebitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchDebitor.Enabled = false;
            this.btn_SearchDebitor.Location = new System.Drawing.Point(475, 68);
            this.btn_SearchDebitor.Name = "btn_SearchDebitor";
            this.btn_SearchDebitor.Size = new System.Drawing.Size(68, 21);
            this.btn_SearchDebitor.TabIndex = 16;
            this.btn_SearchDebitor.Text = "Пошук";
            this.btn_SearchDebitor.UseVisualStyleBackColor = true;
            this.btn_SearchDebitor.Click += new System.EventHandler(this.btn_SearchDebitor_Click);
            // 
            // txb_SearchDebitor
            // 
            this.txb_SearchDebitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SearchDebitor.Enabled = false;
            this.txb_SearchDebitor.Location = new System.Drawing.Point(311, 68);
            this.txb_SearchDebitor.Name = "txb_SearchDebitor";
            this.txb_SearchDebitor.Size = new System.Drawing.Size(152, 20);
            this.txb_SearchDebitor.TabIndex = 15;
            this.txb_SearchDebitor.Text = " <--  оберіть критерій";
            this.txb_SearchDebitor.TextChanged += new System.EventHandler(this.txb_SearchDebitor_TextChanged);
            this.txb_SearchDebitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_SearchDebitor_KeyDown);
            this.txb_SearchDebitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_SearchDebitor_KeyPress);
            // 
            // grb_SearchResults
            // 
            this.grb_SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_SearchResults.Controls.Add(this.dgv_SearchResults);
            this.grb_SearchResults.Location = new System.Drawing.Point(46, 109);
            this.grb_SearchResults.Name = "grb_SearchResults";
            this.grb_SearchResults.Size = new System.Drawing.Size(497, 121);
            this.grb_SearchResults.TabIndex = 18;
            this.grb_SearchResults.TabStop = false;
            this.grb_SearchResults.Text = "Результати пошуку дебітора";
            // 
            // dgv_SearchResults
            // 
            this.dgv_SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResults.Location = new System.Drawing.Point(3, 16);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.Size = new System.Drawing.Size(491, 100);
            this.dgv_SearchResults.TabIndex = 5;
            this.dgv_SearchResults.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchResults_CellEnter);
            // 
            // cmb_SearchResults
            // 
            this.cmb_SearchResults.CausesValidation = false;
            this.cmb_SearchResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchResults.FormattingEnabled = true;
            this.cmb_SearchResults.Items.AddRange(new object[] {
            "За фамілією",
            "За ідентифікаційним номером ФО"});
            this.cmb_SearchResults.Location = new System.Drawing.Point(135, 68);
            this.cmb_SearchResults.Name = "cmb_SearchResults";
            this.cmb_SearchResults.Size = new System.Drawing.Size(170, 21);
            this.cmb_SearchResults.TabIndex = 14;
            this.cmb_SearchResults.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchResults_SelectedIndexChanged);
            // 
            // lbl_SearchDebitor
            // 
            this.lbl_SearchDebitor.AutoSize = true;
            this.lbl_SearchDebitor.Location = new System.Drawing.Point(43, 71);
            this.lbl_SearchDebitor.Name = "lbl_SearchDebitor";
            this.lbl_SearchDebitor.Size = new System.Drawing.Size(86, 13);
            this.lbl_SearchDebitor.TabIndex = 17;
            this.lbl_SearchDebitor.Text = "Пошук дебітора";
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.AutoSize = true;
            this.lbl_Sum.Location = new System.Drawing.Point(43, 32);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(78, 13);
            this.lbl_Sum.TabIndex = 21;
            this.lbl_Sum.Text = "Сума платежу";
            // 
            // txb_Sum
            // 
            this.txb_Sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Sum.Location = new System.Drawing.Point(135, 29);
            this.txb_Sum.Name = "txb_Sum";
            this.txb_Sum.Size = new System.Drawing.Size(110, 20);
            this.txb_Sum.TabIndex = 0;
            this.txb_Sum.TextChanged += new System.EventHandler(this.txb_Sum_TextChanged);
            this.txb_Sum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Sum_KeyDown);
            this.txb_Sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Sum_KeyPress);
            // 
            // grb_AvailableCredits
            // 
            this.grb_AvailableCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_AvailableCredits.Controls.Add(this.dgv_AvailableCredits);
            this.grb_AvailableCredits.Location = new System.Drawing.Point(46, 236);
            this.grb_AvailableCredits.Name = "grb_AvailableCredits";
            this.grb_AvailableCredits.Size = new System.Drawing.Size(497, 139);
            this.grb_AvailableCredits.TabIndex = 22;
            this.grb_AvailableCredits.TabStop = false;
            this.grb_AvailableCredits.Text = "Кредити";
            // 
            // dgv_AvailableCredits
            // 
            this.dgv_AvailableCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AvailableCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AvailableCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AvailableCredits.Location = new System.Drawing.Point(3, 16);
            this.dgv_AvailableCredits.Name = "dgv_AvailableCredits";
            this.dgv_AvailableCredits.Size = new System.Drawing.Size(491, 120);
            this.dgv_AvailableCredits.TabIndex = 1;
            this.dgv_AvailableCredits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AvailableCredits_CellDoubleClick);
            // 
            // btn_AddNewPayment
            // 
            this.btn_AddNewPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNewPayment.Enabled = false;
            this.btn_AddNewPayment.Location = new System.Drawing.Point(413, 391);
            this.btn_AddNewPayment.Name = "btn_AddNewPayment";
            this.btn_AddNewPayment.Size = new System.Drawing.Size(127, 23);
            this.btn_AddNewPayment.TabIndex = 23;
            this.btn_AddNewPayment.Text = "Сформувати запит";
            this.btn_AddNewPayment.UseVisualStyleBackColor = true;
            this.btn_AddNewPayment.Click += new System.EventHandler(this.btn_AddNewPayment_Click);
            // 
            // AddNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 449);
            this.Controls.Add(this.btn_AddNewPayment);
            this.Controls.Add(this.grb_AvailableCredits);
            this.Controls.Add(this.lbl_Sum);
            this.Controls.Add(this.btn_SearchDebitor);
            this.Controls.Add(this.txb_Sum);
            this.Controls.Add(this.lbl_helpSearch);
            this.Controls.Add(this.txb_SearchDebitor);
            this.Controls.Add(this.grb_SearchResults);
            this.Controls.Add(this.cmb_SearchResults);
            this.Controls.Add(this.lbl_SearchDebitor);
            this.Name = "AddNewPayment";
            this.Text = "Новий платіж";
            this.grb_SearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.grb_AvailableCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvailableCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_helpSearch;
        private System.Windows.Forms.Button btn_SearchDebitor;
        private System.Windows.Forms.TextBox txb_SearchDebitor;
        private System.Windows.Forms.GroupBox grb_SearchResults;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
        private System.Windows.Forms.ComboBox cmb_SearchResults;
        private System.Windows.Forms.Label lbl_SearchDebitor;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.TextBox txb_Sum;
        private System.Windows.Forms.GroupBox grb_AvailableCredits;
        private System.Windows.Forms.DataGridView dgv_AvailableCredits;
        private System.Windows.Forms.Button btn_AddNewPayment;
    }
}