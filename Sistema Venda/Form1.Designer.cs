﻿
namespace Sistema_Venda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.pnBar = new System.Windows.Forms.Panel();
            this.LbCodVenda = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtPosicao = new System.Windows.Forms.TextBox();
            this.dgvCupom = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTotalCompra = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mANUTENÇÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mMMAMAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtVal = new System.Windows.Forms.TextBox();
            this.TxtQtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtCodBarra = new System.Windows.Forms.TextBox();
            this.vENDAAVULSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupom)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERADOR:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(117, 0);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(39, 20);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "-----";
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnBar.Controls.Add(this.LbCodVenda);
            this.pnBar.Controls.Add(this.label11);
            this.pnBar.Controls.Add(this.lbNivel);
            this.pnBar.Controls.Add(this.label3);
            this.pnBar.Controls.Add(this.lbHora);
            this.pnBar.Controls.Add(this.label1);
            this.pnBar.Controls.Add(this.label2);
            this.pnBar.Controls.Add(this.lbNome);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBar.Location = new System.Drawing.Point(0, 703);
            this.pnBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(1350, 26);
            this.pnBar.TabIndex = 2;
            // 
            // LbCodVenda
            // 
            this.LbCodVenda.AutoSize = true;
            this.LbCodVenda.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodVenda.ForeColor = System.Drawing.Color.White;
            this.LbCodVenda.Location = new System.Drawing.Point(520, 0);
            this.LbCodVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCodVenda.Name = "LbCodVenda";
            this.LbCodVenda.Size = new System.Drawing.Size(27, 20);
            this.LbCodVenda.TabIndex = 7;
            this.LbCodVenda.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(400, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "COD_VENDA:";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.ForeColor = System.Drawing.Color.White;
            this.lbNivel.Location = new System.Drawing.Point(324, 0);
            this.lbNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(27, 20);
            this.lbNivel.TabIndex = 5;
            this.lbNivel.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(251, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIVEL:";
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(1197, 0);
            this.lbHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(27, 20);
            this.lbHora.TabIndex = 3;
            this.lbHora.Text = "---";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1065, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATA/HORA:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 703);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtPosicao);
            this.panel4.Controls.Add(this.dgvCupom);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.TxtProduto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(752, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 703);
            this.panel4.TabIndex = 2;
            // 
            // TxtPosicao
            // 
            this.TxtPosicao.Location = new System.Drawing.Point(533, 12);
            this.TxtPosicao.Name = "TxtPosicao";
            this.TxtPosicao.Size = new System.Drawing.Size(40, 23);
            this.TxtPosicao.TabIndex = 29;
            // 
            // dgvCupom
            // 
            this.dgvCupom.AllowUserToAddRows = false;
            this.dgvCupom.AllowUserToDeleteRows = false;
            this.dgvCupom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCupom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCupom.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCupom.EnableHeadersVisualStyles = false;
            this.dgvCupom.Location = new System.Drawing.Point(15, 119);
            this.dgvCupom.MultiSelect = false;
            this.dgvCupom.Name = "dgvCupom";
            this.dgvCupom.ReadOnly = true;
            this.dgvCupom.RowHeadersVisible = false;
            this.dgvCupom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCupom.Size = new System.Drawing.Size(558, 487);
            this.dgvCupom.TabIndex = 28;
            this.dgvCupom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCupom_CellClick);
            this.dgvCupom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCupom_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "PRODUTO:";
            // 
            // TxtProduto
            // 
            this.TxtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProduto.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProduto.Location = new System.Drawing.Point(15, 49);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(558, 36);
            this.TxtProduto.TabIndex = 0;
            this.TxtProduto.TabStop = false;
            this.TxtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProduto_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.TxtTotalCompra);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtSubtotal);
            this.panel3.Controls.Add(this.TxtVal);
            this.panel3.Controls.Add(this.TxtQtd);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtCodigo);
            this.panel3.Controls.Add(this.TxtCodBarra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 703);
            this.panel3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "TOTAL:";
            // 
            // TxtTotalCompra
            // 
            this.TxtTotalCompra.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCompra.Location = new System.Drawing.Point(277, 212);
            this.TxtTotalCompra.Name = "TxtTotalCompra";
            this.TxtTotalCompra.ReadOnly = true;
            this.TxtTotalCompra.Size = new System.Drawing.Size(157, 36);
            this.TxtTotalCompra.TabIndex = 11;
            this.TxtTotalCompra.TabStop = false;
            this.TxtTotalCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalCompra_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.menuStrip2);
            this.panel5.Controls.Add(this.menuStrip1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 703);
            this.panel5.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANUTENÇÃOToolStripMenuItem1,
            this.mMMAMAMToolStripMenuItem,
            this.pRODUTOToolStripMenuItem,
            this.vENDAAVULSOToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(244, 115);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mANUTENÇÃOToolStripMenuItem1
            // 
            this.mANUTENÇÃOToolStripMenuItem1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANUTENÇÃOToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mANUTENÇÃOToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(3, 3, 116, 3);
            this.mANUTENÇÃOToolStripMenuItem1.Name = "mANUTENÇÃOToolStripMenuItem1";
            this.mANUTENÇÃOToolStripMenuItem1.Size = new System.Drawing.Size(118, 18);
            this.mANUTENÇÃOToolStripMenuItem1.Text = "GERENCIAMENTO";
            this.mANUTENÇÃOToolStripMenuItem1.Click += new System.EventHandler(this.mANUTENÇÃOToolStripMenuItem1_Click);
            // 
            // mMMAMAMToolStripMenuItem
            // 
            this.mMMAMAMToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMMAMAMToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mMMAMAMToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 3, 90, 3);
            this.mMMAMAMToolStripMenuItem.Name = "mMMAMAMToolStripMenuItem";
            this.mMMAMAMToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.mMMAMAMToolStripMenuItem.Size = new System.Drawing.Size(144, 18);
            this.mMMAMAMToolStripMenuItem.Text = "GESTÃO DE USUÁRIO";
            this.mMMAMAMToolStripMenuItem.Click += new System.EventHandler(this.mMMAMAMToolStripMenuItem_Click);
            // 
            // pRODUTOToolStripMenuItem
            // 
            this.pRODUTOToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUTOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pRODUTOToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            this.pRODUTOToolStripMenuItem.Size = new System.Drawing.Size(154, 18);
            this.pRODUTOToolStripMenuItem.Text = "GESTÃO DE PRODUTOS";
            this.pRODUTOToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.lOGINToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lOGINToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGONToolStripMenuItem,
            this.lOGOFFToolStripMenuItem});
            this.lOGINToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGINToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lOGINToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 180, 0);
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(57, 18);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // lOGONToolStripMenuItem
            // 
            this.lOGONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lOGONToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lOGONToolStripMenuItem.Name = "lOGONToolStripMenuItem";
            this.lOGONToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lOGONToolStripMenuItem.Text = "LOGON";
            this.lOGONToolStripMenuItem.Click += new System.EventHandler(this.lOGONToolStripMenuItem_Click_1);
            // 
            // lOGOFFToolStripMenuItem
            // 
            this.lOGOFFToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lOGOFFToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGOFFToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lOGOFFToolStripMenuItem.Name = "lOGOFFToolStripMenuItem";
            this.lOGOFFToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lOGOFFToolStripMenuItem.Text = "LOGOFF";
            this.lOGOFFToolStripMenuItem.Click += new System.EventHandler(this.lOGOFFToolStripMenuItem_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "SUBTOTAL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "VAL-UNITARIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "QTD:";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(589, 119);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(157, 36);
            this.TxtSubtotal.TabIndex = 5;
            this.TxtSubtotal.TabStop = false;
            this.TxtSubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSubtotal_KeyPress);
            // 
            // TxtVal
            // 
            this.TxtVal.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVal.Location = new System.Drawing.Point(411, 119);
            this.TxtVal.Name = "TxtVal";
            this.TxtVal.Size = new System.Drawing.Size(157, 36);
            this.TxtVal.TabIndex = 4;
            this.TxtVal.TabStop = false;
            this.TxtVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVal_KeyPress);
            // 
            // TxtQtd
            // 
            this.TxtQtd.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQtd.Location = new System.Drawing.Point(277, 119);
            this.TxtQtd.Name = "TxtQtd";
            this.TxtQtd.Size = new System.Drawing.Size(116, 36);
            this.TxtQtd.TabIndex = 3;
            this.TxtQtd.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "CÓDIGO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "COD-BARRA:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(277, 49);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(116, 36);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // TxtCodBarra
            // 
            this.TxtCodBarra.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodBarra.Location = new System.Drawing.Point(411, 49);
            this.TxtCodBarra.Name = "TxtCodBarra";
            this.TxtCodBarra.Size = new System.Drawing.Size(335, 36);
            this.TxtCodBarra.TabIndex = 1;
            this.TxtCodBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodBarra_KeyDown);
            // 
            // vENDAAVULSOToolStripMenuItem
            // 
            this.vENDAAVULSOToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vENDAAVULSOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vENDAAVULSOToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 130, 0);
            this.vENDAAVULSOToolStripMenuItem.Name = "vENDAAVULSOToolStripMenuItem";
            this.vENDAAVULSOToolStripMenuItem.Size = new System.Drawing.Size(107, 18);
            this.vENDAAVULSOToolStripMenuItem.Text = "VENDA AVULSO";
            this.vENDAAVULSOToolStripMenuItem.Click += new System.EventHandler(this.vENDAAVULSOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnBar);
            this.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "App Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnBar.ResumeLayout(false);
            this.pnBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupom)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtVal;
        private System.Windows.Forms.TextBox TxtQtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtCodBarra;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mANUTENÇÃOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOFFToolStripMenuItem;

        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.ToolStripMenuItem mMMAMAMToolStripMenuItem;
        public System.Windows.Forms.Label LbCodVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotalCompra;
        private System.Windows.Forms.DataGridView dgvCupom;
        private System.Windows.Forms.TextBox TxtPosicao;
        private System.Windows.Forms.ToolStripMenuItem vENDAAVULSOToolStripMenuItem;
    }
}