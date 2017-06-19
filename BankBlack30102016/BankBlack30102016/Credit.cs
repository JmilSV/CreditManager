using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBlack30102016
{
    public class Credit
    {
        public int id;
        public string Category;
        public string OpenDate;
        public decimal Sum;
        public int DebtorId;

        public Credit(int id, int DebtorId, string Category, string OpenDate, decimal Sum)
        {
            this.id = id;
            this.Category = Category;
            this.OpenDate = OpenDate;
            this.Sum = Sum;
            this.DebtorId = DebtorId;
        }

        public Credit() { }
    }
}
