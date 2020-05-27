namespace FuncaoExponencial
{
    partial class FimJogo
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(184, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fim do Jogo";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.BackColor = System.Drawing.Color.Transparent;
            this.lblErros.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErros.Location = new System.Drawing.Point(218, 188);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(108, 51);
            this.lblErros.TabIndex = 11;
            this.lblErros.Text = "label5";
            this.lblErros.Click += new System.EventHandler(this.lblErros_Click);
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.BackColor = System.Drawing.Color.Transparent;
            this.lblAcertos.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcertos.Location = new System.Drawing.Point(218, 72);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(108, 51);
            this.lblAcertos.TabIndex = 12;
            this.lblAcertos.Text = "label6";
            this.lblAcertos.Click += new System.EventHandler(this.lblAcertos_Click);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentagem.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPorcentagem.Location = new System.Drawing.Point(106, 276);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(121, 57);
            this.lblPorcentagem.TabIndex = 13;
            this.lblPorcentagem.Text = "label5";
            // 
            // FimJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 457);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.label2);
            this.Name = "FimJogo";
            this.Text = "FimJogo";
            this.Load += new System.EventHandler(this.FimJogo_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblErros, 0);
            this.Controls.SetChildIndex(this.lblAcertos, 0);
            this.Controls.SetChildIndex(this.lblPorcentagem, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblPorcentagem;
    }
}