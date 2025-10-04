using System;
using System.Collections.Generic;
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
    }
}
