
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_Rechnungen
{
	partial class UcStammdaten
    {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private TabControl tabControl1;
        private DataGridView dgvKunden;
        private DataGridView dgvArtikel;
        private DataGridView dgvFirma;

        private void InitializeComponent()
        {

            tabControl1 = new TabControl();
            tabControl1.Dock = DockStyle.Fill;

            // --- Tab Kunden ---
            TabPage tabKunden = new TabPage("Kunden");
            dgvKunden = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tabKunden.Controls.Add(dgvKunden);

            // --- Tab Artikel ---
            TabPage tabArtikel = new TabPage("Artikel");
            dgvArtikel = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tabArtikel.Controls.Add(dgvArtikel);

            // --- Tab Firma ---
            TabPage tabFirma = new TabPage("Firma");
            dgvFirma = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            tabFirma.Controls.Add(dgvFirma);

            // Tabs hinzufügen
            tabControl1.TabPages.Add(tabKunden);
            tabControl1.TabPages.Add(tabArtikel);
            tabControl1.TabPages.Add(tabFirma);

            Controls.Add(tabControl1);
            Size = new Size(960, 680);
        }



        #endregion

        private ListView listView1;
    }
}
