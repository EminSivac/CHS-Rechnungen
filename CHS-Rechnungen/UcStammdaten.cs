using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_Rechnungen
{
    public partial class UcStammdaten : UserControl
    {
        public UcStammdaten()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //Kunden-Daten
            var result = SqlHandler.Select("SELECT * FROM zeiterfassungen WHERE mitarbeiter_id = 1");
            dgvKunden.DataSource = result;

            //Firma-Daten
            result = SqlHandler.Select("SELECT * FROM zeiterfassungen");
            dgvFirma.DataSource = result;

            //Artikel-Daten
            result = SqlHandler.Select("SELECT * FROM zeiterfassungen WHERE mitarbeiter_id = 18");
            dgvArtikel.DataSource = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text;

            if (search != "")
            {
                int index = tabControl1.SelectedIndex;

                switch (index)
                {
                    case 0:
                        //Kunden-Daten
                        var result = SqlHandler.Select($"SELECT * FROM zeiterfassungen WHERE mitarbeiter_id = {search}");
                        dgvKunden.DataSource = result;
                        break;
                    case 2:
                        //Firma-Daten
                        result = SqlHandler.Select($"SELECT * FROM zeiterfassungen WHERE standort_id = {search}");
                        dgvFirma.DataSource = result;
                        break;
                    case 1:
                        //Artikel-Daten
                        result = SqlHandler.Select($"SELECT * FROM zeiterfassungen WHERE id = {search}");
                        dgvArtikel.DataSource = result;
                        break;
                }
            }
        }
    }
}
