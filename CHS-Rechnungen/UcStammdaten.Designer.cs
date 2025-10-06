
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
            tabKunden = new TabPage();
            dgvKunden = new DataGridView();
            tabArtikel = new TabPage();
            dgvArtikel = new DataGridView();
            tabFirma = new TabPage();
            dgvFirma = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabKunden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKunden).BeginInit();
            tabArtikel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtikel).BeginInit();
            tabFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFirma).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabKunden);
            tabControl1.Controls.Add(tabArtikel);
            tabControl1.Controls.Add(tabFirma);
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(960, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabKunden
            // 
            tabKunden.Controls.Add(dgvKunden);
            tabKunden.Location = new Point(4, 24);
            tabKunden.Name = "tabKunden";
            tabKunden.Size = new Size(952, 549);
            tabKunden.TabIndex = 0;
            tabKunden.Text = "Kunden";
            // 
            // dgvKunden
            // 
            dgvKunden.Location = new Point(0, 0);
            dgvKunden.Name = "dgvKunden";
            dgvKunden.Size = new Size(946, 546);
            dgvKunden.TabIndex = 0;
            // 
            // tabArtikel
            // 
            tabArtikel.Controls.Add(dgvArtikel);
            tabArtikel.Location = new Point(4, 24);
            tabArtikel.Name = "tabArtikel";
            tabArtikel.Size = new Size(952, 549);
            tabArtikel.TabIndex = 1;
            tabArtikel.Text = "Artikel";
            // 
            // dgvArtikel
            // 
            dgvArtikel.Location = new Point(0, 0);
            dgvArtikel.Name = "dgvArtikel";
            dgvArtikel.Size = new Size(949, 546);
            dgvArtikel.TabIndex = 0;
            // 
            // tabFirma
            // 
            tabFirma.Controls.Add(dgvFirma);
            tabFirma.Location = new Point(4, 24);
            tabFirma.Name = "tabFirma";
            tabFirma.Size = new Size(952, 549);
            tabFirma.TabIndex = 2;
            tabFirma.Text = "Firma";
            // 
            // dgvFirma
            // 
            dgvFirma.Location = new Point(0, 0);
            dgvFirma.Name = "dgvFirma";
            dgvFirma.Size = new Size(949, 546);
            dgvFirma.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(4, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Suche";
            // 
            // UcStammdaten
            // 
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(tabControl1);
            Name = "UcStammdaten";
            Size = new Size(1280, 680);
            tabControl1.ResumeLayout(false);
            tabKunden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKunden).EndInit();
            tabArtikel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArtikel).EndInit();
            tabFirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFirma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TabPage tabKunden;
        private TabPage tabArtikel;
        private TabPage tabFirma;
        private TextBox textBox1;
        private Label label1;
    }
}
