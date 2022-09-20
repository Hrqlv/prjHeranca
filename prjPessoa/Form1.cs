using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ValidarCPF_Click(object sender, EventArgs e)
        {
            Pessoa p = new PessoaFisica(
                txtNome.Text,
                txtEndereço.Text,
                txtCPF.Text);
            if (p.validar() == true)
            {
                lbResposta.Text = "CPF Válido";
            }
            else lbResposta.Text = "CPF Inválido";
        }

        private void btnValidarCNPJ_Click(object sender, EventArgs e)
        {
            Pessoa p = new PessoaJuridica(
                txtNomeEmpresa.Text,
                txtEndereçoEmpresa.Text,
                txtCnpj.Text
            );
            if (p.validar() == true)
            {
                lbResposta2.Text = "CNPJ Válido";
            }
            else
            {
                lbResposta2.Text = "CPF Inválido";
            }
        }

    }
}
