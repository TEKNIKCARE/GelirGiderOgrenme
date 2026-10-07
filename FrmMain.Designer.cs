namespace GelirGiderOgrenme
{
    partial class FrmMain
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
            grpKayit = new GroupBox();
            dtpTarih = new DateTimePicker();
            lblTarih = new Label();
            grpKayit.SuspendLayout();
            SuspendLayout();
            // 
            // grpKayit
            // 
            grpKayit.Controls.Add(dtpTarih);
            grpKayit.Controls.Add(lblTarih);
            grpKayit.Location = new Point(20, 20);
            grpKayit.Name = "grpKayit";
            grpKayit.Size = new Size(940, 180);
            grpKayit.TabIndex = 0;
            grpKayit.TabStop = false;
            grpKayit.Text = "Yeni Gelir / Gider";
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(20, 55);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(155, 23);
            dtpTarih.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(20, 30);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(32, 15);
            lblTarih.TabIndex = 0;
            lblTarih.Text = "Tarih";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(grpKayit);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aylık Gelir Gider Takibi";
            grpKayit.ResumeLayout(false);
            grpKayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKayit;
        private Label lblTarih;
        private DateTimePicker dtpTarih;
    }
}
