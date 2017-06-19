using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankBlack30102016
{

    public partial class AddNewCredit : Form
    {
        string byLastName = "За фамілією";
        string byId = "За ідентифікаційним номером ФО";

        Connection connection = new Connection();

        public AddNewCredit()
        {
            InitializeComponent();
        }

        private void btn_SearchDebitor_Click(object sender, EventArgs e)
        {
            if (cmb_ChoiceCriterionSearchDebtor.Text == byLastName)
            {
                dgv_SearchResults.DataSource = null;
                dgv_SearchResults.DataSource = connection.GetAllDebitors(txb_SearchDebitor.Text, SearchDebitors.LastName);
            }
            else if (cmb_ChoiceCriterionSearchDebtor.Text == byId)
            {
                dgv_SearchResults.DataSource = null;
                dgv_SearchResults.DataSource = connection.GetAllDebitors(txb_SearchDebitor.Text, SearchDebitors.Id);
            }
        }

        private void cmb_SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_SearchDebitor.Text = null;

            if (cmb_ChoiceCriterionSearchDebtor.Text == byLastName)
                lbl_helpSearch.Text = "введіть фамілію";
            if(cmb_ChoiceCriterionSearchDebtor.Text == byId)
                lbl_helpSearch.Text = "ведіть ідентифікаційний номер ФО";

            txb_SearchDebitor.Enabled = true;
        }

        private void txb_SearchDebitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (txb_SearchDebitor.Text != string.Empty && e.KeyCode == Keys.Enter)
            {
                btn_SearchDebitor_Click(new object(), new EventArgs());
            }
        }

        private void dgv_SearchResults_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_ldNumber.Text = null;
            txb_ldNumber.Text = dgv_SearchResults.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Debtor debitor = new Debtor(Convert.ToInt32(dgv_SearchResults.CurrentRow.Cells[0].Value),
                                        dgv_SearchResults.CurrentRow.Cells[2].Value.ToString(),
                                        dgv_SearchResults.CurrentRow.Cells[1].Value.ToString(),
                                        dgv_SearchResults.CurrentRow.Cells[4].Value.ToString(),
                                        dgv_SearchResults.CurrentRow.Cells[3].Value.ToString());

            
             AddingNewCreditReport addNewCreditReport = new AddingNewCreditReport(cmbCategory.Text, txb_Sum.Text, debitor);
             addNewCreditReport.ShowDialog();


        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Sum.Enabled = true;
            txb_Sum.Text = null;
            txb_Sum.Enabled = true;
        }

        private void txb_Sum_TextChanged(object sender, EventArgs e)
        {
            if (txb_Sum.Text != string.Empty && txb_ldNumber.Text != string.Empty)
                btn_Send.Enabled = true;
            else
                btn_Send.Enabled = false;
        }

        private void txb_SearchDebitor_TextChanged(object sender, EventArgs e)
        {
            if (cmb_ChoiceCriterionSearchDebtor.Text == byLastName)
            {
                txb_SearchDebitor.MaxLength = 32767;
                if (txb_SearchDebitor.Text != string.Empty)
                    btn_SearchDebitor.Enabled = true;
                else
                    btn_SearchDebitor.Enabled = false;
            }
            else if(cmb_ChoiceCriterionSearchDebtor.Text == byId)
            {
                txb_SearchDebitor.MaxLength = 10;
                if (txb_SearchDebitor.Text.Length == 10)
                {
                    btn_SearchDebitor.Enabled = true;
                }
                else
                    btn_SearchDebitor.Enabled = false;
            }
        }

        private void txb_SearchDebitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_ChoiceCriterionSearchDebtor.Text == byId && !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (cmb_ChoiceCriterionSearchDebtor.Text == byLastName && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txb_Sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txb_Sum.Text == "")
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;  
            }
        }
        
        private void txb_Sum_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_ldNumber.Text != "")
                {
                    btn_Send_Click(new object(), new EventArgs());
                }
            }
        }

        private void txb_IdNumber_TextChanged(object sender, EventArgs e)
        {
            if (txb_ldNumber.Text != string.Empty && txb_Sum.Text != string.Empty && txb_Sum.Enabled == true)
            {
                btn_Send.Enabled = true;
            }
            else
            {
                btn_Send.Enabled = false;
            }
        }
    }
}
