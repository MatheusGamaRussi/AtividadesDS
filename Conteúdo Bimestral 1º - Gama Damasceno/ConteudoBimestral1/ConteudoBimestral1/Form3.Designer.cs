namespace ConteudoBimestral1
{
    partial class frmwhile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltabuada = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txttabuada = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(404, 181);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(87, 55);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(268, 181);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(87, 55);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(125, 181);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(87, 55);
            this.btncalcular.TabIndex = 15;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbltabuada
            // 
            this.lbltabuada.AutoSize = true;
            this.lbltabuada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabuada.Location = new System.Drawing.Point(121, 128);
            this.lbltabuada.Name = "lbltabuada";
            this.lbltabuada.Size = new System.Drawing.Size(68, 19);
            this.lbltabuada.TabIndex = 14;
            this.lbltabuada.Text = "Tabuada:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(121, 79);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(290, 19);
            this.lblnumero.TabIndex = 12;
            this.lblnumero.Text = "Qual número você deseja saber a tabuada?";
            // 
            // txttabuada
            // 
            this.txttabuada.Enabled = false;
            this.txttabuada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttabuada.Location = new System.Drawing.Point(195, 125);
            this.txttabuada.Name = "txttabuada";
            this.txttabuada.ReadOnly = true;
            this.txttabuada.Size = new System.Drawing.Size(296, 27);
            this.txttabuada.TabIndex = 10;
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(417, 76);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(74, 27);
            this.txtnumero.TabIndex = 9;
            // 
            // frmwhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbltabuada);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.txttabuada);
            this.Controls.Add(this.txtnumero);
            this.Name = "frmwhile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltabuada;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txttabuada;
        private System.Windows.Forms.TextBox txtnumero;
    }
}