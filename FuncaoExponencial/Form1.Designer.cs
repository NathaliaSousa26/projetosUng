namespace FuncaoExponencial
{
    partial class form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ler = new System.Windows.Forms.Button();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.gb_ler = new System.Windows.Forms.GroupBox();
            this.gb_jogar = new System.Windows.Forms.GroupBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.gb_ler.SuspendLayout();
            this.gb_jogar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUNÇÃO EXPONENCIAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Função Exponencial: \r\nDefinição, Gráfico e Exemplos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(76, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desafio";
            // 
            // btn_ler
            // 
            this.btn_ler.BackColor = System.Drawing.Color.Transparent;
            this.btn_ler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ler.BackgroundImage")));
            this.btn_ler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ler.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ler.Location = new System.Drawing.Point(6, 19);
            this.btn_ler.Name = "btn_ler";
            this.btn_ler.Size = new System.Drawing.Size(54, 42);
            this.btn_ler.TabIndex = 4;
            this.btn_ler.Text = "Ler mais";
            this.btn_ler.UseVisualStyleBackColor = false;
            this.btn_ler.Click += new System.EventHandler(this.btn_ler_Click);
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.Transparent;
            this.btn_jogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_jogar.BackgroundImage")));
            this.btn_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jogar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_jogar.Location = new System.Drawing.Point(6, 19);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(54, 39);
            this.btn_jogar.TabIndex = 5;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // gb_ler
            // 
            this.gb_ler.BackColor = System.Drawing.Color.Transparent;
            this.gb_ler.Controls.Add(this.label2);
            this.gb_ler.Controls.Add(this.btn_ler);
            this.gb_ler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_ler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_ler.Location = new System.Drawing.Point(12, 83);
            this.gb_ler.Name = "gb_ler";
            this.gb_ler.Size = new System.Drawing.Size(300, 70);
            this.gb_ler.TabIndex = 6;
            this.gb_ler.TabStop = false;
            // 
            // gb_jogar
            // 
            this.gb_jogar.BackColor = System.Drawing.Color.Transparent;
            this.gb_jogar.Controls.Add(this.btn_jogar);
            this.gb_jogar.Controls.Add(this.label3);
            this.gb_jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_jogar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_jogar.Location = new System.Drawing.Point(12, 159);
            this.gb_jogar.Name = "gb_jogar";
            this.gb_jogar.Size = new System.Drawing.Size(160, 70);
            this.gb_jogar.TabIndex = 7;
            this.gb_jogar.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.BackgroundImage = global::FuncaoExponencial.Properties.Resources.fechar;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.Location = new System.Drawing.Point(565, 320);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(71, 73);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 405);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_ler);
            this.Controls.Add(this.gb_jogar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_ler.ResumeLayout(false);
            this.gb_ler.PerformLayout();
            this.gb_jogar.ResumeLayout(false);
            this.gb_jogar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ler;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.GroupBox gb_ler;
        private System.Windows.Forms.GroupBox gb_jogar;
        private System.Windows.Forms.Button btn_sair;
    }
}

