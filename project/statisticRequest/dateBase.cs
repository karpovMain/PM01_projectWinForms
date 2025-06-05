using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statisticRequest
{
    public class dateBase
    {
        static string strConnection = @"Server=.\SQLEXPRESS; Database=statisticRequest; Trusted_Connection=true";
        private static SqlConnection sqlConnection = new SqlConnection(strConnection);

        public static SqlConnection Connection
        {
            get { return sqlConnection; }
        }

        public static void OpenConnection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
            }
            catch (SqlException error)
            {
                MessageBox.Show($"{error}", "Ошибка подключения к серверу!", MessageBoxButtons.OK);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show($"{error}", "Ошибка отключения к серверу!", MessageBoxButtons.OK);
            }
        }
    }

    public class data
    {
        public static string role { get; set; } = "Admin";
        public static int linked_id { get; set; }
        public static int indexRequest { get; set; }
        public static int indexEquipment { get; set; }
        public static int indexClient { get; set; }
        public static int indexSpecialist { get; set; }
        public static int indexComment { get; set; }
        public static int indexReport { get; set; }
    }
}
