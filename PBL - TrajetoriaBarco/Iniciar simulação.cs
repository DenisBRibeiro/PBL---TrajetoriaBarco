﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private double anguloCorreto;
        private double Tmin;
        private double anguloCorretoEmGraus;

        public TelaInicial()
        {
            InitializeComponent();
            historicoTentativas = new List<string>();
        }

        //CODIGO DESENVOLVIDO PARA FUNCIONALIDADE DE SALVAMENTO E EXIBIÇÃO DO HISTÓRICO EM ARQUIVO (CTRL+K e CTRL+U para descomentar)
        //ATENÇÃO!!!!--> trocar o static nas funções por private caso sejam implementadas separadamente da função principal, senão os componentes não serão reconhecidos
        /* TODO: implementação das variáveis existentes no código 
         * Adicionar um DataGridView na interface 
         * Configurar os botões para chamada das funções (botão de exibir histórico) 
         * A função SalvarSimulação() deverá ser chamada dentro do código principal
         */


        //Configuração das colunas (se não usar o designer) --

        //dataGridViewHistorico.Columns.Add("Data", "Data");
        //dataGridViewHistorico.Columns.Add("Velocidade", "Velocidade do Barco");
        //dataGridViewHistorico.Columns.Add("Correnteza", "Força da Correnteza");
        //dataGridViewHistorico.Columns.Add("Margem", "Posição da Margem");
        //dataGridViewHistorico.Columns.Add("Angulo", "Ângulo (graus)");
        //dataGridViewHistorico.Columns.Add("Distancia", "Distância (metros)");

        //ESTA FUNÇÃO DEVERÁ SER CHAMADA NO FINAL DO CALCULO NO CÓDIGO PRINCIPAL
        //static void SalvarSimulacao(adicionar parametros aqui)
        //{
        //    try
        //    {
        //        //Salva o um arquivo como histórico no caminho da pasta Documentos do usuário
        //        string caminhoPastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //        string caminhoArquivo = System.IO.Path.Combine(caminhoPastaDocumentos, "historico_simulacoes.txt");

        //        //Linha a ser gravada no arquivo
        //        string linha = $"{variabel1};{variavel2}...";

        //        //Salvar no arquivo de histórico
        //        System.IO.File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);
        //    }
        //    catch (UnauthorizedAccessException ex)
        //    {
        //        MessageBox.Show("Permissão negada para salvar o arquivo. Verifique as permissões de escrita.", "Erro de Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao acessar o arquivo. Tente novamente.", "Erro de I/O", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erro inesperado ao salvar o histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //static void CarregarHistorico()
        //{
        //    try
        //    {
        //        //Localiza o caminho da pasta Documentos do usuário
        //        string caminhoPastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //        string caminhoArquivo = System.IO.Path.Combine(caminhoPastaDocumentos, "historico_simulacoes.txt");

        //        //Verifica se o arquivo existe
        //        if (System.IO.File.Exists(caminhoArquivo))
        //        {
        //            //Limpa o DataGridView antes de carregar
        //            dataGridViewHistorico.Rows.Clear();

        //            //Lê as linhas do arquivo de histórico
        //            string[] linhas = System.IO.File.ReadAllLines(caminhoArquivo);

        //            foreach (var linha in linhas)
        //            {
        //                //Divide a linha em partes (assumindo que estão separadas por ponto e vírgula)
        //                string[] partes = linha.Split(';');

        //                //Adiciona cada linha ao DataGridView (colunas: Data, Velocidade, Correnteza, Margem, Ângulo, Distância)
        //                dataGridViewHistorico.Rows.Add(partes[0], partes[1], partes[2], partes[3], partes[4], partes[5]);
        //            }
        //        }
        //        else
        //        {
        //            //Se o arquivo não existir, exibe uma mensagem
        //            MessageBox.Show("O arquivo de histórico não foi encontrado.", "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show("Erro ao ler o arquivo de histórico. Verifique se o arquivo está acessível.", "Erro de I/O", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erro inesperado ao carregar o histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
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
                if (angulo < 20 || angulo > 160)
                    throw new ArgumentOutOfRangeException("Ângulo deve estar entre 20° e 160°.");

                // Convertendo ângulo para radianos
                double anguloEmRadianos = angulo * (Math.PI / 180);

                // Decomposição do vetor do barco
                double velX_Barco = velBarco * Math.Cos(anguloEmRadianos);
                double velY_Barco = velBarco * Math.Sin(anguloEmRadianos);

                // Vetor velocidade resultante (considerando a correnteza)
                double velX_Resultante = velX_Barco + velCorrenteza;
                double velY_Resultante = velY_Barco;

                // Ângulo do movimento resultante (barco em relação às margens)
                double anguloResultante = Math.Atan2(velY_Resultante, velX_Resultante) * (180 / Math.PI);

                // Tempo de travessia
                T = largura / velY_Resultante;

                List<double> valoresX = new List<double>();
                List<double> valoresY = new List<double>();

                for (double i = 0; i <= T; i += T/10)
                {
                    valoresX.Add(velX_Resultante * i);
                    valoresY.Add(velY_Resultante * i);
                }

                // Ponto de chegada do barco
                double xFinal = velX_Resultante * T;
                double yFinal = velY_Resultante * T;

                // Tempo mínimo de travessia (sem correnteza)
                Tmin = largura / velBarco;

                // Adicionando ao histórico
                string tentativa = $"Largura: {largura:F2} m, Velocidade do Barco: {velBarco:F2} m/s, " +
                                   $"Velocidade da Correnteza: {velCorrenteza:F2} m/s, Ângulo: {angulo:F2}°";
                historicoTentativas.Add(tentativa);

                string valoresXStr = string.Join(", ", valoresX.Select(v => v.ToString("F2")));
                string valoresYStr = string.Join(", ", valoresY.Select(v => v.ToString("F2")));

                // Exibindo os resultados
                StringBuilder mensagem = new StringBuilder();
                mensagem.AppendLine($"Ângulo resultante: {anguloResultante:F2}°");
                mensagem.AppendLine($"Tempo de travessia: {T:F2} s");
                mensagem.AppendLine($"Tempo mínimo (sem correnteza): {Tmin:F2} s");
                mensagem.AppendLine($"Ponto de chegada: ({xFinal:F2}, {yFinal:F2}) m");
                mensagem.AppendLine($"Valores em X: {valoresXStr}");
                mensagem.AppendLine($"Valores em Y: {valoresYStr}");

                MessageBox.Show(mensagem.ToString(), "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Entrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
