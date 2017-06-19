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
    public partial class AddNewPaymentReport : Form
    {
        Connection connection;
        Credit credit;


        public AddNewPaymentReport(string sum, Debtor debitor, Credit credit)
        {
            InitializeComponent();

            this.credit = credit;

            txb_Sum.Text = sum;

            txb_Category.Text = credit.Category;
            txb_OpenDate.Text = credit.OpenDate;
            txb_CreditSum.Text = credit.Sum.ToString();


            txb_FirstName.Text = debitor.FirstName;
            txb_LastName.Text = debitor.LastName;
            txb_SurName.Text = debitor.SurName;
            txb_PersonalIdNumber.Text = debitor.id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new Connection();
            if (connection.AddNewPayment(txb_Sum.Text, credit.id))
            {
                MessageBox.Show("Оплату успішно здійснено");
            }
            else
            {
                MessageBox.Show("Оплата не була здійснена");
            }
        }
    }
}
