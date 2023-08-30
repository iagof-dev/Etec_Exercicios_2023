namespace ExercicioRadioButton
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
            this.Mas = new System.Windows.Forms.RadioButton();
            this.Fem = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbDivorc = new System.Windows.Forms.RadioButton();
            this.rbViuvo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbds = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chbnutri = new System.Windows.Forms.CheckBox();
            this.chblogi = new System.Windows.Forms.CheckBox();
            this.chbedf = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mas
            // 
            this.Mas.AutoSize = true;
            this.Mas.Location = new System.Drawing.Point(61, 29);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(73, 17);
            this.Mas.TabIndex = 0;
            this.Mas.Text = "Masculino";
            this.Mas.UseVisualStyleBackColor = true;
            // 
            // Fem
            // 
            this.Fem.AutoSize = true;
            this.Fem.Location = new System.Drawing.Point(61, 52);
            this.Fem.Name = "Fem";
            this.Fem.Size = new System.Drawing.Size(67, 17);
            this.Fem.TabIndex = 1;
            this.Fem.Text = "Feminino";
            this.Fem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Escolha Sexo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Escolha Sexo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Location = new System.Drawing.Point(48, 29);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbSolteiro.TabIndex = 5;
            this.rbSolteiro.Text = "Solteiro(a)";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(49, 52);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(73, 17);
            this.rbCasado.TabIndex = 6;
            this.rbCasado.Text = "Casado(a)";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbDivorc
            // 
            this.rbDivorc.AutoSize = true;
            this.rbDivorc.Location = new System.Drawing.Point(49, 75);
            this.rbDivorc.Name = "rbDivorc";
            this.rbDivorc.Size = new System.Drawing.Size(88, 17);
            this.rbDivorc.TabIndex = 7;
            this.rbDivorc.Text = "Divorciado(a)";
            this.rbDivorc.UseVisualStyleBackColor = true;
            // 
            // rbViuvo
            // 
            this.rbViuvo.AutoSize = true;
            this.rbViuvo.Location = new System.Drawing.Point(49, 98);
            this.rbViuvo.Name = "rbViuvo";
            this.rbViuvo.Size = new System.Drawing.Size(64, 17);
            this.rbViuvo.TabIndex = 8;
            this.rbViuvo.Text = "Viúvo(a)";
            this.rbViuvo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSolteiro);
            this.groupBox1.Controls.Add(this.rbViuvo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rbDivorc);
            this.groupBox1.Controls.Add(this.rbCasado);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(280, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 178);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Mas);
            this.groupBox2.Controls.Add(this.Fem);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(40, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbedf);
            this.groupBox3.Controls.Add(this.chblogi);
            this.groupBox3.Controls.Add(this.chbnutri);
            this.groupBox3.Controls.Add(this.chkAdmin);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.chbds);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(537, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 177);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Curso";
            // 
            // chbds
            // 
            this.chbds.AutoSize = true;
            this.chbds.Location = new System.Drawing.Point(45, 50);
            this.chbds.Name = "chbds";
            this.chbds.Size = new System.Drawing.Size(108, 17);
            this.chbds.TabIndex = 0;
            this.chbds.Text = "Desenvolvimento";
            this.chbds.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(45, 30);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(92, 17);
            this.chkAdmin.TabIndex = 6;
            this.chkAdmin.Text = "Administração";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chbnutri
            // 
            this.chbnutri.AutoSize = true;
            this.chbnutri.Location = new System.Drawing.Point(45, 70);
            this.chbnutri.Name = "chbnutri";
            this.chbnutri.Size = new System.Drawing.Size(66, 17);
            this.chbnutri.TabIndex = 7;
            this.chbnutri.Text = "Nutrição";
            this.chbnutri.UseVisualStyleBackColor = true;
            // 
            // chblogi
            // 
            this.chblogi.AutoSize = true;
            this.chblogi.Location = new System.Drawing.Point(45, 89);
            this.chblogi.Name = "chblogi";
            this.chblogi.Size = new System.Drawing.Size(68, 17);
            this.chblogi.TabIndex = 8;
            this.chblogi.Text = "Logistica";
            this.chblogi.UseVisualStyleBackColor = true;
            // 
            // chbedf
            // 
            this.chbedf.AutoSize = true;
            this.chbedf.Location = new System.Drawing.Point(45, 111);
            this.chbedf.Name = "chbedf";
            this.chbedf.Size = new System.Drawing.Size(81, 17);
            this.chbedf.TabIndex = 9;
            this.chbedf.Text = "Edificações";
            this.chbedf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Mas;
        private System.Windows.Forms.RadioButton Fem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbDivorc;
        private System.Windows.Forms.RadioButton rbViuvo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbnutri;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chbds;
        private System.Windows.Forms.CheckBox chbedf;
        private System.Windows.Forms.CheckBox chblogi;
    }
}

