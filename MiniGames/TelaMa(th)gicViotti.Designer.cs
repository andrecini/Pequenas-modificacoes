namespace JogoTermoHeros
{
    partial class TelaMa_th_gicViotti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMa_th_gicViotti));
            this.btnPronto = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.picBalao = new System.Windows.Forms.PictureBox();
            this.txtSegredo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBalao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPronto
            // 
            this.btnPronto.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.btnPronto.Location = new System.Drawing.Point(337, 12);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(111, 37);
            this.btnPronto.TabIndex = 9;
            this.btnPronto.Text = "Pronto";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.White;
            this.lblTexto.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblTexto.Location = new System.Drawing.Point(206, 102);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(360, 54);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "OLÁ MEU POVO! SEJA BEM VINDO \r\nAO MEU JOGO...";
            // 
            // picBalao
            // 
            this.picBalao.BackColor = System.Drawing.Color.Transparent;
            this.picBalao.Image = ((System.Drawing.Image)(resources.GetObject("picBalao.Image")));
            this.picBalao.Location = new System.Drawing.Point(141, 71);
            this.picBalao.Name = "picBalao";
            this.picBalao.Size = new System.Drawing.Size(484, 229);
            this.picBalao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBalao.TabIndex = 7;
            this.picBalao.TabStop = false;
            // 
            // txtSegredo
            // 
            this.txtSegredo.ForeColor = System.Drawing.Color.White;
            this.txtSegredo.Location = new System.Drawing.Point(423, 159);
            this.txtSegredo.Name = "txtSegredo";
            this.txtSegredo.Size = new System.Drawing.Size(100, 20);
            this.txtSegredo.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnPronto);
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 64);
            this.panel1.TabIndex = 10;
            // 
            // TelaMa_th_gicViotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.picBalao);
            this.Controls.Add(this.txtSegredo);
            this.Name = "TelaMa_th_gicViotti";
            this.Text = "TelaMa_th_gicViotti";
            ((System.ComponentModel.ISupportInitialize)(this.picBalao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.PictureBox picBalao;
        private System.Windows.Forms.TextBox txtSegredo;
        private System.Windows.Forms.Panel panel1;
    }
}