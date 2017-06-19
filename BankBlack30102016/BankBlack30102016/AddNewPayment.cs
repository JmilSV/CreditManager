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
    public partial class AddNewPayment : Form
    {
        AddNewPaymentReport newPaymentReport;
        string byLastName = "За фамілією";
        string byId = "За ідентифікаційним номером ФО";
        Connection connection = new Connection();
        Debtor debtor;
        Credit credit;

        public AddNewPayment()
        {
            InitializeComponent();
        }

        private void btn_SearchDebitor_Click(object sender, EventArgs e)
        {
            dgv_AvailableCredits.DataSource = dgv_SearchResults.DataSource = null;

            if (cmb_SearchResults.Text == byId)
            {
                dgv_SearchResults.DataSource = connection.GetAllDebitors(txb_SearchDebitor.Text, SearchDebitors.Id);
            }
            else if(cmb_SearchResults.Text == byLastName)
            {
                dgv_SearchResults.DataSource = connection.GetAllDebitors(txb_SearchDebitor.Text, SearchDebitors.LastName);
            }
            if (dgv_AvailableCredits.ColumnCount != 0 && txb_Sum.Text != "")
            {
                btn_AddNewPayment.Enabled = true;
            }
            else
            {
                btn_AddNewPayment.Enabled = false;
            }
        }

        private void cmb_SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_SearchDebitor.Text = "";
            txb_SearchDebitor.Enabled = true;
        }

        private void txb_Sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txb_Sum.Text == "0" && txb_Sum.Text.Length == 1)
            {
                if (e.KeyChar != '.' || e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txb_SearchDebitor_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchDebitor.Text != string.Empty)
            {
                btn_SearchDebitor.Enabled = true;
            }
            else
            {
                btn_SearchDebitor.Enabled = false;
            }
        }

        private void txb_SearchDebitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_SearchResults.Text == byLastName)
            {
                if (txb_SearchDebitor.Text != string.Empty)
                {
                    btn_SearchDebitor.Enabled = true;
                }
            }
            else if (cmb_SearchResults.Text == byId)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                else
                {
                    if (txb_SearchDebitor.Text != "")
                    {
                        btn_SearchDebitor.Enabled = true;
                    }
                    else
                    {
                        btn_AddNewPayment.Enabled = false;
                    }
                }
            }
        }

        private void dgv_SearchResults_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv_AvailableCredits.DataSource = connection.GetAllCredits(dgv_SearchResults.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dgv_AvailableCredits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btn_AddNewPayment_Click(new object(), new EventArgs());
        }

        private void btn_AddNewPayment_Click(object sender, EventArgs e)
        {
            debtor = new Debtor(Convert.ToInt32(dgv_SearchResults.CurrentRow.Cells[0].Value.ToString()),
                                dgv_SearchResults.CurrentRow.Cells[2].Value.ToString(),
                                dgv_SearchResults.CurrentRow.Cells[1].Value.ToString(),
                                dgv_SearchResults.CurrentRow.Cells[4].Value.ToString(),
                                dgv_SearchResults.CurrentRow.Cells[3].Value.ToString());

            credit = new Credit(Convert.ToInt32(dgv_AvailableCredits.CurrentRow.Cells[0].Value.ToString()),
                                Convert.ToInt32(dgv_AvailableCredits.CurrentRow.Cells[1].Value.ToString()),
                                dgv_AvailableCredits.CurrentRow.Cells[2].Value.ToString(),
                                dgv_AvailableCredits.CurrentRow.Cells[3].Value.ToString(),
                                Convert.ToDecimal(dgv_AvailableCredits.CurrentRow.Cells[4].Value.ToString()));

            newPaymentReport = new AddNewPaymentReport(txb_Sum.Text, debtor, credit);
            newPaymentReport.ShowDialog();
        }

        private void dgv_AvailableCredits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_AddNewPayment_Click(new object(), new EventArgs());
        }

        private void txb_Sum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_AddNewPayment.Enabled)
                {
                    btn_AddNewPayment_Click(new object(), new EventArgs());
                }
            }
        }

        private void txb_SearchDebitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_SearchDebitor.Enabled)
                {
                    btn_SearchDebitor_Click(new object(), new EventArgs());
                }
            }
        }

        private void txb_Sum_TextChanged(object sender, EventArgs e)
        {
            if (txb_Sum.Text != "")
            {
                if (dgv_AvailableCredits.ColumnCount != 0)
                {
                    btn_AddNewPayment.Enabled = true;
                }
            }
            else
            {
                btn_AddNewPayment.Enabled = false;
            }
        }

    }
}
