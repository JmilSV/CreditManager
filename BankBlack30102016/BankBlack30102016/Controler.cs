using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankBlack30102016
{

    class Controler
    {
        Connection connection = new Connection();

        public bool AddNewDebitor(string firstName, string lastName, string surName, string id)
        {
            if (firstName == string.Empty || lastName == string.Empty || id == string.Empty)
            {
                MessageBox.Show("Поля Ім'я, фамілія та ідентифікаційний номер є обов'язковими для заповнення.", 
                    "Незаповнене обов'язкове поле");
                return false;
            }

            firstName = firstName.Trim();
            lastName = lastName.Trim();
            id = id.Trim();

            char[] signs = firstName.ToCharArray();
            if (char.IsLower(signs[0]))
            {
                if (MessageBox.Show("Ім'я вказано не з великої літери. Продовжити виконання?", 
                    "Можлива синтаксична помилка", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
            }

            signs = lastName.ToCharArray();
            if (char.IsLower(signs[0]))
            {
                if (MessageBox.Show("Фамілія вказана не з великої літери. Продовжити виконання?", 
                    "Можлива синтаксична помилка", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
            }


            if (surName == string.Empty)
            {
                if (MessageBox.Show("По батькові не вказано. Продовжити виконання?", 
                    "Незаповнене необов'язкове поле", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
                else
                {
                    surName = "Немає даних";
                }
            }
            else
            {
                surName = surName.Trim();
                signs = surName.ToCharArray();
                if (char.IsLower(signs[0]))
                {
                    if (MessageBox.Show("По-батькові вказано не з великої літери. Продовжити виконання?", 
                        "Можлива синтаксична помилка", MessageBoxButtons.YesNo) == DialogResult.No)
                        return false;
                }
            }

            return connection.AddNewDebitor(firstName, lastName, surName, id);
        }
    }
}
