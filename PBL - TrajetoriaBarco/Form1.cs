using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL___TrajetoriaBarco
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            // Ler o texto da caixa de texto
            string userInput = Largura.Text;

            // Exibir uma mensagem com a entrada do usuário
            MessageBox.Show("Você digitou: " + userInput);
        }
    }
}
