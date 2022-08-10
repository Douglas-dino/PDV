using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venda
{
    public partial class F_VendaAvulso : Form
    {
        public F_VendaAvulso()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        decimal subtoal;
        decimal total;
        public void GravarVenda()
        {
            Venda v = new Venda();

            v.cod_venda = DadosGlobais.cod_venda;
            v.valor = Convert.ToDecimal(TxtTotal.Text);
            string sql = "SELECT * FROM USUARIO WHERE LOGIN = '" + DadosGlobais.login + "' AND SENHA ='" + DadosGlobais.senha + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                v.cod_usuario = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            }

            Banco.GravarVenda(v);
        }
        public void Pagamento()
        {
            Pagamento p = new Pagamento();
            p.total = Convert.ToDecimal(TxtSubtotal.Text);
            p.troco = Convert.ToDecimal(TxtTroco.Text);
            p.tipo_pg = CmbTipopg.SelectedItem.ToString();
            p.cod_venda = DadosGlobais.cod_venda;

            string sql = "SELECT * FROM USUARIO WHERE LOGIN = '" + DadosGlobais.login + "' AND SENHA ='" + DadosGlobais.senha + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                p.cod_usuario = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            }

            Banco.GravarPagamento(p);

        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)

                e.Handled = true;

            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

        }

        private void TxtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)

                e.Handled = true;

            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

        }

        private void TxtTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)

                e.Handled = true;

            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

        }

        private void TxtSubtotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                subtoal = Convert.ToDecimal(TxtSubtotal.Text);
                total = Convert.ToDecimal(TxtTotal.Text);
                TxtTroco.Text = Convert.ToString(subtoal - total);

            }
            if (e.KeyValue == 114)
            {
                GravarVenda();
                Pagamento();
                this.Close();
            }
        }
    }
}
