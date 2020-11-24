
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
            this.btnRegistra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMotore = new System.Windows.Forms.RadioButton();
            this.radAliante = new System.Windows.Forms.RadioButton();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.btnCompara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updPotenza)).BeginInit();
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
            this.updPotenza.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.updPotenza.Name = "updPotenza";
            this.updPotenza.Size = new System.Drawing.Size(120, 22);
            this.updPotenza.TabIndex = 3;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(84, 312);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(130, 51);
            this.btnRegistra.TabIndex = 9;
            this.btnRegistra.Text = "Aggiungi aereo";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnCompara_Click_1);
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
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(518, 46);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 24);
            this.cmb1.TabIndex = 10;
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(645, 45);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 24);
            this.cmb2.TabIndex = 11;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(598, 235);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(112, 61);
            this.btnCompara.TabIndex = 12;
            this.btnCompara.Text = "Compara";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // frmAeroporto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.updPotenza);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAeroporto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.updPotenza)).EndInit();
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
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMotore;
        private System.Windows.Forms.RadioButton radAliante;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Button btnCompara;
    }
}

