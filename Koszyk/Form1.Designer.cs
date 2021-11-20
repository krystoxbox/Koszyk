namespace Koszyk
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaZakupuw = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dodajButton = new System.Windows.Forms.Button();
            this.kup = new System.Windows.Forms.Button();
            this.cenaLbl = new System.Windows.Forms.Label();
            this.cenaTotalLbl = new System.Windows.Forms.Label();
            this.zamienbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaZakupuw
            // 
            this.listaZakupuw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaZakupuw.FormattingEnabled = true;
            this.listaZakupuw.ItemHeight = 24;
            this.listaZakupuw.Location = new System.Drawing.Point(423, 29);
            this.listaZakupuw.Name = "listaZakupuw";
            this.listaZakupuw.Size = new System.Drawing.Size(320, 340);
            this.listaZakupuw.TabIndex = 0;
            this.listaZakupuw.SelectedIndexChanged += new System.EventHandler(this.listaZakupuw_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 100);
            this.button1.TabIndex = 1;
            this.button1.Tag = "przedmiot";
            this.button1.Text = "ORZECH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(146, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 100);
            this.button2.TabIndex = 2;
            this.button2.Tag = "przedmiot";
            this.button2.Text = "JABŁKO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(279, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 100);
            this.button3.TabIndex = 3;
            this.button3.Tag = "przedmiot";
            this.button3.Text = "WODA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(279, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 100);
            this.button4.TabIndex = 6;
            this.button4.Tag = "przedmiot";
            this.button4.Text = "BUŁKA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(146, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 100);
            this.button5.TabIndex = 5;
            this.button5.Tag = "przedmiot";
            this.button5.Text = "MONSTER";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(12, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 100);
            this.button6.TabIndex = 4;
            this.button6.Tag = "przedmiot";
            this.button6.Text = "LÓD EKIPY";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(279, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 100);
            this.button7.TabIndex = 9;
            this.button7.Tag = "przedmiot";
            this.button7.Text = "KONDOMY";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(146, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 100);
            this.button8.TabIndex = 8;
            this.button8.Tag = "przedmiot";
            this.button8.Text = "CHIPSY";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(12, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 100);
            this.button9.TabIndex = 7;
            this.button9.Tag = "przedmiot";
            this.button9.Text = "PIWO";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.klikaniePrzedmiotu);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(146, 377);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 47);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dodajButton
            // 
            this.dodajButton.Enabled = false;
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dodajButton.Location = new System.Drawing.Point(279, 377);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(118, 47);
            this.dodajButton.TabIndex = 11;
            this.dodajButton.Text = "DODAJ";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // kup
            // 
            this.kup.Enabled = false;
            this.kup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.kup.Location = new System.Drawing.Point(625, 377);
            this.kup.Name = "kup";
            this.kup.Size = new System.Drawing.Size(118, 47);
            this.kup.TabIndex = 12;
            this.kup.Text = "KUP";
            this.kup.UseVisualStyleBackColor = true;
            this.kup.Click += new System.EventHandler(this.kup_Click);
            // 
            // cenaLbl
            // 
            this.cenaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cenaLbl.Location = new System.Drawing.Point(12, 377);
            this.cenaLbl.Name = "cenaLbl";
            this.cenaLbl.Size = new System.Drawing.Size(116, 47);
            this.cenaLbl.TabIndex = 13;
            this.cenaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cenaTotalLbl
            // 
            this.cenaTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cenaTotalLbl.Location = new System.Drawing.Point(461, 380);
            this.cenaTotalLbl.Name = "cenaTotalLbl";
            this.cenaTotalLbl.Size = new System.Drawing.Size(116, 47);
            this.cenaTotalLbl.TabIndex = 14;
            this.cenaTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zamienbutton
            // 
            this.zamienbutton.Enabled = false;
            this.zamienbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.zamienbutton.Location = new System.Drawing.Point(279, 430);
            this.zamienbutton.Name = "zamienbutton";
            this.zamienbutton.Size = new System.Drawing.Size(118, 47);
            this.zamienbutton.TabIndex = 15;
            this.zamienbutton.Text = "ZAMIEŃ";
            this.zamienbutton.UseVisualStyleBackColor = true;
            this.zamienbutton.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 483);
            this.Controls.Add(this.zamienbutton);
            this.Controls.Add(this.cenaTotalLbl);
            this.Controls.Add(this.cenaLbl);
            this.Controls.Add(this.kup);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaZakupuw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaZakupuw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button kup;
        private System.Windows.Forms.Label cenaLbl;
        private System.Windows.Forms.Label cenaTotalLbl;
        private System.Windows.Forms.Button zamienbutton;
    }
}

