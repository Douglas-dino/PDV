using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Venda
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
         
        }
       
        DataTable dt = new DataTable();
        int qtd_unitaria;
        decimal totalvenda = 0;
       
       
        int posicaoLinha;

        private void Form1_Load(object sender, EventArgs e)
        {
            GerarCodVenda();
            NomearDataGrid();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void lOGONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void lOGOFFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lbNome.Text = "---";
            lbNivel.Text = "---";
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void mANUTENÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_Relatorio f_Relatorio = new F_Relatorio();
                    f_Relatorio.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" ACESSO NÃO PERMITIDO.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        private void mMMAMAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_GestaoUsuario f_GeataoUsuario = new F_GestaoUsuario();
                    f_GeataoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" ACESSO NÃO PERMITIDO.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
           
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProduto f_GestaoProduto = new F_GestaoProduto();
            f_GestaoProduto.ShowDialog();
        }

        private void vENDAAVULSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosGlobais.cod_venda = Convert.ToInt32(LbCodVenda.Text);
            F_VendaAvulso f_VendaAvulso = new F_VendaAvulso();
            f_VendaAvulso.ShowDialog();
            GerarCodVenda();
        }
        public void GerarCodVenda()
        {
            SqlConnection conexao = new SqlConnection("Data Source = JOKER;Initial Catalog=CORONEL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT MAX(CODIGO) FROM VENDA", conexao);

            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }


                if (cmd.ExecuteScalar() == DBNull.Value)
                {
                    LbCodVenda.Text = "1";
                }
                else
                {
                    Int32 n = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    LbCodVenda.Text = n.ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }

            }


        }

        public void NomearDataGrid()
        {
            dgvCupom.ColumnCount = 5;
            dgvCupom.Columns[0].Name = "Código";
            dgvCupom.Columns[1].Name = "Produto";
            dgvCupom.Columns[2].Name = "Val unitário";
            dgvCupom.Columns[3].Name = "Quantidade";
            dgvCupom.Columns[4].Name = "Total";

            dgvCupom.Columns[0].Width = 60;
            dgvCupom.Columns[1].Width = 191;
            dgvCupom.Columns[2].Width = 120;
            dgvCupom.Columns[3].Width = 100;
            dgvCupom.Columns[4].Width = 100;
        }

        public void ConsultarProduto()
        {
            Produto P = new Produto();
            P.codigo = Convert.ToInt32(TxtCodigo.Text);

            string sql = "SELECT * FROM PRODUTO WHERE CODIGO =  '" + P.codigo + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                TxtCodBarra.Text = dt.Rows[0].ItemArray[1].ToString();
                TxtProduto.Text = dt.Rows[0].ItemArray[2].ToString();
                TxtVal.Text = dt.Rows[0].ItemArray[5].ToString();
                qtd_unitaria = Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString());
            }
            else
            {
                MessageBox.Show(" PRODUTO NÃO CONSTA NA BASE DE DADOS, VERIFIQUE O CODIGO E TENTE NOVAMENTE. ",
                                " ATENÇÃO ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        
        public void Inserirproduto()
        {
            if(qtd_unitaria < int.Parse(TxtQtd.Text))
            {
                MessageBox.Show(" ESTE PRODUTO POSSUE: " +qtd_unitaria.ToString()+" UNIDADES NO ESTOQUE! ");
            }
            else
            {
                if (!string.IsNullOrEmpty(TxtQtd.Text))
                { 
                    TxtSubtotal.Text = (Convert.ToDecimal(TxtVal.Text) * Convert.ToInt32(TxtQtd.Text)).ToString();
                }
                dgvCupom.Rows.Add(TxtCodigo.Text, TxtProduto.Text, TxtVal.Text,TxtQtd.Text,TxtSubtotal.Text);
                totalvenda += Convert.ToDecimal(TxtSubtotal.Text);
                TxtTotalCompra.Text = totalvenda.ToString("N2");

                TxtCodigo.Clear();
                TxtQtd.Text = "1";
               
            }
        }

        public void GravarVenda()
        {
            Venda v = new Venda();

            v.cod_venda = Convert.ToInt32(LbCodVenda.Text);
            v.valor = Convert.ToDecimal(TxtTotalCompra.Text);
            string sql = "SELECT * FROM USUARIO WHERE LOGIN = '" + DadosGlobais.login + "' AND SENHA ='" + DadosGlobais.senha + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                v.cod_usuario = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            }

            Banco.GravarVenda(v);
        }

        public void GravarItens()
        {
            
            ItemVenda item = new ItemVenda();
            for(int i = 0; i < dgvCupom.Rows.Count; i++)
            {
                item.cod_venda = Convert.ToInt32(LbCodVenda.Text);
                item.cod_produto = Convert.ToInt32(dgvCupom.Rows[i].Cells[0].Value);
                item.valor = Convert.ToDecimal(dgvCupom.Rows[i].Cells[4].Value);
                item.qtd_estoque = Convert.ToInt32(dgvCupom.Rows[i].Cells[3].Value);
                Banco.GravarItens(item);
            }
            
        }

        void LimparTxt(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    LimparTxt(c);
            }

            for (int i = 0; i < dgvCupom.RowCount; i++)
            {
                dgvCupom.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {

                ConsultarProduto();
                Inserirproduto();

            }
         
            if (e.KeyValue == 114)
            {
               
                GravarVenda();
                GravarItens();
                DadosGlobais.cod_venda = Convert.ToInt32(LbCodVenda.Text);
                DadosGlobais.tot_venda = Convert.ToDecimal(TxtTotalCompra.Text);

                F_pagamento f_Pagamento = new F_pagamento();
                f_Pagamento.ShowDialog();
                totalvenda = 0;

                LimparTxt(this);
                NomearDataGrid();
                GerarCodVenda();
                


            }
        }

        private void dgvCupom_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            posicaoLinha = dgvCupom.CurrentRow.Index;
            TxtPosicao.Text = posicaoLinha.ToString();
        }

        private void dgvCupom_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyValue == 115)
            {
                DialogResult res = MessageBox.Show("CONFIRMA EXCLUSÃO?", "EXCLUIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if( totalvenda > Convert.ToDecimal(dgvCupom.CurrentRow.Cells[4].Value.ToString()))
                    {
                        totalvenda =  (Convert.ToDecimal(dgvCupom.CurrentRow.Cells[4].Value.ToString()) - totalvenda) * -1;
                        TxtTotalCompra.Text = totalvenda.ToString();

                    }
                    else
                    {
                        totalvenda = totalvenda - Convert.ToDecimal(dgvCupom.CurrentRow.Cells[4].Value.ToString());
                        TxtTotalCompra.Text = totalvenda.ToString();
                    }
                    dgvCupom.Rows.RemoveAt(Int32.Parse(TxtPosicao.Text));
                   
                   
                }
                
            }
        }

        private void TxtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13) {
                Produto P = new Produto();
                P.nome = TxtProduto.Text;

                string sql = "SELECT * FROM PRODUTO WHERE NOME =  '" + P.nome + "'";
                dt = Banco.dql(sql);

                if (dt.Rows.Count == 1){

                    TxtCodigo.Text = dt.Rows[0].ItemArray[0].ToString();
                    TxtCodBarra.Text = dt.Rows[0].ItemArray[1].ToString();
                    TxtVal.Text = dt.Rows[0].ItemArray[5].ToString();
                    qtd_unitaria = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                }
                else{
                    MessageBox.Show(" PRODUTO NÃO CONSTA NA BASE DE DADOS, VERIFIQUE O CODIGO E TENTE NOVAMENTE. ",
                                    " ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Inserirproduto();
            }
            
        }

        private void TxtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Produto P = new Produto();
                P.cod_barra = TxtCodBarra.Text;

                string sql = "SELECT * FROM PRODUTO WHERE COD_BARRA =  '" + P.cod_barra + "'";
                dt = Banco.dql(sql);

                if (dt.Rows.Count == 1)
                {

                    TxtCodigo.Text = dt.Rows[0].ItemArray[0].ToString();
                    TxtProduto.Text = dt.Rows[0].ItemArray[2].ToString();
                    TxtVal.Text = dt.Rows[0].ItemArray[5].ToString();
                    qtd_unitaria = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                }
                else
                {
                    MessageBox.Show(" PRODUTO NÃO CONSTA NA BASE DE DADOS, VERIFIQUE O CODIGO DE BARRAS E TENTE NOVAMENTE. ",
                                    " ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Inserirproduto();
            }

        }

        private void TxtVal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTotalCompra_KeyPress(object sender, KeyPressEventArgs e)
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

       
    }


}
