namespace apPrincipal
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.tsBotoes = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.ssMensagem = new System.Windows.Forms.StatusStrip();
            this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.tsBotoes.SuspendLayout();
            this.ssMensagem.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBotoes
            // 
            this.tsBotoes.BackColor = System.Drawing.Color.Silver;
            this.tsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator4,
            this.btnSair});
            this.tsBotoes.Location = new System.Drawing.Point(0, 0);
            this.tsBotoes.Name = "tsBotoes";
            this.tsBotoes.Size = new System.Drawing.Size(717, 38);
            this.tsBotoes.TabIndex = 0;
            this.tsBotoes.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 35);
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.ToolTipText = "Posiciona no primeiro registro";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(54, 35);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.ToolTipText = "Vai ao anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(55, 35);
            this.btnProximo.Text = "Proximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.ToolTipText = "Vai ao proximo";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(47, 35);
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimo.ToolTipText = "Posiciona no último registro";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(56, 35);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.ToolTipText = "Procurar um registro";
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 35);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.ToolTipText = "Novo registro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 35);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.ToolTipText = "Editar o registro atual";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Cancela a opreção atual";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 35);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.ToolTipText = "Ele salva";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 35);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.ToolTipText = "Excluir os dados atuais";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 35);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.ToolTipText = "Encerra o programa";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ssMensagem
            // 
            this.ssMensagem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ssMensagem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlbMensagem});
            this.ssMensagem.Location = new System.Drawing.Point(0, 242);
            this.ssMensagem.Name = "ssMensagem";
            this.ssMensagem.Padding = new System.Windows.Forms.Padding(1, 0, 24, 0);
            this.ssMensagem.Size = new System.Drawing.Size(717, 22);
            this.ssMensagem.TabIndex = 2;
            this.ssMensagem.Tag = "a";
            this.ssMensagem.Text = "Mensagem";
            // 
            // stlbMensagem
            // 
            this.stlbMensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stlbMensagem.Name = "stlbMensagem";
            this.stlbMensagem.Size = new System.Drawing.Size(78, 17);
            this.stlbMensagem.Text = "Mensagem:";
            // 
            // imlBotoes
            // 
            this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
            this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBotoes.Images.SetKeyName(0, "first.bmp");
            this.imlBotoes.Images.SetKeyName(1, "prior.bmp");
            this.imlBotoes.Images.SetKeyName(2, "next.bmp");
            this.imlBotoes.Images.SetKeyName(3, "last.bmp");
            this.imlBotoes.Images.SetKeyName(4, "FIND.BMP");
            this.imlBotoes.Images.SetKeyName(5, "Add.bmp");
            this.imlBotoes.Images.SetKeyName(6, "COPY.BMP");
            this.imlBotoes.Images.SetKeyName(7, "UNDO.BMP");
            this.imlBotoes.Images.SetKeyName(8, "Save.bmp");
            this.imlBotoes.Images.SetKeyName(9, "Minus.bmp");
            this.imlBotoes.Images.SetKeyName(10, "CLOSE1.BMP");
            this.imlBotoes.Images.SetKeyName(11, "abort.bmp");
            this.imlBotoes.Images.SetKeyName(12, "about.bmp");
            this.imlBotoes.Images.SetKeyName(13, "Oeil2.bmp");
            this.imlBotoes.Images.SetKeyName(14, "PRINTER5.BMP");
            this.imlBotoes.Images.SetKeyName(15, "REDO.BMP");
            this.imlBotoes.Images.SetKeyName(16, "WINNEXT.BMP");
            this.imlBotoes.Images.SetKeyName(17, "WINPREV.BMP");
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // tpCadastro
            // 
            this.tpCadastro.BackColor = System.Drawing.Color.PeachPuff;
            this.tpCadastro.Controls.Add(this.txtDica);
            this.tpCadastro.Controls.Add(this.txtPalavra);
            this.tpCadastro.Controls.Add(this.label4);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tpCadastro.Location = new System.Drawing.Point(4, 32);
            this.tpCadastro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpCadastro.Size = new System.Drawing.Size(709, 137);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(134, 37);
            this.txtPalavra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPalavra.MaxLength = 15;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(292, 30);
            this.txtPalavra.TabIndex = 3;
            this.txtPalavra.Leave += new System.EventHandler(this.txtMatricula_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dica:";
            // 
            // txtDica
            // 
            this.txtDica.Location = new System.Drawing.Point(134, 92);
            this.txtDica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDica.MaxLength = 99;
            this.txtDica.Name = "txtDica";
            this.txtDica.Size = new System.Drawing.Size(292, 30);
            this.txtDica.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpCadastro);
            this.tabControl.Controls.Add(this.tpLista);
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(717, 173);
            this.tabControl.TabIndex = 1;
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(11, 9);
            this.txtLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(689, 119);
            this.txtLista.TabIndex = 0;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.txtLista);
            this.tpLista.Location = new System.Drawing.Point(4, 32);
            this.tpLista.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpLista.Size = new System.Drawing.Size(709, 137);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            this.tpLista.Enter += new System.EventHandler(this.tpLista_Enter);
            // 
            // FrmFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 264);
            this.Controls.Add(this.ssMensagem);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tsBotoes);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmFunc";
            this.Text = "Manuntenção de Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFunc_FormClosing);
            this.Load += new System.EventHandler(this.FrmFunc_Load);
            this.tsBotoes.ResumeLayout(false);
            this.tsBotoes.PerformLayout();
            this.ssMensagem.ResumeLayout(false);
            this.ssMensagem.PerformLayout();
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.tpLista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBotoes;
        private System.Windows.Forms.StatusStrip ssMensagem;
        private System.Windows.Forms.ToolStripButton btnInicio;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ImageList imlBotoes;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.ToolStripStatusLabel stlbMensagem;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TextBox txtDica;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.TextBox txtLista;
    }
}

