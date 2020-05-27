namespace FuncaoExponencial
{
    partial class Introducao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introducao));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ant = new System.Windows.Forms.Button();
            this.btn_prox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(328, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introdução";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "oquee.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FuncaoExponencial.Properties.Resources.oquee_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 307);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FuncaoExponencial.Properties.Resources.dialogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 68);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "O que é função\r\nexponencial ?";
            // 
            // btn_ant
            // 
            this.btn_ant.BackColor = System.Drawing.Color.Transparent;
            this.btn_ant.BackgroundImage = global::FuncaoExponencial.Properties.Resources.anterior;
            this.btn_ant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ant.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ant.Location = new System.Drawing.Point(365, 406);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(49, 41);
            this.btn_ant.TabIndex = 7;
            this.btn_ant.UseVisualStyleBackColor = false;
            this.btn_ant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_prox
            // 
            this.btn_prox.BackColor = System.Drawing.Color.Transparent;
            this.btn_prox.BackgroundImage = global::FuncaoExponencial.Properties.Resources.prox;
            this.btn_prox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prox.ForeColor = System.Drawing.Color.Transparent;
            this.btn_prox.Location = new System.Drawing.Point(416, 406);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(49, 41);
            this.btn_prox.TabIndex = 8;
            this.btn_prox.UseVisualStyleBackColor = false;
            this.btn_prox.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(216, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(507, 256);
            this.label4.TabIndex = 10;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Introducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuncaoExponencial.Properties.Resources.introducao2;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Introducao";
            this.Text = "Introducao";
            this.Load += new System.EventHandler(this.Introducao_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_ant, 0);
            this.Controls.SetChildIndex(this.btn_prox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ant;
        private System.Windows.Forms.Button btn_prox;
        private System.Windows.Forms.Label label4;
    }
}