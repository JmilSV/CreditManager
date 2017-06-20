using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace BankBlack30102016
{
    enum SearchDebitors
    {
        LastName,
        Id
    }
    class Connection
    {

        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dataReader;

        string commandString;
        string connectionString = @"Data Source=1234-PC\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True;
                                    Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string DebitorInDb;


        public ArrayList GetAllDebitors()
        {
            ArrayList allDebitors = new ArrayList();

            commandString = @"SELECT Id, LastName AS Фамілія, FirstName, SurName, PersonalIdIdentification
                           FROM Debitor
                           ORDER BY LastName";
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    comm = new SqlCommand(commandString, conn);

                    conn.Open();

                    dataReader = comm.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        foreach (var i in dataReader)
                            allDebitors.Add(i);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return allDebitors;
        }

        public ArrayList GetAllDebitors(string searchWord, SearchDebitors searchCriterion)
        {
            ArrayList allDebitors = new ArrayList();

            if (searchCriterion == SearchDebitors.Id)
            {
                commandString = String.Format(@"SELECT Id, LastName AS Фамілія, FirstName, SurName, PersonalIdIdentification
                           FROM Debitor
                           WHERE PersonalIdIdentification = {0}
                           ORDER BY LastName", searchWord);
            }
            else
            {
                commandString = String.Format(@"SELECT Id, LastName AS Фамілія, FirstName, SurName, PersonalIdIdentification
                           FROM Debitor
                           WHERE LastName = '{0}'
                           ORDER BY LastName", searchWord);
            }
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    comm = new SqlCommand(commandString, conn);

                    conn.Open();

                    dataReader = comm.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        foreach (var i in dataReader)
                            allDebitors.Add(i);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return allDebitors;
        }

        public string GetDebitorInDb()
        {
            if(DebitorInDb != null)
                return DebitorInDb;
            return string.Empty;
        }

        public bool AddNewPayment(string sum, int id)
        {
            int s = Convert.ToInt32(sum);
            using (conn = new SqlConnection(connectionString))
            {

                commandString = string.Format(@"INSERT INTO Payment
                                                    (Sum, Date, CreditId)
                                                    VALUES (@sum, @date, @creditId)");

                SqlCommand comm = new SqlCommand(commandString, conn);

                comm.Parameters.AddWithValue("@sum", s);
                comm.Parameters.AddWithValue("@date", DateTime.Now);
                comm.Parameters.AddWithValue("@creditId", id);

                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                comm.Transaction = sqlTransaction;
               // comm = conn.CreateCommand();

                try
                {
                    if (comm.ExecuteNonQuery() == 1)
                    {
                        commandString = string.Format(@"UPDATE Credit
                                                    SET Balans = Balans - @sum
                                                    WHERE Id = @creditId");

                        comm = new SqlCommand(commandString, conn);
                        comm.Parameters.AddWithValue("@sum", s);
                        comm.Parameters.AddWithValue("@creditId", id);

                        comm.Transaction = sqlTransaction;

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            sqlTransaction.Commit();
                            return true;
                        }
                    }
                    return false;
                }
                catch(Exception e)
                {
                    sqlTransaction.Rollback();
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public bool AddDbToFile()
        {
            ArrayList db = new ArrayList();
            StreamWriter sw = new StreamWriter(new FileStream("Bd.txt", FileMode.Truncate), Encoding.UTF8);

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    commandString = @"SELECT * FROM Debitor
                                      ORDER BY LastName";
                    comm = new SqlCommand(commandString, conn);
                    conn.Open();

                    dataReader = comm.ExecuteReader();

                    while (dataReader.Read())
                    {
                        sw.WriteLine("{0} || {1} || {2} || {3} || {4}", dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4]);
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                sw.Dispose();
            }
        }

        public bool AddNewCredit(string category, string sum, int id)
        {
            commandString = string.Format(@"INSERT INTO Credit
                                            VALUES (@id, @sum, @sum, @DateTimeNow, @category)");
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    comm = new SqlCommand(commandString, conn);

                    SqlParameter sqlParameter = new SqlParameter("@id", id);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.Int;
                    comm.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("@sum", sum);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.Money;
                    comm.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("@category", category);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    comm.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("@DateTimeNow", DateTime.Now);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.DateTime;
                    comm.Parameters.Add(sqlParameter);

                    conn.Open();

                    if (comm.ExecuteNonQuery() == 1)
                        return true;
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public ArrayList GetAllCredits(string id)
        {
            ArrayList allCredits = new ArrayList();

            commandString = String.Format(@"SELECT Id, DebitorId AS [Id дебітора], 
                                            Category AS Категорія, OpenDate AS [Дата віркриття], 
                                            Sum AS Сума, Balans AS Баланс
                                           FROM Credit
                                           WHERE DebitorId = @Id
                                           ORDER BY OpenDate");

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    comm = new SqlCommand(commandString, conn);
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    dataReader = comm.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        foreach (var i in dataReader)
                        {
                            allCredits.Add(i);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return allCredits;

        }

        public bool AddNewDebitor(string firstName, string lastName, string surName, string id)
        {

            string commandStr = string.Format(@"INSERT INTO Debitor
                                                    (FirstName, LastName, SurName, PersonalIdIdentification)
                                                     VALUES (@FirstName, @LastName, @SurName, @PersonalIdIdentification)");
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    comm = new SqlCommand(commandStr, conn);

                    SqlParameter sqlParameter = new SqlParameter("@FirstName", firstName);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    comm.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("@LastName", lastName);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    comm.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("@SurName", surName);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    comm.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("@PersonalIdIdentification", id);
                    sqlParameter.SqlDbType = System.Data.SqlDbType.Char;
                    comm.Parameters.Add(sqlParameter);

                    conn.Open();                   
                    if (comm.ExecuteNonQuery() == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public ArrayList GetAllPayments(string id)
        {
            ArrayList allPayments = new ArrayList();

            commandString = String.Format(@"SELECT Id, CreditId AS [Id кредиту], 
                                            Sum AS Сума, Date AS Дата
                                           FROM Payment
                                           WHERE CreditId = @Id
                                           ORDER BY Дата");
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    comm = new SqlCommand(commandString, conn);
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    dataReader = comm.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        foreach (var i in dataReader)
                        {
                            allPayments.Add(i);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return allPayments;
        }
    }
}
