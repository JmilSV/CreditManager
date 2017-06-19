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
    public partial class AddNewDebtor : Form
    {
        ViewMain viewMain;
        Controler controler;
        Connection connection;
        public AddNewDebtor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controler = new Controler();
            if (controler.AddNewDebitor(txb_FirstName.Text, txb_LastName.Text, txb_SurName.Text, txb_PersonalIdNumber.Text))
            {
                connection = new Connection();
                viewMain = new ViewMain();
                viewMain.dgv_Debitors.DataSource = connection.GetAllDebitors();
                MessageBox.Show("Дебітор успішно доданий");
                Close();
            }
            else
                MessageBox.Show("Дебітор не був доданий");
            
        }

        private void txb_FirstName_TextChanged(object sender, EventArgs e)
        {
            if (txb_FirstName.Text != string.Empty && txb_LastName.Text != string.Empty && txb_PersonalIdNumber.Text != string.Empty)
                btn_AddNewDebitor.Enabled = true;
            else
                btn_AddNewDebitor.Enabled = false;
        }

        private void txb_LastName_TextChanged(object sender, EventArgs e)
        {
            if (txb_FirstName.Text != string.Empty && txb_LastName.Text != string.Empty && txb_PersonalIdNumber.Text != string.Empty)
                btn_AddNewDebitor.Enabled = true;
            else
                btn_AddNewDebitor.Enabled = false;
        }

        private void txb_PersonalIdNumber_TextChanged(object sender, EventArgs e)
        {
            if (txb_FirstName.Text != string.Empty && txb_LastName.Text != string.Empty && txb_PersonalIdNumber.Text.Length == 10)
                btn_AddNewDebitor.Enabled = true;
            else
                btn_AddNewDebitor.Enabled = false;
        }

        private void txb_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txb_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txb_SurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txb_PersonalIdNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
