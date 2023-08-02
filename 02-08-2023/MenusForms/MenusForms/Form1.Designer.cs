namespace MenusForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculoDeAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculadora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 360;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeAreasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculoDeAreasToolStripMenuItem
            // 
            this.calculoDeAreasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadradoToolStripMenuItem,
            this.retanguloToolStripMenuItem});
            this.calculoDeAreasToolStripMenuItem.Name = "calculoDeAreasToolStripMenuItem";
            this.calculoDeAreasToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.calculoDeAreasToolStripMenuItem.Text = "Calculo de Areas";
            // 
            // quadradoToolStripMenuItem
            // 
            this.quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            this.quadradoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quadradoToolStripMenuItem.Text = "Quadrado";
            this.quadradoToolStripMenuItem.Click += new System.EventHandler(this.quadradoToolStripMenuItem_Click);
            // 
            // retanguloToolStripMenuItem
            // 
            this.retanguloToolStripMenuItem.Name = "retanguloToolStripMenuItem";
            this.retanguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retanguloToolStripMenuItem.Text = "Retangulo";
            this.retanguloToolStripMenuItem.Click += new System.EventHandler(this.retanguloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculoDeAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retanguloToolStripMenuItem;
    }
}

