using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PBL___TrajetoriaBarco
{
    public partial class TelaInicial : Form
    {
        private double velBarco;
        private double velCorrenteza;
        private double angulo;
        private double largura;
        private double T; // Tempo total de travessia
        private List<string> historicoTentativas; // Lista para armazenar o histórico de tentativas

        public TelaInicial()
        {
            InitializeComponent();
            historicoTentativas = new List<string>();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                // Lendo e validando a largura do rio
                largura = double.Parse(textBoxLargura.Text);
                if (largura < 20 || largura > 100)
                    throw new ArgumentOutOfRangeException("Largura deve estar entre 20 m e 100 m.");

                // Lendo e validando a velocidade do barco
                velBarco = double.Parse(textBoxVel_Barco.Text);
                if (velBarco < 2.0 || velBarco > 10.0)
                    throw new ArgumentOutOfRangeException("Velocidade do barco deve estar entre 2.0 m/s e 10.0 m/s.");

                // Lendo e validando a velocidade da correnteza
                velCorrenteza = double.Parse(textBoxVel_Correnteza.Text);
                if (velCorrenteza < 1.0 || velCorrenteza > 4.0)
                    throw new ArgumentOutOfRangeException("Velocidade da correnteza deve estar entre 1.0 m/s e 4.0 m/s.");

                // Lendo e validando o ângulo
                angulo = double.Parse(textBoxAngulo.Text);
                if (angulo <= 20 || angulo >= 160)
                    throw new ArgumentOutOfRangeException("Ângulo deve estar entre 20° e 160°.");

                // Convertendo ângulo para radianos
                angulo = angulo * Math.PI / 180;

                // Calculando o tempo de travessia 
                T = largura / (velBarco * Math.Sin(angulo)); // Tempo total de travessia

                // Adicionando a tentativa ao histórico
                string tentativa = $"Largura: {largura} m, Velocidade do Barco: {velBarco} m/s, Velocidade da Correnteza: {velCorrenteza} m/s, Ângulo: {angulo * 180 / Math.PI}°";
                historicoTentativas.Add(tentativa);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHistorico_Click(object sender, EventArgs e)
        {
            if (historicoTentativas.Count == 0)
            {
                MessageBox.Show("Não há tentativas registradas.", "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Criando um Form para selecionar tentativa
            Form selecionarTentativaForm = new Form
            {
                Text = "Selecionar Tentativa",
                Width = 475,
                Height = 300
            };

            ListBox listBox = new ListBox
            {
                Dock = DockStyle.Fill,
                DataSource = historicoTentativas
            };

            Button usarDadosButton = new Button
            {
                Text = "Usar Dados",
                Dock = DockStyle.Bottom
            };

            Button voltarButton = new Button
            {
                Text = "Voltar",
                Dock = DockStyle.Bottom
            };

            usarDadosButton.Click += (s, args) =>
            {
                if (listBox.SelectedItem != null)
                {
                    string[] dados = listBox.SelectedItem.ToString().Split(new string[] { ", " }, StringSplitOptions.None);
                    textBoxLargura.Text = dados[0].Split(':')[1].Trim().Replace(" m", "");
                    textBoxVel_Barco.Text = dados[1].Split(':')[1].Trim().Replace(" m/s", "");
                    textBoxVel_Correnteza.Text = dados[2].Split(':')[1].Trim().Replace(" m/s", "");
                    textBoxAngulo.Text = dados[3].Split(':')[1].Trim().Replace("°", "");
                    selecionarTentativaForm.Close();
                }
                else
                {
                    MessageBox.Show("Selecione uma tentativa antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            voltarButton.Click += (s, args) =>
            {
                selecionarTentativaForm.Close();
            };

            selecionarTentativaForm.Controls.Add(listBox);
            selecionarTentativaForm.Controls.Add(usarDadosButton);
            selecionarTentativaForm.Controls.Add(voltarButton);
            selecionarTentativaForm.ShowDialog();
        }
    }
}
