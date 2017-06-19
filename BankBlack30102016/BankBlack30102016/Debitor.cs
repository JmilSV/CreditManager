using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBlack30102016
{
    public class Debtor
    {
       public int id;
       public string FirstName;
       public string LastName;
       public string SurName;
       public string PersonalId;

        public Debtor(int id, string FirstName, string LastName, string PersonalId, string SurName = "Немає даних")
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SurName = SurName;
            this.PersonalId = PersonalId;
        }

        public Debtor() { }
    }
}
