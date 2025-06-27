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
            this.respostaHttpBox.Location = new System.Drawing.Point(206, 240);
            this.respostaHttpBox.Name = "respostaHttpBox";
            this.respostaHttpBox.ReadOnly = true;
            this.respostaHttpBox.Size = new System.Drawing.Size(327, 20);
            this.respostaHttpBox.TabIndex = 3;
            // 
            // httpSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

