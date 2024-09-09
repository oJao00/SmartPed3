using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPed
{
    public partial class FRM_ANB : Form
    {
        public FRM_ANB()
        {
            InitializeComponent();
        }

        private void Btn_GerarEmail_Click(object sender, EventArgs e)
        {
            DateTime horaAtual = DateTime.Now;
            string bom;
            if (horaAtual.Hour < 12)
            {
                bom = "Bom dia!";
            }
            else
            {
                bom = "Boa tarde!";
            }

            LblSaidaEmail.Text = $"Assunto: Criação de FTP: {Box_CNPJ.Text}\n\n{bom}.\nPrecisamos configurar FTP para envio de pedido pelo SmartPed:" +
                $"\nSegue dados abaixo:\n{Box_Razao.Text}\nCNPJ: {Box_CNPJ.Text}\nCódigo do Cliente: {Box_Codigo.Text}\nLayout Trier\nAtt;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblSaidaEmail.Text);
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LblSaidaEmail.Text = "";
        }

        private void FRM_ANB_Load(object sender, EventArgs e)
        {

        }
    }
}
