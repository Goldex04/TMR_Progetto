
namespace Gozzi_progetto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Algerian", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(103, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Invia indovinello";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 8F);
            this.button1.Location = new System.Drawing.Point(325, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Correggi indovinello";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 10F);
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 88);
            this.label2.TabIndex = 4;
            this.label2.Text = "Il mio nome è Tom Marvolo Riddle, maestro degli indovinelli.\r\nPensi di essere all" +
    "\'altezza? \r\nSbagliane 5 e ne pagherai le conseguenze\r\nSei pronto?";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Algerian", 8F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(233, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "IN ATTESA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Algerian", 8F);
            this.textBox1.Location = new System.Drawing.Point(103, 208);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 72);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Apparirà qui il mio indovinello. Pazienta...";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Algerian", 8F);
            this.textBox2.Location = new System.Drawing.Point(103, 355);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(437, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Vediamo se la tua risposta è giusta, viandante...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gozzi_progetto.Properties.Resources._1000_F_185196011_f7n7Ja7QUNjGJbGUcKTDHp7m39XPgw4C;
            this.ClientSize = new System.Drawing.Size(654, 594);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

