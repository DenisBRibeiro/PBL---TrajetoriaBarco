using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL___TrajetoriaBarco
{
    public partial class Menu : Form
    {
        Thread t2;//iniciando simulação
        Thread t3;//ver simulações anteriores
        Thread t4;//instruções de uso
        public Menu()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
