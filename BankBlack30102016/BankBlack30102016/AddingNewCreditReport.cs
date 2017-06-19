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
    public partial class AddingNewCreditReport : Form
    {
        Connection connection;
        Debtor debitor;

        public AddingNewCreditReport()
        {
            InitializeComponent();
        }
        public AddingNewCreditReport(string category, string sum, Debtor debitor)
        {
            InitializeComponent();

            txb_FirstName.Text = debitor.FirstName;
            txb_LastName.Text = debitor.LastName;
            txb_SurName.Text = debitor.SurName;
            txb_PersonalIdNumber.Text = debitor.PersonalId.ToString();

            txb_Category.Text = category;
            txb_Sum.Text = sum;

            this.debitor = debitor;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            connection = new Connection();
            if (connection.AddNewCredit(txb_Category.Text, txb_Sum.Text, debitor.id))
            {
                MessageBox.Show("Кредит успішно видано");
            }
            else
            {
                MessageBox.Show("Кредит не був виданий");
            }
        }
    }
}
