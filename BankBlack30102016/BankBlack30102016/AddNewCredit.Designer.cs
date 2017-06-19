namespace BankBlack30102016
{
    partial class AddNewCredit
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
            this.lbl_helpSearch = new System.Windows.Forms.Label();
            this.btn_SearchDebitor = new System.Windows.Forms.Button();
            this.txb_SearchDebitor = new System.Windows.Forms.TextBox();
            this.grb_SearchResults = new System.Windows.Forms.GroupBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.btn_Send = new System.Windows.Forms.Button();
            this.cmb_ChoiceCriterionSearchDebtor = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lbl_DebitorId = new System.Windows.Forms.Label();
            this.lbl_SearchDebitor = new System.Windows.Forms.Label();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.txb_ldNumber = new System.Windows.Forms.TextBox();
            this.txb_Sum = new System.Windows.Forms.TextBox();
            this.grb_DebitorInfo.SuspendLayout();
            this.grb_SearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_DebitorInfo
            // 
            this.grb_DebitorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_DebitorInfo.Controls.Add(this.lbl_helpSearch);
            this.grb_DebitorInfo.Controls.Add(this.btn_SearchDebitor);
            this.grb_DebitorInfo.Controls.Add(this.txb_SearchDebitor);
            this.grb_DebitorInfo.Controls.Add(this.grb_SearchResults);
            this.grb_DebitorInfo.Controls.Add(this.btn_Send);
            this.grb_DebitorInfo.Controls.Add(this.cmb_ChoiceCriterionSearchDebtor);
            this.grb_DebitorInfo.Controls.Add(this.cmbCategory);
            this.grb_DebitorInfo.Controls.Add(this.lbl_DebitorId);
            this.grb_DebitorInfo.Controls.Add(this.lbl_SearchDebitor);
            this.grb_DebitorInfo.Controls.Add(this.lbl_Sum);
            this.grb_DebitorInfo.Controls.Add(this.lbl_Category);
            this.grb_DebitorInfo.Controls.Add(this.txb_ldNumber);
            this.grb_DebitorInfo.Controls.Add(this.txb_Sum);
            this.grb_DebitorInfo.Location = new System.Drawing.Point(12, 12);
            this.grb_DebitorInfo.Name = "grb_DebitorInfo";
            this.grb_DebitorInfo.Size = new System.Drawing.Size(602, 311);
            this.grb_DebitorInfo.TabIndex = 4;
            this.grb_DebitorInfo.TabStop = false;
            this.grb_DebitorInfo.Text = "Інформація про кредит";
            // 
            // lbl_helpSearch
            // 
            this.lbl_helpSearch.AutoSize = true;
            this.lbl_helpSearch.Location = new System.Drawing.Point(371, 89);
            this.lbl_helpSearch.Name = "lbl_helpSearch";
            this.lbl_helpSearch.Size = new System.Drawing.Size(0, 13);
            this.lbl_helpSearch.TabIndex = 13;
            // 
            // btn_SearchDebitor
            // 
            this.btn_SearchDebitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchDebitor.Location = new System.Drawing.Point(507, 66);
            this.btn_SearchDebitor.Name = "btn_SearchDebitor";
            this.btn_SearchDebitor.Size = new System.Drawing.Size(68, 21);
            this.btn_SearchDebitor.TabIndex = 4;
            this.btn_SearchDebitor.Text = "Пошук";
            this.btn_SearchDebitor.UseVisualStyleBackColor = true;
            this.btn_SearchDebitor.Click += new System.EventHandler(this.btn_SearchDebitor_Click);
            // 
            // txb_SearchDebitor
            // 
            this.txb_SearchDebitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SearchDebitor.Enabled = false;
            this.txb_SearchDebitor.Location = new System.Drawing.Point(374, 66);
            this.txb_SearchDebitor.Name = "txb_SearchDebitor";
            this.txb_SearchDebitor.Size = new System.Drawing.Size(122, 20);
            this.txb_SearchDebitor.TabIndex = 3;
            this.txb_SearchDebitor.Text = " <--  оберіть критерій";
            this.txb_SearchDebitor.TextChanged += new System.EventHandler(this.txb_SearchDebitor_TextChanged);
            this.txb_SearchDebitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_SearchDebitor_KeyDown);
            this.txb_SearchDebitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_SearchDebitor_KeyPress);
            // 
            // grb_SearchResults
            // 
            this.grb_SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_SearchResults.Controls.Add(this.dgv_SearchResults);
            this.grb_SearchResults.Location = new System.Drawing.Point(28, 112);
            this.grb_SearchResults.Name = "grb_SearchResults";
            this.grb_SearchResults.Size = new System.Drawing.Size(547, 133);
            this.grb_SearchResults.TabIndex = 12;
            this.grb_SearchResults.TabStop = false;
            this.grb_SearchResults.Text = "Результати пошуку";
            // 
            // dgv_SearchResults
            // 
            this.dgv_SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SearchResults.Location = new System.Drawing.Point(3, 16);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.Size = new System.Drawing.Size(541, 114);
            this.dgv_SearchResults.TabIndex = 5;
            this.dgv_SearchResults.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchResults_CellEnter);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(450, 266);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(122, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Сформувати запит";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // cmb_ChoiceCriterionSearchDebtor
            // 
            this.cmb_ChoiceCriterionSearchDebtor.CausesValidation = false;
            this.cmb_ChoiceCriterionSearchDebtor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ChoiceCriterionSearchDebtor.FormattingEnabled = true;
            this.cmb_ChoiceCriterionSearchDebtor.Items.AddRange(new object[] {
            "За фамілією",
            "За ідентифікаційним номером ФО"});
            this.cmb_ChoiceCriterionSearchDebtor.Location = new System.Drawing.Point(117, 65);
            this.cmb_ChoiceCriterionSearchDebtor.Name = "cmb_ChoiceCriterionSearchDebtor";
            this.cmb_ChoiceCriterionSearchDebtor.Size = new System.Drawing.Size(222, 21);
            this.cmb_ChoiceCriterionSearchDebtor.TabIndex = 2;
            this.cmb_ChoiceCriterionSearchDebtor.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchResults_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.CausesValidation = false;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Їжа",
            "Побут",
            "Інвестиції",
            "Інше"});
            this.cmbCategory.Location = new System.Drawing.Point(117, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(222, 21);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_DebitorId
            // 
            this.lbl_DebitorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_DebitorId.AutoSize = true;
            this.lbl_DebitorId.Location = new System.Drawing.Point(25, 272);
            this.lbl_DebitorId.Name = "lbl_DebitorId";
            this.lbl_DebitorId.Size = new System.Drawing.Size(62, 13);
            this.lbl_DebitorId.TabIndex = 7;
            this.lbl_DebitorId.Text = "Id дебітора";
            // 
            // lbl_SearchDebitor
            // 
            this.lbl_SearchDebitor.AutoSize = true;
            this.lbl_SearchDebitor.Location = new System.Drawing.Point(25, 69);
            this.lbl_SearchDebitor.Name = "lbl_SearchDebitor";
            this.lbl_SearchDebitor.Size = new System.Drawing.Size(86, 13);
            this.lbl_SearchDebitor.TabIndex = 6;
            this.lbl_SearchDebitor.Text = "Пошук дебітора";
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.AutoSize = true;
            this.lbl_Sum.Enabled = false;
            this.lbl_Sum.Location = new System.Drawing.Point(371, 31);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(76, 13);
            this.lbl_Sum.TabIndex = 5;
            this.lbl_Sum.Text = "Сума кредиту";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(25, 31);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(56, 13);
            this.lbl_Category.TabIndex = 4;
            this.lbl_Category.Text = "Категорія";
            // 
            // txb_ldNumber
            // 
            this.txb_ldNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ldNumber.Location = new System.Drawing.Point(108, 269);
            this.txb_ldNumber.Name = "txb_ldNumber";
            this.txb_ldNumber.ReadOnly = true;
            this.txb_ldNumber.Size = new System.Drawing.Size(184, 20);
            this.txb_ldNumber.TabIndex = 6;
            this.txb_ldNumber.TextChanged += new System.EventHandler(this.txb_IdNumber_TextChanged);
            // 
            // txb_Sum
            // 
            this.txb_Sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Sum.Enabled = false;
            this.txb_Sum.Location = new System.Drawing.Point(453, 28);
            this.txb_Sum.MaxLength = 9;
            this.txb_Sum.Name = "txb_Sum";
            this.txb_Sum.Size = new System.Drawing.Size(122, 20);
            this.txb_Sum.TabIndex = 1;
            this.txb_Sum.Text = "    Оберіть категорію";
            this.txb_Sum.TextChanged += new System.EventHandler(this.txb_Sum_TextChanged);
            this.txb_Sum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Sum_KeyDown);
            this.txb_Sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Sum_KeyPress);
            // 
            // AddNewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 365);
            this.Controls.Add(this.grb_DebitorInfo);
            this.Name = "AddNewCredit";
            this.Text = "Видача кредиту";
            this.grb_DebitorInfo.ResumeLayout(false);
            this.grb_DebitorInfo.PerformLayout();
            this.grb_SearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_DebitorInfo;
        private System.Windows.Forms.Label lbl_DebitorId;
        private System.Windows.Forms.Label lbl_SearchDebitor;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox txb_ldNumber;
        private System.Windows.Forms.TextBox txb_Sum;
        private System.Windows.Forms.ComboBox cmb_ChoiceCriterionSearchDebtor;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txb_SearchDebitor;
        private System.Windows.Forms.GroupBox grb_SearchResults;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_SearchDebitor;
        private System.Windows.Forms.Label lbl_helpSearch;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
    }
}