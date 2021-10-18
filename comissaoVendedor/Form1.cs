using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comissaoVendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            Vendedor vend = new Vendedor();
            double vendas = Convert.ToDouble(txtVendas.Text);
            vend.salarioBase = Convert.ToDouble(txtSalario.Text);
            vend.nome = txtNome.Text;

            double comissao = vend.calculoComissao(vendas);

            double salarioFinal = comissao + vend.salarioBase;
            MessageBox.Show("Total em Comissões: " + comissao.ToString() +
                "\nSalário Final: " + salarioFinal.ToString());
        }
    }
}
