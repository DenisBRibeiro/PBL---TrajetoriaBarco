namespace PBL___TrajetoriaBarco
{
    partial class TelaInicial
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
            this.Largura = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Largura
            // 
            this.Largura.Location = new System.Drawing.Point(42, 41);
            this.Largura.Name = "Largura";
            this.Largura.Size = new System.Drawing.Size(127, 20);
            this.Largura.TabIndex = 0;
            this.Largura.Text = "Largura do rio (em m):  ";
            this.Largura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(429, 331);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(159, 23);
            this.Enviar.TabIndex = 1;
            this.Enviar.Text = "Gerar Resultado";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // TelaInicial
            // 
            this.AccessibleName = "Tela Inicial";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Largura);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaInicial";
            this.Text = "Tela inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Largura;
        private System.Windows.Forms.Button Enviar;
    }
}

