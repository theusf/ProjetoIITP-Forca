using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apPrincipal
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        VetPalavraCadastro asPalavras = null;
        private void FrmFunc_Load(object sender, EventArgs e)
        {

            tsBotoes.ImageList = imlBotoes;
            int indice = 0;
            foreach (ToolStripItem item in tsBotoes.Items)
                if (item is ToolStripButton)
                    (item as ToolStripButton).ImageIndex = indice++;

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                asPalavras = new VetPalavraCadastro(20);
                asPalavras.LerDados(dlgAbrir.FileName);

                asPalavras.PosicionarNoInicio();
                AtualizarTela();

            }
        }

        public void LimparTela()
        {
            txtPalavra.Clear();
            txtDica.Clear();



        }
        private void AtualizarTela()
        {
            if (asPalavras.EstaVazio())
                LimparTela();
            else
            {
                PalavraDica qualPalavra = asPalavras[asPalavras.PosicaoAtual];
                txtDica.Text = qualPalavra.DicaUsada + "";
                txtPalavra.Text = qualPalavra.PalavraUsada + "";

                stlbMensagem.Text = "Registro " + (asPalavras.PosicaoAtual + 1) + "/" + asPalavras.Tamanho;

            }

        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            asPalavras.AvancarPosicao();
            AtualizarTela();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            asPalavras.VoltarPosicao();
            AtualizarTela();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            asPalavras.PosicionarNoInicio();
            AtualizarTela();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            asPalavras.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFunc_FormClosing(object sender, FormClosingEventArgs e)
        {
            asPalavras.GravacaoEmDisco(dlgAbrir.FileName);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            asPalavras.SituacaoAtual = Situacao.inlcuindo;
            LimparTela();
            stlbMensagem.Text = "Digite a nova matricula";
            txtPalavra.Focus();


        }

        int ondeIncluir;
        private void txtMatricula_Leave(object sender, EventArgs e)
        {

            if (txtPalavra.Text == "")
                MessageBox.Show("Digite uma Palavra!!!!");
            else
            {
                var palavr = new PalavraDica(txtPalavra.Text, "");
                ondeIncluir = -1;

                if (asPalavras.SituacaoAtual == Situacao.inlcuindo)
                {
                    if (asPalavras.ExisteSequencial(palavr, ref ondeIncluir))
                    {

                        asPalavras.SituacaoAtual = Situacao.navegando;
                        AtualizarTela();
                    }
                    else
                    {
                        txtDica.Focus();
                        stlbMensagem.Text = "Preencha os demais campos";
                    }
                }

                if (asPalavras.SituacaoAtual == Situacao.procurando)
                {
                    int ondeEsta = -1;

                    if (asPalavras.ExisteSequencial(palavr, ref ondeEsta))
                    {
                        asPalavras.PosicaoAtual = ondeEsta;
                        MessageBox.Show("Esse já existe");
                        AtualizarTela();
                    }
                    else
                    {

                        MessageBox.Show("Matricula não encontrada");
                    }


                }

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (asPalavras.SituacaoAtual == Situacao.inlcuindo)
            {
                var novoFunc = new PalavraDica(txtPalavra.Text, txtDica.Text);
                asPalavras.Incluir(novoFunc, ondeIncluir);
                asPalavras.PosicaoAtual = ondeIncluir;
                AtualizarTela();
            }
            /*else
                if (asPalavras.SituacaoAtual == Situacao.editando)
            {

                var FuncAlterado = new PalavraDica(

            }*/
        }

        /* private void btnOrdenar_Click(object sender, EventArgs e)
         {
             asPalavras.Ordenar();
             asPalavras.PosicionarNoInicio();
             AtualizarTela();

         }*/

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("aaaaaaaaaaaaa", "AAA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                asPalavras.Excluir(asPalavras.PosicaoAtual);


                if (asPalavras.PosicaoAtual >= asPalavras.Tamanho)
                    asPalavras.PosicionarNoUltimo();

            }

            AtualizarTela();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            asPalavras.SituacaoAtual = Situacao.procurando;
            LimparTela();
            stlbMensagem.Text = "Digite a matricula q vc quer busca";
            txtPalavra.Focus();



        }

        private void tpLista_Enter(object sender, EventArgs e)
        {
            asPalavras.Listar(txtLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            asPalavras.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            asPalavras.SituacaoAtual = Situacao.editando;
            txtDica.Focus();
            stlbMensagem.Text = "Digite os novos valores e pressione [Salvar]";



        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            asPalavras.Listar(txtLista);
        }
    }

}