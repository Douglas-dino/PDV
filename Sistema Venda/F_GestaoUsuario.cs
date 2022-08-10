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
    public partial class F_GestaoUsuario : Form
    {
        public F_GestaoUsuario()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgvUsuarios.Columns[0].Width = 60;
            dgvUsuarios.Columns[1].Width = 140;
            dgvUsuarios.Columns[2].Width = 180;
        }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vid);
                txtCodigo.Text = dt.Rows[0].ItemArray[0].ToString();
                txtNome.Text = dt.Rows[0].Field<string>("NOME").ToString();
                TxtSobrenome.Text = dt.Rows[0].Field<string>("SOBRENOME").ToString();
                txtCpf.Text = dt.Rows[0].Field<string>("CPF").ToString();
                txtLogin.Text = dt.Rows[0].Field<string>("LOGIN").ToString();
                txtSenha.Text = dt.Rows[0].Field<string>("SENHA").ToString();
                cmbStatus.Text = dt.Rows[0].Field<string>("STATUS").ToString();
                numNivel.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[7].ToString());
            }

           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int linha = dgvUsuarios.SelectedRows[0].Index;
            Usuario usuario = new Usuario();
            usuario.nome = txtNome.Text;
            usuario.sobrenome = TxtSobrenome.Text;
            usuario.cpf = txtCpf.Text;
            usuario.login = txtLogin.Text;
            usuario.senha = txtSenha.Text;
            usuario.status = cmbStatus.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(numNivel.Value, 0));
            
            Banco.Novousuario(usuario);

            dgvUsuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgvUsuarios.Columns[0].Width = 60;
            dgvUsuarios.Columns[1].Width = 140;
            dgvUsuarios.Columns[2].Width = 180;
        }
    
    

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int linha = dgvUsuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.codigo = Convert.ToInt32(txtCodigo.Text);
            u.nome = txtNome.Text;
            u.sobrenome = TxtSobrenome.Text;
            u.cpf = txtCpf.Text;
            u.login = txtLogin.Text;
            u.senha = txtSenha.Text;
            u.status = cmbStatus.Text;
            u.nivel = Convert.ToInt32(Math.Round(numNivel.Value, 0));
            Banco.AtualizarUsuario(u);
            dgvUsuarios[1, linha].Value = txtNome.Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("CONFIRMA EXCLUSÃO? \n A EXCLUSÃO DESTE REGISTRO APAGARA TODOS OS REGISTROS RELACIONADOS A ELE ",
                                                "EXCLUIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(txtCodigo.Text);
                dgvUsuarios.Rows.Remove(dgvUsuarios.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LimparTxt(this);
            cmbStatus.SelectedItem = "A";
            numNivel.Value = 1;
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
