using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_Rechnungen
{
    public static class Helper
    {
        public static void ShowAsTable(List<List<string>> rows)
        {
            if (rows == null || rows.Count == 0)
            {
                MessageBox.Show("Keine Daten gefunden.");
                return;
            }

            // Breite der Spalten bestimmen (maximale Länge pro Spalte)
            int colCount = rows[0].Count;
            int[] colWidths = new int[colCount];

            foreach (var row in rows)
            {
                for (int i = 0; i < colCount; i++)
                {
                    int length = row[i]?.Length ?? 0;
                    if (length > colWidths[i])
                        colWidths[i] = length;
                }
            }

            // Tabelle bauen
            var sb = new System.Text.StringBuilder();
            foreach (var row in rows)
            {
                for (int i = 0; i < colCount; i++)
                {
                    sb.Append((row[i] ?? "").PadRight(colWidths[i] + 2));
                }
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Daten-Tabelle");
        }

        private static DataTable ToDataTable(List<List<string>> data, List<string>? columnNames = null)
        {
            DataTable dt = new DataTable();

            if (data == null || data.Count == 0)
                return dt;

            int columnCount = data[0].Count;

            // Wenn keine Spaltennamen angegeben wurden, generisch benennen
            if (columnNames == null || columnNames.Count != columnCount)
            {
                for (int i = 0; i < columnCount; i++)
                    dt.Columns.Add("Spalte " + (i + 1));
            }
            else
            {
                foreach (var col in columnNames)
                    dt.Columns.Add(col);
            }

            foreach (var row in data)
                dt.Rows.Add(row.ToArray());

            return dt;
        }
    }
}
