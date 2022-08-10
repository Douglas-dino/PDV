using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venda
{
    class Banco
    {
        ////// Funções Generica.

        private static SqlConnection conexao;
        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection(" Data Source = JOKER;Initial Catalog=CORONEL;Integrated Security=True");
            conexao.Open();
            return conexao;
        }

        /// //////////////////////////////////////////////////////////////////

       

        public static DataTable dql(string sql)// Data Query Lanquage(select) 
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// //////////////////////////////////////////////////////////////////

        public static void dml(string q, string msgOK = null, string msgERRO = null) // Data Manipulation Language( Insert, Delete, Update )
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }


            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }


        //////// Fim Funções  Genericas

        /// //////////////////////////////////////////////////////////////////

        ///Consulta geral.

        public static DataTable ObterTodosUsuarios()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM USUARIO";
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// Fim Consulta geral.


        /// //////////////////////////////////////////////////////////////////



        /// //////////////////////////////////////////////////////////////////


        /////// Funções do Form F_GestaoUsuario

        public static DataTable ObterUsuariosIdNome()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                        SELECT 
                            CODIGO 
                        AS 
                           'Código ', 
                            NOME 
                        AS 
                            'Nome ', 
                            SOBRENOME
                        AS 
                            'Sobrenome ' 
                        FROM 
                            USUARIO";
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario WHERE CODIGO =" + id;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarUsuario(Usuario u)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE usuario SET NOME ='" + u.nome + "', SOBRENOME ='" + u.sobrenome + "', CPF ='" + u.cpf + "', LOGIN = '" + u.login + "', SENHA ='" + u.senha + "', STATUS ='" + u.status + "', NIVEL = " + u.nivel + " WHERE CODIGO =" + u.codigo;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show(" CADASTRO ATUALIZADO!", "ATUALIZAÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM USUARIO WHERE CODIGO =" + id;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /////// Fim Funções do Form F_GestaoUsuario

        /// //////////////////////////////////////////////////////////////////

        //////// Funções do Form F_NovoUsuario

        public static void Novousuario(Usuario u)
        {
            if (existelogin(u))
            {
                MessageBox.Show("Login já exixtente, Tente outro login");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                        INSERT INTO USUARIO(
                            NOME, SOBRENOME, CPF, LOGIN, SENHA, STATUS, NIVEL)
                        VALUES (
                            @NOME, @SOBRENOME, @CPF, @LOGIN, @SENHA, @STATUS, @NIVEL) ";


                cmd.Parameters.AddWithValue("@NOME", u.nome);
                cmd.Parameters.AddWithValue("@SOBRENOME", u.sobrenome);
                cmd.Parameters.AddWithValue("@CPF", u.cpf);
                cmd.Parameters.AddWithValue("@LOGIN", u.login);
                cmd.Parameters.AddWithValue("@SENHA", u.senha);
                cmd.Parameters.AddWithValue("@STATUS", u.status);
                cmd.Parameters.AddWithValue("@NIVEL", u.nivel);

                cmd.ExecuteNonQuery();

                MessageBox.Show("NOVO USUÁRIO CADASTRADO");
                vcon.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("ERRO AO CADASTRAR NOVO USUÁRIO!");

            }
        }

        /////// Fim Funções do Form F_NovoUsuario

        /// //////////////////////////////////////////////////////////////////

       
      

        /////// Funções do Form F_NovoProduto

        public static void Novoproduto(Produto p)
        {

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                       INSERT INTO PRODUTO(
                            COD_BARRA, NOME, DESCRICAO, QTD_ESTOQUE, VALOR, COD_USUARIO)
                       VALUES(
                            @COD_BARRA, @NOME, @DESCRICAO, @QTD_ESTOQUE, @VALOR, @COD_USUARIO) ";

                cmd.Parameters.AddWithValue("@COD_BARRA", p.cod_barra);
                cmd.Parameters.AddWithValue("@NOME", p.nome);
                cmd.Parameters.AddWithValue("@DESCRICAO", p.descricao);
                cmd.Parameters.AddWithValue("@QTD_ESTOQUE", p.qtd_estoque);
                cmd.Parameters.AddWithValue("@VALOR", p.valor);
                cmd.Parameters.AddWithValue("@COD_USUARIO", p.cod_usuario);

                cmd.ExecuteNonQuery();

                MessageBox.Show("NOVO PRODUTO CADASTRADO");
                vcon.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO CADASTRAR NOVO PRODUTO!");

            }
        }

        /////// Fim Funções do Form F_NovoProduto

        /// /////////////////////////////////////////////////////////////////////////////////

        /////// Funções do Form F_Gestão produto

        public static DataTable ObterProdutoId()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                        SELECT 
                            CODIGO AS 'Código',  
                            COD_BARRA AS'Cod_Barra', 
                            NOME AS 'Produto', 
                            DESCRICAO AS 'Descrição', 
                            QTD_ESTOQUE as 'Qtd_Estoque',
                            VALOR, 
                            COD_USUARIO AS 'Cod_Usuário' 
                        FROM 
                            PRODUTO";

                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterProduto(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                        SELECT
                            CODIGO, 
                            COD_BARRA, 
                            NOME, 
                            DESCRICAO, 
                            QTD_ESTOQUE,
                            VALOR,
                            COD_USUARIO     
                        FROM 
                            PRODUTO
                        WHERE 
                            CODIGO =" + id;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarProduto(Produto p)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                    UPDATE 
                        PRODUTO 
                    SET 
                        COD_BARRA = @COD_BARRA, 
                        NOME = @NOME, 
                        DESCRICAO = @DESCRICAO,
                        QTD_ESTOQUE = @QTD_ESTOQUE, 
                        VALOR = @VALOR  
                    WHERE 
                        CODIGO = @CODIGO";
                cmd.Parameters.AddWithValue("@CODIGO", p.codigo);
                cmd.Parameters.AddWithValue("@COD_BARRA", p.cod_barra);
                cmd.Parameters.AddWithValue("@NOME", p.nome);
                cmd.Parameters.AddWithValue("@DESCRICAO", p.descricao);
                cmd.Parameters.AddWithValue("@QTD_ESTOQUE", p.qtd_estoque);
                cmd.Parameters.AddWithValue("@VALOR", p.valor) ;
               
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarProduto(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM PRODUTO WHERE CODIGO =" + id;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /////// Fim Funções do Form F_Gestão Produto


        /// /////////////////////////////////////////////////////////////////////////////////

        /////// Gravação de venda

        public static void GravarVenda(Venda v)
        {

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                       INSERT VENDA(
                            CODIGO, 
                            VALOR,
                            COD_USUARIO)
                       VALUES(
                            @CODIGO,
                            @VALOR,
                            @COD_USUARIO) ";

                cmd.Parameters.AddWithValue("@CODIGO", v.cod_venda);
                cmd.Parameters.AddWithValue("@VALOR", v.valor);
                cmd.Parameters.AddWithValue("@COD_USUARIO", v.cod_usuario);

                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO CADASTRAR VENDA!");

            }
        }
        public static void GravarItens(ItemVenda i)
        {

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                       INSERT ITEM_VENDA(
                            COD_VENDA, 
                            COD_PRODUTO,
                            VAL_UNITARIO,
                            QUANTIDADE)
                       VALUES(
                            @COD_VENDA,
                            @COD_PRODUTO, 
                            @VAL_UNITARIO,
                            @QUANTIDADE) "; 

                cmd.Parameters.AddWithValue("@COD_VENDA", i.cod_venda);
                cmd.Parameters.AddWithValue("@COD_PRODUTO", i.cod_produto);
                cmd.Parameters.AddWithValue("@VAL_UNITARIO", i.valor);
                cmd.Parameters.AddWithValue("@QUANTIDADE", i.qtd_estoque);

                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR VENDA!");
                throw ex;
            }
        }

        /////// Fim Gravação de venda

        ////////////////////////////////////////////////////////

        ///////  Gravação de pagasmento
        public static void GravarPagamento(Pagamento p)
        {

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                       INSERT PAGAMENTO(
                            TIPO_PG, 
                            TOTAL,
                            TROCO,
                            COD_VENDA,
                            COD_USUARIO)
                       VALUES(
                            
                            @TIPO_PG,
                            @TOTAL,
                            @TROCO,
                            @COD_VENDA,
                            @COD_USUARIO) ";
              
                cmd.Parameters.AddWithValue("@TIPO_PG", p.tipo_pg);
                cmd.Parameters.AddWithValue("@TOTAL", p.total);
                cmd.Parameters.AddWithValue("@TROCO", p.troco);
                cmd.Parameters.AddWithValue("@COD_VENDA", p.cod_venda);
                cmd.Parameters.AddWithValue("@COD_USUARIO", p.cod_usuario);

                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO CADASTRAR PAGAMENTO!");
                throw;
            }
        }

        public static DataTable ObterRelatorio()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                        SELECT 
	                        VENDA.CODIGO AS ID_VENDA,
                            CONVERT(VARCHAR, VENDA.DATA, 104) AS DATA,
	                        CONVERT(VARCHAR, VENDA.HORA, 8) AS HORA, 
	                        VENDA.VALOR AS VAL_COMPRA,
                            PAGAMENTO.TIPO_PG,
                            PAGAMENTO.TOTAL AS PAGAMENTO,
	                        PAGAMENTO.TROCO,
	                        USUARIO.NOME AS OPERADOR

                        FROM 
	                        VENDA
	                    INNER JOIN 
		                    USUARIO ON VENDA.COD_USUARIO = USUARIO.CODIGO
                        INNER JOIN 
		                    PAGAMENTO ON PAGAMENTO.COD_VENDA = VENDA.CODIGO
                       ORDER BY  
                            ID_VENDA DESC";


                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /////// Fim Gravação de pagamento

        ////////////////////////////////////////////////////////

        ////// Rotinas Gerais

        public static bool existelogin(Usuario u)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT LOGIN FROM USUARIO  WHERE LOGIN ='" + u.login + "'";
            da = new SqlDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            vcon.Close();
            return res;
        }
    }
}
