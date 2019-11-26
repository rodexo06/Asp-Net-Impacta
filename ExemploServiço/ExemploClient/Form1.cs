using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wcf = new ServiceReference1.Service1Client();

            string msg = wcf.Mensagem();
            int somatotal = wcf.Somar(2, 4);
            DateTime DataHora = wcf.DataHoraServidor();
            ServiceReference1.Produto p = wcf.OfertaDoDia();
            MessageBox.Show(msg);
            MessageBox.Show("" + somatotal);
            MessageBox.Show(p.Nome + p.Preco.ToString("C"));
            MessageBox.Show("" +DataHora);



        }
    }
}
