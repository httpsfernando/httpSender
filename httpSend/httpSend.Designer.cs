namespace httpSend
{
    partial class httpSend
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
            this.endpoint1 = new System.Windows.Forms.TextBox();
            this.salvar1 = new System.Windows.Forms.Button();
            this.enviar1 = new System.Windows.Forms.Button();
            this.respostaHttpBox = new System.Windows.Forms.TextBox();
            this.endpoint2 = new System.Windows.Forms.TextBox();
            this.salvar2 = new System.Windows.Forms.Button();
            this.enviar2 = new System.Windows.Forms.Button();
            this.endpoint3 = new System.Windows.Forms.TextBox();
            this.endpoint4 = new System.Windows.Forms.TextBox();
            this.salvar3 = new System.Windows.Forms.Button();
            this.salvar4 = new System.Windows.Forms.Button();
            this.enviar3 = new System.Windows.Forms.Button();
            this.enviar4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endpoint1
            // 
            this.endpoint1.Location = new System.Drawing.Point(12, 25);
            this.endpoint1.Name = "endpoint1";
            this.endpoint1.Size = new System.Drawing.Size(410, 20);
            this.endpoint1.TabIndex = 0;
            // 
            // salvar1
            // 
            this.salvar1.Location = new System.Drawing.Point(428, 22);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(75, 23);
            this.salvar1.TabIndex = 1;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseVisualStyleBackColor = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // enviar1
            // 
            this.enviar1.Location = new System.Drawing.Point(509, 22);
            this.enviar1.Name = "enviar1";
            this.enviar1.Size = new System.Drawing.Size(75, 23);
            this.enviar1.TabIndex = 2;
            this.enviar1.Text = "ENVIAR";
            this.enviar1.UseVisualStyleBackColor = true;
            this.enviar1.Click += new System.EventHandler(this.enviar1_Click);
            // 
            // respostaHttpBox
            // 
            this.respostaHttpBox.Location = new System.Drawing.Point(605, 25);
            this.respostaHttpBox.Multiline = true;
            this.respostaHttpBox.Name = "respostaHttpBox";
            this.respostaHttpBox.ReadOnly = true;
            this.respostaHttpBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.respostaHttpBox.Size = new System.Drawing.Size(327, 225);
            this.respostaHttpBox.TabIndex = 3;
            // 
            // endpoint2
            // 
            this.endpoint2.Location = new System.Drawing.Point(12, 88);
            this.endpoint2.Name = "endpoint2";
            this.endpoint2.Size = new System.Drawing.Size(410, 20);
            this.endpoint2.TabIndex = 4;
            // 
            // salvar2
            // 
            this.salvar2.Location = new System.Drawing.Point(428, 88);
            this.salvar2.Name = "salvar2";
            this.salvar2.Size = new System.Drawing.Size(75, 23);
            this.salvar2.TabIndex = 5;
            this.salvar2.Text = "SALVAR";
            this.salvar2.UseVisualStyleBackColor = true;
            this.salvar2.Click += new System.EventHandler(this.salvar2_Click);
            // 
            // enviar2
            // 
            this.enviar2.Location = new System.Drawing.Point(509, 88);
            this.enviar2.Name = "enviar2";
            this.enviar2.Size = new System.Drawing.Size(75, 23);
            this.enviar2.TabIndex = 6;
            this.enviar2.Text = "ENVIAR";
            this.enviar2.UseVisualStyleBackColor = true;
            this.enviar2.Click += new System.EventHandler(this.enviar2_Click);
            // 
            // endpoint3
            // 
            this.endpoint3.Location = new System.Drawing.Point(12, 148);
            this.endpoint3.Name = "endpoint3";
            this.endpoint3.Size = new System.Drawing.Size(410, 20);
            this.endpoint3.TabIndex = 7;
            // 
            // endpoint4
            // 
            this.endpoint4.Location = new System.Drawing.Point(12, 207);
            this.endpoint4.Name = "endpoint4";
            this.endpoint4.Size = new System.Drawing.Size(410, 20);
            this.endpoint4.TabIndex = 8;
            // 
            // salvar3
            // 
            this.salvar3.Location = new System.Drawing.Point(428, 148);
            this.salvar3.Name = "salvar3";
            this.salvar3.Size = new System.Drawing.Size(75, 23);
            this.salvar3.TabIndex = 9;
            this.salvar3.Text = "SALVAR";
            this.salvar3.UseVisualStyleBackColor = true;
            this.salvar3.Click += new System.EventHandler(this.salvar3_Click);
            // 
            // salvar4
            // 
            this.salvar4.Location = new System.Drawing.Point(428, 207);
            this.salvar4.Name = "salvar4";
            this.salvar4.Size = new System.Drawing.Size(75, 23);
            this.salvar4.TabIndex = 10;
            this.salvar4.Text = "SALVAR";
            this.salvar4.UseVisualStyleBackColor = true;
            this.salvar4.Click += new System.EventHandler(this.salvar4_Click);
            // 
            // enviar3
            // 
            this.enviar3.Location = new System.Drawing.Point(509, 148);
            this.enviar3.Name = "enviar3";
            this.enviar3.Size = new System.Drawing.Size(75, 23);
            this.enviar3.TabIndex = 11;
            this.enviar3.Text = "ENVIAR";
            this.enviar3.UseVisualStyleBackColor = true;
            this.enviar3.Click += new System.EventHandler(this.enviar3_Click);
            // 
            // enviar4
            // 
            this.enviar4.Location = new System.Drawing.Point(509, 207);
            this.enviar4.Name = "enviar4";
            this.enviar4.Size = new System.Drawing.Size(75, 23);
            this.enviar4.TabIndex = 12;
            this.enviar4.Text = "ENVIAR";
            this.enviar4.UseVisualStyleBackColor = true;
            this.enviar4.Click += new System.EventHandler(this.enviar4_Click);
            // 
            // httpSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 268);
            this.Controls.Add(this.enviar4);
            this.Controls.Add(this.enviar3);
            this.Controls.Add(this.salvar4);
            this.Controls.Add(this.salvar3);
            this.Controls.Add(this.endpoint4);
            this.Controls.Add(this.endpoint3);
            this.Controls.Add(this.enviar2);
            this.Controls.Add(this.salvar2);
            this.Controls.Add(this.endpoint2);
            this.Controls.Add(this.respostaHttpBox);
            this.Controls.Add(this.enviar1);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.endpoint1);
            this.Name = "httpSend";
            this.Text = "httpSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endpoint1;
        private System.Windows.Forms.Button salvar1;
        private System.Windows.Forms.Button enviar1;
        private System.Windows.Forms.TextBox respostaHttpBox;
        private System.Windows.Forms.TextBox endpoint2;
        private System.Windows.Forms.Button salvar2;
        private System.Windows.Forms.Button enviar2;
        private System.Windows.Forms.TextBox endpoint3;
        private System.Windows.Forms.TextBox endpoint4;
        private System.Windows.Forms.Button salvar3;
        private System.Windows.Forms.Button salvar4;
        private System.Windows.Forms.Button enviar3;
        private System.Windows.Forms.Button enviar4;
    }
}

