namespace ConteudoBimestral1
{
    partial class frmposto
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
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lbllitros = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(433, 53);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(58, 27);
            this.txttipo.TabIndex = 0;
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(226, 146);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(265, 27);
            this.txtresult.TabIndex = 1;
            // 
            // txtlitros
            // 
            this.txtlitros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlitros.Location = new System.Drawing.Point(236, 97);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(255, 27);
            this.txtlitros.TabIndex = 2;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(121, 56);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(306, 19);
            this.lbltipo.TabIndex = 3;
            this.lbltipo.Text = "Tipo de Combustível (A: Alcool | G: Gasolina):";
            // 
            // lbllitros
            // 
            this.lbllitros.AutoSize = true;
            this.lbllitros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllitros.Location = new System.Drawing.Point(121, 100);
            this.lbllitros.Name = "lbllitros";
            this.lbllitros.Size = new System.Drawing.Size(109, 19);
            this.lbllitros.TabIndex = 4;
            this.lbllitros.Text = "Qnte. de Litros:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(121, 149);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(99, 19);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "Valor a pagar:";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(125, 202);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(87, 55);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(268, 202);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(87, 55);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(404, 202);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(87, 55);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbllitros);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txttipo);
            this.Name = "frmposto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1 - Posto de Gasolina";
            this.Load += new System.EventHandler(this.frmposto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lbllitros;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}