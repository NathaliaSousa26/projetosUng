namespace FuncaoExponencial
{
    partial class Conclusao
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
            this.btn_ant = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ant
            // 
            this.btn_ant.BackColor = System.Drawing.Color.Transparent;
            this.btn_ant.BackgroundImage = global::FuncaoExponencial.Properties.Resources.anterior;
            this.btn_ant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ant.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ant.Location = new System.Drawing.Point(12, 430);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(49, 41);
            this.btn_ant.TabIndex = 9;
            this.btn_ant.UseVisualStyleBackColor = false;
            this.btn_ant.Click += new System.EventHandler(this.btn_ant_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FuncaoExponencial.Properties.Resources.cliquejogar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(345, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 85);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 148);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dica: Para resolver exercícios sobre equação exponencial, \r\no ideal é encontrar u" +
    "ma igualdade entre potências \r\nde mesma base para que se igualem também os expoe" +
    "ntes.\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vamos jogar?";
            // 
            // Conclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuncaoExponencial.Properties.Resources.grc3a1fico_guia_06;
            this.ClientSize = new System.Drawing.Size(787, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ant);
            this.Name = "Conclusao";
            this.Text = "Conclusao";
            this.Load += new System.EventHandler(this.Conclusao_Load);
            this.Controls.SetChildIndex(this.btn_ant, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}