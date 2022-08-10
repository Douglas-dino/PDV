﻿using System;
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
    public partial class F_GestaoProduto : Form
    {
        public F_GestaoProduto()
        {
            InitializeComponent();
           
        }
        DataTable dt = new DataTable();


        private void F_GestaoProduto_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = Banco.ObterProdutoId();
            dgvProduto.Columns[0].Width = 50;
            dgvProduto.Columns[1].Width = 70;
            dgvProduto.Columns[2].Width = 100;
            dgvProduto.Columns[3].Width = 140;
            dgvProduto.Columns[4].Width = 70;
            dgvProduto.Columns[5].Width = 50;
            dgvProduto.Columns[6].Width = 70;
        }

        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterProduto(vid);
                txtCodigo.Text = dt.Rows[0].ItemArray[0].ToString();
                txtCodBarra.Text = dt.Rows[0].ItemArray[1].ToString();
                txtProduto.Text = dt.Rows[0].ItemArray[2].ToString();
                txtDesc.Text = dt.Rows[0].ItemArray[3].ToString();
                txtEstoque.Text = dt.Rows[0].ItemArray[4].ToString();
                txtValor.Text = dt.Rows[0].ItemArray[5].ToString();
                txtIdUsuario.Text = dt.Rows[0].ItemArray[6].ToString();
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            string sql = "SELECT * FROM USUARIO WHERE LOGIN = '" + DadosGlobais.login + "' AND SENHA ='" + DadosGlobais.senha + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                produto.cod_usuario = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            }
            produto.cod_barra = txtCodBarra.Text;
            produto.nome = txtProduto.Text;
            produto.descricao = txtDesc.Text;
            produto.qtd_estoque = Convert.ToInt32(txtEstoque.Text);
            produto.valor = Convert.ToDecimal(txtValor.Text);
            Banco.Novoproduto(produto);

            dgvProduto.DataSource = Banco.ObterProdutoId();
            dgvProduto.Columns[0].Width = 50;
            dgvProduto.Columns[1].Width = 70;
            dgvProduto.Columns[2].Width = 140;
            dgvProduto.Columns[3].Width = 140;
            dgvProduto.Columns[4].Width = 70;
            dgvProduto.Columns[5].Width = 50;
            dgvProduto.Columns[6].Width = 70;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
               
                        int linha = dgvProduto.SelectedRows[0].Index;
                        Produto p = new Produto();
                        p.codigo = Convert.ToInt32(txtCodigo.Text);
                        p.cod_barra = txtCodBarra.Text;
                        p.nome = txtProduto.Text;
                        p.descricao = txtDesc.Text;
                        p.qtd_estoque = Convert.ToInt32(txtEstoque.Text);
                        p.valor = Convert.ToDecimal(txtValor.Text);
                        p.cod_usuario = Convert.ToInt32(txtIdUsuario.Text);
                        Banco.AtualizarProduto(p);

                        dgvProduto[1, linha].Value = txtCodBarra.Text;
                        dgvProduto[2, linha].Value = txtProduto.Text;
                        dgvProduto[3, linha].Value = txtDesc.Text;
                        dgvProduto[4, linha].Value = txtEstoque.Text;
                        dgvProduto[5, linha].Value = txtValor.Text;

                        MessageBox.Show(" PRODUTO ATUALIZADO!", "ATUALIZAÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                  
                }
                else
                {

                    MessageBox.Show(" ACESSO NÃO PERMITIDO.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    DialogResult res = MessageBox.Show("CONFIRMA EXCLUSÃO? \n A EXCLUSÃO DESTE REGISTRO APAGARA TODOS OS REGISTROS RELACIONADOS A ELE", 
                                                        "EXCLUIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        Banco.DeletarProduto(txtCodigo.Text);
                        dgvProduto.Rows.Remove(dgvProduto.CurrentRow);

                        LimparTxt(this);
                        txtCodBarra.Focus();

                    }

                }
                else
                {

                    MessageBox.Show(" ACESSO NÃO PERMITIDO.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt(this);
            txtCodBarra.Focus();
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
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
