using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Sistema_Venda
{
    public partial class F_Relatorio : Form
    {
        public F_Relatorio()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        string sql;
        private void F_Relatorio_Load(object sender, EventArgs e)
        {

            NomearDataGrid();
           

        }
        
        public void NomearDataGrid()
        {
            dgvRelatorio.ColumnCount = 8;
            dgvRelatorio.Columns[0].Name = "ID_VENDA";
            dgvRelatorio.Columns[1].Name = "DATA";
            dgvRelatorio.Columns[2].Name = "HORA";
            dgvRelatorio.Columns[3].Name = "VAL_COMPRA";
            dgvRelatorio.Columns[4].Name = "TIPO_PG";
            dgvRelatorio.Columns[5].Name = "PAGAMENTO";
            dgvRelatorio.Columns[6].Name = "TROCO";
            dgvRelatorio.Columns[7].Name = "OPERADOR";

            dgvRelatorio.Columns[0].Width = 70;
            dgvRelatorio.Columns[1].Width = 80;
            dgvRelatorio.Columns[2].Width = 80;
            dgvRelatorio.Columns[3].Width = 110;
            dgvRelatorio.Columns[4].Width = 110;
            dgvRelatorio.Columns[5].Width = 110;
            dgvRelatorio.Columns[6].Width = 120;
            dgvRelatorio.Columns[7].Width = 120;
        }
        public void ConsultaRelatorio()
        {
                 sql = @"
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
                        WHERE VENDA.DATA BETWEEN '" + monthCalendar1.SelectionStart + "' AND '" + monthCalendar1.SelectionEnd + "' ORDER BY  ID_VENDA DESC";
                dt = Banco.dql(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dgvRelatorio.Rows.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(),
                    dt.Rows[i].ItemArray[2].ToString(), dt.Rows[i].ItemArray[3].ToString(), dt.Rows[i].ItemArray[4].ToString(),
                    dt.Rows[i].ItemArray[5].ToString(), dt.Rows[i].ItemArray[6].ToString(), dt.Rows[i].ItemArray[7].ToString());

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

            for (int i = 0; i < dgvRelatorio.RowCount; i++)
            {
                dgvRelatorio.Rows[i].DataGridView.Columns.Clear();
            }
        }

        public void CalculoCaixa()
        {
            decimal total = 0;
            decimal total_troco = 0;
            decimal total_caixa = 0;


            foreach (DataGridViewRow row in dgvRelatorio.Rows)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["VAL_COMPRA"].Value)) && 
                    !string.IsNullOrEmpty(Convert.ToString(row.Cells["TROCO"].Value)))

                    total += Convert.ToDecimal(row.Cells["VAL_COMPRA"].Value);
                    total_troco += Convert.ToDecimal(row.Cells["TROCO"].Value);
            }

            TxtVal.Text = total.ToString("N2");
            TxtTroco.Text = total_troco.ToString("N2");

            total_caixa = Convert.ToDecimal(TxtVal.Text) - Convert.ToDecimal(TxtTroco.Text);
            TxtCaixa.Text = total_caixa.ToString("N2");


        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaRelatorio();
            CalculoCaixa();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt(this);
            NomearDataGrid();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + "relatorio.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
            doc.Open();
            string dados = "";

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14 , (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add(" CORONEL AGROPET ");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            string texto = " Relatório \n\n";
            paragrafo1.Add(texto);

           // Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic));
            //paragrafo2.Alignment = Element.ALIGN_LEFT;
            //texto = "\n\n";
            //paragrafo2.Add(texto);

            PdfPTable tabela = new PdfPTable(3); // 3 colunas
            tabela.DefaultCell.FixedHeight = 20;
            tabela.WidthPercentage = 105f;
           

            PdfPCell celula = new PdfPCell(new Phrase("Relatório"));
            celula.Colspan = 3; // linha mesclada
            celula.Rotation = 90;
            
            tabela.AddCell(celula);

            tabela.AddCell("ID_VENDA");
            tabela.AddCell("DATA");
            tabela.AddCell("VAL_COMPRA");

            dt = Banco.dql(sql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                tabela.AddCell(dt.Rows[i].ItemArray[0].ToString());
                tabela.AddCell(dt.Rows[i].ItemArray[1].ToString());
                tabela.AddCell(dt.Rows[i].ItemArray[3].ToString());
            }
            
            /*celula.Rotation = 0;
            celula.Colspan = 8;
            celula.FixedHeight = 40;
            celula.HorizontalAlignment = Element.ALIGN_CENTER;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.AddCell(celula);*/

            doc.Open();
            doc.Add(paragrafo1);
            //doc.Add(paragrafo2);
            doc.Add(tabela);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relátorio?", "Relatório", MessageBoxButtons.YesNo);
            
            if(res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + "relatorio.pdf");
            }
        }
    }
}
