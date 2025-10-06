namespace CHS_Rechnungen
{
    partial class UcDashboard
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
        private void InitializeComponent()
        {
            btnNeueRechnung = new Button();
            btnNeuesAngebot = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNeueRechnung
            // 
            btnNeueRechnung.Location = new Point(3, 3);
            btnNeueRechnung.Name = "btnNeueRechnung";
            btnNeueRechnung.Size = new Size(177, 77);
            btnNeueRechnung.TabIndex = 2;
            btnNeueRechnung.Text = "Neue Rechnung";
            btnNeueRechnung.UseVisualStyleBackColor = true;
            btnNeueRechnung.Click += btnNeueRechnung_Click;
            // 
            // btnNeuesAngebot
            // 
            btnNeuesAngebot.Location = new Point(3, 86);
            btnNeuesAngebot.Name = "btnNeuesAngebot";
            btnNeuesAngebot.Size = new Size(177, 77);
            btnNeuesAngebot.TabIndex = 3;
            btnNeuesAngebot.Text = "Neues Angebot";
            btnNeuesAngebot.UseVisualStyleBackColor = true;
            btnNeuesAngebot.Click += btnNeuesAngebot_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 178);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(587, 311);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(579, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(btnNeuesAngebot);
            Controls.Add(btnNeueRechnung);
            Name = "UcDashboard";
            Size = new Size(960, 680);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNeueRechnung;
        private Button btnNeuesAngebot;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
