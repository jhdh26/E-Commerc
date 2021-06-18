using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabelac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridtotal.DataSource = clsVendas.Consultar();
        }
        private void Preenchergrid(List<clsVendas> lista)
        {
            gridtotal.DataSource = new BindingList<clsVendas>(lista);
        }
        private void LimpaTextBox()
        {
            txtboxid.Text = "";
            txtboxnome.Text = "";
            txtboxpreco.Text = "";
            txtboxobs.Text = "";
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            txtboxid.Focus();
                clsVendas aux = new clsVendas(
                    int.Parse(txtboxid.Text), txtboxnome.Text, txtboxpreco.Text, txtboxobs.Text);
                aux.Inserir();
            Preenchergrid(clsVendas.Consultar());
            LimpaTextBox();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Preenchergrid(clsVendas.Consultar(txtnome_pesquisar.Text));
        }

        private void gridtotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridtotal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridtotal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
