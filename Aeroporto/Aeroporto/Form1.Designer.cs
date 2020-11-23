
namespace Aeroporto
{
    partial class frmAeroporto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.updPotenza = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMotore2 = new System.Windows.Forms.RadioButton();
            this.radAliante2 = new System.Windows.Forms.RadioButton();
            this.updPotenza2 = new System.Windows.Forms.NumericUpDown();
            this.txtSigla2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompara = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMotore = new System.Windows.Forms.RadioButton();
            this.radAliante = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.updPotenza)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPotenza2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigla Aereo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cavalli/Efficienza";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(222, 49);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(120, 22);
            this.txtSigla.TabIndex = 2;
            // 
            // updPotenza
            // 
            this.updPotenza.Location = new System.Drawing.Point(222, 98);
            this.updPotenza.Name = "updPotenza";
            this.updPotenza.Size = new System.Drawing.Size(120, 22);
            this.updPotenza.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMotore2);
            this.groupBox1.Controls.Add(this.radAliante2);
            this.groupBox1.Location = new System.Drawing.Point(428, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radMotore2
            // 
            this.radMotore2.AutoSize = true;
            this.radMotore2.Location = new System.Drawing.Point(50, 62);
            this.radMotore2.Name = "radMotore2";
            this.radMotore2.Size = new System.Drawing.Size(73, 21);
            this.radMotore2.TabIndex = 1;
            this.radMotore2.TabStop = true;
            this.radMotore2.Text = "Motore";
            this.radMotore2.UseVisualStyleBackColor = true;
            // 
            // radAliante2
            // 
            this.radAliante2.AutoSize = true;
            this.radAliante2.Location = new System.Drawing.Point(50, 35);
            this.radAliante2.Name = "radAliante2";
            this.radAliante2.Size = new System.Drawing.Size(72, 21);
            this.radAliante2.TabIndex = 0;
            this.radAliante2.TabStop = true;
            this.radAliante2.Text = "Aliante";
            this.radAliante2.UseVisualStyleBackColor = true;
            // 
            // updPotenza2
            // 
            this.updPotenza2.Location = new System.Drawing.Point(566, 98);
            this.updPotenza2.Name = "updPotenza2";
            this.updPotenza2.Size = new System.Drawing.Size(120, 22);
            this.updPotenza2.TabIndex = 8;
            // 
            // txtSigla2
            // 
            this.txtSigla2.Location = new System.Drawing.Point(566, 49);
            this.txtSigla2.Name = "txtSigla2";
            this.txtSigla2.Size = new System.Drawing.Size(120, 22);
            this.txtSigla2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cavalli/Efficienza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sigla Aereo";
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(362, 305);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(104, 51);
            this.btnCompara.TabIndex = 9;
            this.btnCompara.Text = "Compara";
            this.btnCompara.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMotore);
            this.groupBox2.Controls.Add(this.radAliante);
            this.groupBox2.Location = new System.Drawing.Point(84, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radMotore
            // 
            this.radMotore.AutoSize = true;
            this.radMotore.Location = new System.Drawing.Point(50, 62);
            this.radMotore.Name = "radMotore";
            this.radMotore.Size = new System.Drawing.Size(73, 21);
            this.radMotore.TabIndex = 1;
            this.radMotore.TabStop = true;
            this.radMotore.Text = "Motore";
            this.radMotore.UseVisualStyleBackColor = true;
            // 
            // radAliante
            // 
            this.radAliante.AutoSize = true;
            this.radAliante.Location = new System.Drawing.Point(50, 35);
            this.radAliante.Name = "radAliante";
            this.radAliante.Size = new System.Drawing.Size(72, 21);
            this.radAliante.TabIndex = 0;
            this.radAliante.TabStop = true;
            this.radAliante.Text = "Aliante";
            this.radAliante.UseVisualStyleBackColor = true;
            // 
            // frmAeroporto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.updPotenza2);
            this.Controls.Add(this.txtSigla2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updPotenza);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAeroporto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.updPotenza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPotenza2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.NumericUpDown updPotenza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMotore2;
        private System.Windows.Forms.RadioButton radAliante2;
        private System.Windows.Forms.NumericUpDown updPotenza2;
        private System.Windows.Forms.TextBox txtSigla2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMotore;
        private System.Windows.Forms.RadioButton radAliante;
    }
}

