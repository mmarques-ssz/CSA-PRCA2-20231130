namespace projSemaforo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRua2 = new System.Windows.Forms.RadioButton();
            this.radRua1 = new System.Windows.Forms.RadioButton();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRua1 = new System.Windows.Forms.Label();
            this.lblRua2 = new System.Windows.Forms.Label();
            this.picRua1 = new System.Windows.Forms.PictureBox();
            this.picRua2 = new System.Windows.Forms.PictureBox();
            this.btnLigaDesliga = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRua2);
            this.groupBox1.Controls.Add(this.radRua1);
            this.groupBox1.Location = new System.Drawing.Point(137, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(69, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rua";
            // 
            // radRua2
            // 
            this.radRua2.AutoSize = true;
            this.radRua2.Location = new System.Drawing.Point(20, 51);
            this.radRua2.Name = "radRua2";
            this.radRua2.Size = new System.Drawing.Size(31, 17);
            this.radRua2.TabIndex = 1;
            this.radRua2.Text = "2";
            this.radRua2.UseVisualStyleBackColor = true;
            // 
            // radRua1
            // 
            this.radRua1.AutoSize = true;
            this.radRua1.Checked = true;
            this.radRua1.Location = new System.Drawing.Point(20, 28);
            this.radRua1.Name = "radRua1";
            this.radRua1.Size = new System.Drawing.Size(31, 17);
            this.radRua1.TabIndex = 0;
            this.radRua1.TabStop = true;
            this.radRua1.Text = "1";
            this.radRua1.UseVisualStyleBackColor = true;
            // 
            // btnVermelho
            // 
            this.btnVermelho.Location = new System.Drawing.Point(137, 153);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(75, 23);
            this.btnVermelho.TabIndex = 4;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Location = new System.Drawing.Point(137, 182);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(75, 23);
            this.btnAmarelo.TabIndex = 5;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(137, 211);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 23);
            this.btnVerde.TabIndex = 6;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(168, 19);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(20, 24);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "0";
            // 
            // lblRua1
            // 
            this.lblRua1.AutoSize = true;
            this.lblRua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua1.Location = new System.Drawing.Point(301, 19);
            this.lblRua1.Name = "lblRua1";
            this.lblRua1.Size = new System.Drawing.Size(20, 24);
            this.lblRua1.TabIndex = 8;
            this.lblRua1.Text = "0";
            // 
            // lblRua2
            // 
            this.lblRua2.AutoSize = true;
            this.lblRua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua2.Location = new System.Drawing.Point(44, 19);
            this.lblRua2.Name = "lblRua2";
            this.lblRua2.Size = new System.Drawing.Size(20, 24);
            this.lblRua2.TabIndex = 9;
            this.lblRua2.Text = "0";
            // 
            // picRua1
            // 
            this.picRua1.Image = global::projSemaforo.Properties.Resources.verde;
            this.picRua1.Location = new System.Drawing.Point(249, 91);
            this.picRua1.Name = "picRua1";
            this.picRua1.Size = new System.Drawing.Size(100, 181);
            this.picRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua1.TabIndex = 10;
            this.picRua1.TabStop = false;
            // 
            // picRua2
            // 
            this.picRua2.Image = global::projSemaforo.Properties.Resources.verde;
            this.picRua2.Location = new System.Drawing.Point(12, 93);
            this.picRua2.Name = "picRua2";
            this.picRua2.Size = new System.Drawing.Size(100, 181);
            this.picRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua2.TabIndex = 11;
            this.picRua2.TabStop = false;
            // 
            // btnLigaDesliga
            // 
            this.btnLigaDesliga.Location = new System.Drawing.Point(149, 297);
            this.btnLigaDesliga.Name = "btnLigaDesliga";
            this.btnLigaDesliga.Size = new System.Drawing.Size(75, 23);
            this.btnLigaDesliga.TabIndex = 12;
            this.btnLigaDesliga.Text = "Liga";
            this.btnLigaDesliga.UseVisualStyleBackColor = true;
            this.btnLigaDesliga.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 344);
            this.Controls.Add(this.btnLigaDesliga);
            this.Controls.Add(this.picRua2);
            this.Controls.Add(this.picRua1);
            this.Controls.Add(this.lblRua2);
            this.Controls.Add(this.lblRua1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRua2;
        private System.Windows.Forms.RadioButton radRua1;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRua1;
        private System.Windows.Forms.Label lblRua2;
        private System.Windows.Forms.PictureBox picRua1;
        private System.Windows.Forms.PictureBox picRua2;
        private System.Windows.Forms.Button btnLigaDesliga;
        private System.Windows.Forms.Timer timer1;
    }
}

