using System;
using System.Collections;
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
    public partial class ViewMain : Form
    {
        Connection connection;
        ArrayList allDebitors;

        public ViewMain()
        {
            InitializeComponent();

            connection = new Connection();

            allDebitors = connection.GetAllDebitors();
            if (allDebitors.Count != 0)
            {
                dgv_Debitors.DataSource = allDebitors;
                DgvDebitorsSettings();
            }
        }

        void DgvDebitorsSettings()
        {
            dgv_Debitors.Columns[2].Visible = false;
            dgv_Debitors.Columns[3].Visible = false;
            dgv_Debitors.Columns[4].Visible = false;

            dgv_Debitors.TopLeftHeaderCell.Value = "   Sv";
        }

        private void dgv_Debitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_FIrstName.Text = dgv_Debitors.Rows[e.RowIndex].Cells[2].Value.ToString();
            txb_LastName.Text = dgv_Debitors.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_SurName.Text = dgv_Debitors.Rows[e.RowIndex].Cells[3].Value.ToString();
            txb_PersonalIdNumber.Text = dgv_Debitors.Rows[e.RowIndex].Cells[4].Value.ToString();

            dgv_Credits.DataSource = null;
            dgv_Payments.DataSource = null;
            dgv_Credits.DataSource = connection.GetAllCredits(dgv_Debitors.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void dgv_Credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv_Payments.DataSource = null;
            dgv_Payments.DataSource = connection.GetAllPayments(dgv_Credits.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {
            this.dgv_Debitors.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Debitors_CellEnter);
        }

        private void ViewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Завершити роботу?", "Закриття програми", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDebtor newDebitor = new AddNewDebtor();
            newDebitor.ShowDialog();

            allDebitors = connection.GetAllDebitors();
            if(allDebitors.Count != 0)
                dgv_Debitors.DataSource = connection.GetAllDebitors();
        }

        private void AddNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCredit newCredit = new AddNewCredit();
            newCredit.ShowDialog();
        }

        private void AddNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPayment newPayment = new AddNewPayment();
            newPayment.ShowDialog();
        }

        private void AddToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.AddDbToFile())
            {
                MessageBox.Show("Дані успішно добавлені", "Запис базиданих до файлу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Дані не були добавлені", "Запис базиданих до файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
