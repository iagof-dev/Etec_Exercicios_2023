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
            this.btn_Quadrado = new System.Windows.Forms.Button();
            this.btn_retangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Quadrado
            // 
            this.btn_Quadrado.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Quadrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Quadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Quadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Quadrado.ForeColor = System.Drawing.Color.Black;
            this.btn_Quadrado.Location = new System.Drawing.Point(85, 115);
            this.btn_Quadrado.Name = "btn_Quadrado";
            this.btn_Quadrado.Size = new System.Drawing.Size(274, 55);
            this.btn_Quadrado.TabIndex = 0;
            this.btn_Quadrado.Text = "Quadrado";
            this.btn_Quadrado.UseVisualStyleBackColor = true;
            this.btn_Quadrado.Click += new System.EventHandler(this.btn_Quadrado_Click_1);
            // 
            // btn_retangulo
            // 
            this.btn_retangulo.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_retangulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_retangulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_retangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_retangulo.Location = new System.Drawing.Point(85, 176);
            this.btn_retangulo.Name = "btn_retangulo";
            this.btn_retangulo.Size = new System.Drawing.Size(274, 55);
            this.btn_retangulo.TabIndex = 1;
            this.btn_retangulo.Text = "Retangulo";
            this.btn_retangulo.UseVisualStyleBackColor = true;
            this.btn_retangulo.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 49);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_retangulo);
            this.Controls.Add(this.btn_Quadrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quadrado;
        private System.Windows.Forms.Button btn_retangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

