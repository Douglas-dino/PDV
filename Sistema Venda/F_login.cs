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
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
      

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            DadosGlobais.login = txtUsuario.Text;
            DadosGlobais.senha = txtSenha.Text;

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show(" USUÁRIO E SENHA SÃO CAMPOS OBRIGATORIOS. ", " ATENÇÃO! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            string sql = "SELECT * FROM USUARIO WHERE LOGIN = '" + DadosGlobais.login + "' AND SENHA ='" + DadosGlobais.senha + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                
                Globais.status = dt.Rows[0].ItemArray[6].ToString();
            
                 if (Globais.status == "I")
                 {
                    MessageBox.Show(" USUARIO INATIVO! \n ENTRE EM CONTADO COM O ADMINISTRATOR.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                 }
                else 
                {
                    form1.lbNome.Text = dt.Rows[0].ItemArray[1].ToString();
                    form1.lbNivel.Text = dt.Rows[0].ItemArray[7].ToString();
                    Globais.logado = true;
                    Globais.nivel = Convert.ToInt32(dt.Rows[0].ItemArray[7].ToString());
                    this.Close();
                 }

                
               
            }
            else
            {
                MessageBox.Show(" USUÁRIO NÃO ENCONTRADO, VERIFIQUE LOGIN E SENHA. ", " ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
