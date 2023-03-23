namespace ConteudoBimestral1
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuprogramas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexercicio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulooping1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuwhile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudowhile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuprogramas,
            this.mnusair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuprogramas
            // 
            this.mnuprogramas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuexercicio1,
            this.mnulooping1});
            this.mnuprogramas.Name = "mnuprogramas";
            this.mnuprogramas.Size = new System.Drawing.Size(76, 20);
            this.mnuprogramas.Text = "Programas";
            // 
            // mnuexercicio1
            // 
            this.mnuexercicio1.Name = "mnuexercicio1";
            this.mnuexercicio1.Size = new System.Drawing.Size(182, 22);
            this.mnuexercicio1.Text = "Exercício 1";
            this.mnuexercicio1.Click += new System.EventHandler(this.mnuexercicio1_Click);
            // 
            // mnulooping1
            // 
            this.mnulooping1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuwhile,
            this.mnudowhile,
            this.mnufor});
            this.mnulooping1.Name = "mnulooping1";
            this.mnulooping1.Size = new System.Drawing.Size(182, 22);
            this.mnulooping1.Text = "Exercícios Looping 1";
            // 
            // mnuwhile
            // 
            this.mnuwhile.Name = "mnuwhile";
            this.mnuwhile.Size = new System.Drawing.Size(180, 22);
            this.mnuwhile.Text = "Comando While";
            this.mnuwhile.Click += new System.EventHandler(this.mnuwhile_Click);
            // 
            // mnudowhile
            // 
            this.mnudowhile.Name = "mnudowhile";
            this.mnudowhile.Size = new System.Drawing.Size(180, 22);
            this.mnudowhile.Text = "Comando Do While";
            this.mnudowhile.Click += new System.EventHandler(this.mnudowhile_Click);
            // 
            // mnufor
            // 
            this.mnufor.Name = "mnufor";
            this.mnufor.Size = new System.Drawing.Size(180, 22);
            this.mnufor.Text = "Comando For";
            this.mnufor.Click += new System.EventHandler(this.mnufor_Click);
            // 
            // mnusair
            // 
            this.mnusair.Name = "mnusair";
            this.mnusair.Size = new System.Drawing.Size(38, 20);
            this.mnusair.Text = "Sair";
            this.mnusair.Click += new System.EventHandler(this.mnusair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos | 1º Bimestre";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuprogramas;
        private System.Windows.Forms.ToolStripMenuItem mnusair;
        private System.Windows.Forms.ToolStripMenuItem mnuexercicio1;
        private System.Windows.Forms.ToolStripMenuItem mnulooping1;
        private System.Windows.Forms.ToolStripMenuItem mnuwhile;
        private System.Windows.Forms.ToolStripMenuItem mnudowhile;
        private System.Windows.Forms.ToolStripMenuItem mnufor;
    }
}

