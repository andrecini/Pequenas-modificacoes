namespace JogoTermoHeros
{
    partial class EscolhaDePersonagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscolhaDePersonagens));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.picPersonagens = new System.Windows.Forms.PictureBox();
            this.picEsquerda = new System.Windows.Forms.PictureBox();
            this.picDireita = new System.Windows.Forms.PictureBox();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1045, 27);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 24);
            this.toolStripDropDownButton1.Text = "SOM";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "LIGAR";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.tsSomLigado_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Text = "DESLIGAR";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.tsSomDesligado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.toolStripTextBox4,
            this.toolStripTextBox5});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(135, 24);
            this.toolStripDropDownButton2.Text = "DIFICULDADE";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox3.Text = "FÁCIL";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox3.Click += new System.EventHandler(this.tsFacil_Click);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.ReadOnly = true;
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox4.Text = "MÉDIO";
            this.toolStripTextBox4.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox4.Click += new System.EventHandler(this.tsMedio_Click);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.ReadOnly = true;
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox5.Text = "DIFÍCIL";
            this.toolStripTextBox5.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox5.Click += new System.EventHandler(this.tsDificil_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(797, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 62);
            this.button1.TabIndex = 43;
            this.button1.Text = "COMEÇAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "viottiFrente.png");
            this.imageList1.Images.SetKeyName(1, "16052214288791.png");
            this.imageList1.Images.SetKeyName(2, "1605942234303 (1).png");
            // 
            // picTitulo
            // 
            this.picTitulo.BackColor = System.Drawing.Color.Transparent;
            this.picTitulo.Image = global::JogoTermoHeros.Properties.Resources.e3e300b29fa0e3abec37e0030facbc59;
            this.picTitulo.Location = new System.Drawing.Point(33, 64);
            this.picTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(996, 90);
            this.picTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitulo.TabIndex = 42;
            this.picTitulo.TabStop = false;
            // 
            // picPersonagens
            // 
            this.picPersonagens.BackColor = System.Drawing.Color.Transparent;
            this.picPersonagens.Image = global::JogoTermoHeros.Properties.Resources.viottiFrente;
            this.picPersonagens.Location = new System.Drawing.Point(348, 196);
            this.picPersonagens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPersonagens.Name = "picPersonagens";
            this.picPersonagens.Size = new System.Drawing.Size(341, 315);
            this.picPersonagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonagens.TabIndex = 41;
            this.picPersonagens.TabStop = false;
            // 
            // picEsquerda
            // 
            this.picEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.picEsquerda.Image = global::JogoTermoHeros.Properties.Resources.seta__2_;
            this.picEsquerda.Location = new System.Drawing.Point(33, 271);
            this.picEsquerda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picEsquerda.Name = "picEsquerda";
            this.picEsquerda.Size = new System.Drawing.Size(167, 143);
            this.picEsquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEsquerda.TabIndex = 40;
            this.picEsquerda.TabStop = false;
            this.picEsquerda.Click += new System.EventHandler(this.picEsquerda_Click);
            // 
            // picDireita
            // 
            this.picDireita.BackColor = System.Drawing.Color.Transparent;
            this.picDireita.Image = global::JogoTermoHeros.Properties.Resources.seta;
            this.picDireita.Location = new System.Drawing.Point(843, 271);
            this.picDireita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picDireita.Name = "picDireita";
            this.picDireita.Size = new System.Drawing.Size(167, 143);
            this.picDireita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDireita.TabIndex = 39;
            this.picDireita.TabStop = false;
            this.picDireita.Click += new System.EventHandler(this.picDireita_Click);
            // 
            // picGif
            // 
            this.picGif.Image = global::JogoTermoHeros.Properties.Resources.fundo;
            this.picGif.Location = new System.Drawing.Point(-1, 0);
            this.picGif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(1049, 570);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 0;
            this.picGif.TabStop = false;
            // 
            // EscolhaDePersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picTitulo);
            this.Controls.Add(this.picPersonagens);
            this.Controls.Add(this.picEsquerda);
            this.Controls.Add(this.picDireita);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.picGif);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EscolhaDePersonagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPersonagens";
            this.Load += new System.EventHandler(this.EscolhaDePersonagens_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.PictureBox picDireita;
        private System.Windows.Forms.PictureBox picEsquerda;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picPersonagens;
        private System.Windows.Forms.ImageList imageList1;
    }
}