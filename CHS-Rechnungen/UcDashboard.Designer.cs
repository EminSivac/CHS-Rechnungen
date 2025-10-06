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
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNeuesAngebot);
            Controls.Add(btnNeueRechnung);
            Name = "UcDashboard";
            Size = new Size(960, 680);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNeueRechnung;
        private Button btnNeuesAngebot;
    }
}
