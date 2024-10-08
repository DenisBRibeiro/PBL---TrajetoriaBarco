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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLargura = new System.Windows.Forms.TextBox();
            this.textBoxVel_Barco = new System.Windows.Forms.TextBox();
            this.textBoxVel_Correnteza = new System.Windows.Forms.TextBox();
            this.textBoxAngulo = new System.Windows.Forms.TextBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonHistorico = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largura do Rio (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade do Barco (m/s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocidade da Correnteza (m/s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ângulo (°):";
            // 
            // textBoxLargura
            // 
            this.textBoxLargura.Location = new System.Drawing.Point(220, 20);
            this.textBoxLargura.Name = "textBoxLargura";
            this.textBoxLargura.Size = new System.Drawing.Size(100, 22);
            this.textBoxLargura.TabIndex = 4;
            // 
            // textBoxVel_Barco
            // 
            this.textBoxVel_Barco.Location = new System.Drawing.Point(220, 60);
            this.textBoxVel_Barco.Name = "textBoxVel_Barco";
            this.textBoxVel_Barco.Size = new System.Drawing.Size(100, 22);
            this.textBoxVel_Barco.TabIndex = 5;
            // 
            // textBoxVel_Correnteza
            // 
            this.textBoxVel_Correnteza.Location = new System.Drawing.Point(220, 100);
            this.textBoxVel_Correnteza.Name = "textBoxVel_Correnteza";
            this.textBoxVel_Correnteza.Size = new System.Drawing.Size(100, 22);
            this.textBoxVel_Correnteza.TabIndex = 6;
            // 
            // textBoxAngulo
            // 
            this.textBoxAngulo.Location = new System.Drawing.Point(220, 140);
            this.textBoxAngulo.Name = "textBoxAngulo";
            this.textBoxAngulo.Size = new System.Drawing.Size(100, 22);
            this.textBoxAngulo.TabIndex = 7;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(20, 180);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(100, 30);
            this.buttonIniciar.TabIndex = 8;
            this.buttonIniciar.Text = "Iniciar Simulação";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonHistorico
            // 
            this.buttonHistorico.Location = new System.Drawing.Point(137, 180);
            this.buttonHistorico.Name = "buttonHistorico";
            this.buttonHistorico.Size = new System.Drawing.Size(100, 30);
            this.buttonHistorico.TabIndex = 9;
            this.buttonHistorico.Text = "Ver Histórico";
            this.buttonHistorico.UseVisualStyleBackColor = true;
            this.buttonHistorico.Click += new System.EventHandler(this.buttonHistorico_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfechar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(260, 189);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(80, 28);
            this.btnfechar.TabIndex = 10;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // TelaInicial
            // 
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.buttonHistorico);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textBoxAngulo);
            this.Controls.Add(this.textBoxVel_Correnteza);
            this.Controls.Add(this.textBoxVel_Barco);
            this.Controls.Add(this.textBoxLargura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Trajetória do Barco";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLargura;
        private System.Windows.Forms.TextBox textBoxVel_Barco;
        private System.Windows.Forms.TextBox textBoxVel_Correnteza;
        private System.Windows.Forms.TextBox textBoxAngulo;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonHistorico;
        private System.Windows.Forms.Button btnfechar;
    }
}
