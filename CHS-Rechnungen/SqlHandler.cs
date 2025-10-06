using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_Rechnungen
{
    public class SqlHandler
    {
        public static DataTable Select(string query)
        {
            try
            {
                var dbCon = DBConnection.Instance();
                var rows = new List<List<string>>();

                if (dbCon.IsConnect())
                {
                    using (var da = new MySqlDataAdapter(query, dbCon.Connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static void Post(string query)
        {
            try
            {
                var dbCon = DBConnection.Instance();

                if (dbCon.IsConnect())
                {
                    using (var cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
