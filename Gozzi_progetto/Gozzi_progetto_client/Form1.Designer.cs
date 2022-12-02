
namespace Gozzi_progetto_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apparirà qui il mio indovinello. Pazienta....";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 8F);
            this.button1.Location = new System.Drawing.Point(76, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connettiti a me";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Algerian", 8F);
            this.button2.Location = new System.Drawing.Point(358, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Invia la risposta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Algerian", 8F);
            this.textBox1.Location = new System.Drawing.Point(134, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Scegli con cautela. Rifletti e poi rispondi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(628, 594);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

