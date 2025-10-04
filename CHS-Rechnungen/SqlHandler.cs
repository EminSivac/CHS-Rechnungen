using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_Rechnungen
{
    public class SqlHandler
    {
        public static List<List<string>> Select(string query)
        {
            var dbCon = DBConnection.Instance();
            var rows = new List<List<string>>();

            if (dbCon.IsConnect())
            {
                using (var cmd = new MySqlCommand(query, dbCon.Connection))
                using (var result = cmd.ExecuteReader())
                {
                    while (result.Read())
                    {
                        var row = new List<string>();

                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            // Wandelt alles in String um (auch INT, DATETIME, NULL usw.)
                            row.Add(result.IsDBNull(i) ? "" : result[i].ToString());
                        }

                        rows.Add(row);
                    }
                }
            }

            return rows;
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
