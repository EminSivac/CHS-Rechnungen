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
            var result = SqlHandler.Select("SELECT * FROM zeiterfassungen WHERE mitarbeiter_id = 1");
            dgvKunden.DataSource = result;
        }
    }
}
