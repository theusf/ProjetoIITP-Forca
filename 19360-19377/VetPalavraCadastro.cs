using System;
using System.IO;
using System.Windows.Forms;



public enum Situacao
{ navegando,inlcuindo,editando,procurando,excluindo}
class VetCadastro
{
    PalavraDica[] dados = null; // dados é vetor com 10 posições
    int qtosDados;       // controla a quantidade de posições em uso
    int posicaoAtual;
    Situacao situacaoAtual;

    public PalavraDica this[int qualPos]
    {
        get
        {
            if (qualPos >= 0 && qualPos < qtosDados)
                return dados[qualPos];

            throw new Exception("Posicao invalida:" + qualPos);
        }

    }

    public VetCadastro(int tamanhoInicial)
    {
        dados = new PalavraDica[tamanhoInicial]; // dados é vetor com 10 posições
        qtosDados = 0;         // controla a quantidade de posições em uso
        posicaoAtual = -1;
        situacaoAtual = Situacao.navegando;
    }

    public int Tamanho
    {
        get => qtosDados;

    }
    public Situacao SituacaoAtual
    {
        get => situacaoAtual;
        set => situacaoAtual = value;
    }
    public int PosicaoAtual
    {
        get => posicaoAtual;
        set => posicaoAtual = value;
    }

    public void PosicionarNoUltimo()
    {

        posicaoAtual = qtosDados-1;

    }

    public void VoltarPosicao()
    {

        if (posicaoAtual > 1)
            posicaoAtual--;
        else
            PosicionarNoInicio();
    }
    public void AvancarPosicao()
    {

        if (posicaoAtual < qtosDados - 1)
            posicaoAtual++;
        else
            PosicionarNoInicio();
    }
    public void PosicionarNoInicio()
   {

        posicaoAtual = 0;
           
   }

    public bool EstaVazio()
    {
        if (qtosDados == -1)
            return true;
        else
            return false;
    }
  public void LerDados(string nomeArquivo)
  {
    var arquivo = new StreamReader(nomeArquivo);
    while (!arquivo.EndOfStream)
    {
      string linhaLida = arquivo.ReadLine();
      var novoFunc = new PalavraDica(linhaLida);
      IncluirAposFim(novoFunc);
    }
    arquivo.Close();
  }
  public void IncluirAposFim(PalavraDica novoValor)
  {
    if (qtosDados >= dados.Length)
      Expandir();

    dados[qtosDados] = novoValor;
    qtosDados++;
  }

    public void Incluir(PalavraDica novoValor, int posicaoDeInclusao)
    {
        if (qtosDados >= dados.Length)
            Expandir();

        for (int indice = qtosDados - 1; indice >= posicaoDeInclusao; indice--)
            dados[indice + 1] = dados[indice];

        dados[posicaoDeInclusao] = novoValor;
        qtosDados++;
    }

    void Expandir()
  {
    PalavraDica[] vetorMaior = new PalavraDica[dados.Length + 10];
    for (int indice = 0; indice < dados.Length; indice++)
      vetorMaior[indice] = dados[indice];
    dados = vetorMaior;
  }

  public void Excluir(int posicaoASerExcluida)
  {
    qtosDados--;
    for (int ind = posicaoASerExcluida; ind < qtosDados; ind++)
      dados[ind] = dados[ind + 1];
  }

  public bool ExisteSequencial(PalavraDica funcProc, ref int indice)
  {
    bool achouIgual = false;
    indice = 0; // para começar a percorrer o vetor dados
        while (!achouIgual && indice < qtosDados)
            if (dados[indice].PalavraUsada.Contains(funcProc.PalavraUsada))
        achouIgual = true;
      else
        indice++;

    return achouIgual;
  }


    public void Listar(TextBox lista)
    {
        lista.Clear();
        for (int indice = 0; indice < qtosDados; indice++)
            lista.AppendText($"[{indice,2}] - {dados[indice]}" + Environment.NewLine);
    }
    public void GravacaoEmDisco(string nomeArquivo)
  {
    var arqFuncionarios = new StreamWriter(nomeArquivo);
    for (int i = 0; i < qtosDados; i++)
        arqFuncionarios.WriteLine(dados[i].ParaArquivo());
    arqFuncionarios.Close();
  }

    /*public void Ordenar()
    {
        for (int lento = 0; lento < qtosDados; lento++)
            for (int rapido = lento + 1; rapido < qtosDados; rapido++)
                if (dados[rapido].Matricula < dados[lento].Matricula)
                {
                    PalavraDica aux = dados[rapido];
                    dados[rapido] = dados[lento];
                            dados[lento] = aux;
                }
    }

    
    public bool Existe(PalavraDica funcProc, ref int meio)
    {
        int inicio = 0;
        int fim = qtosDados - 1;
        bool achou = false;
        while (!achou && inicio <= fim)
        {

            meio = (inicio + fim ) / 2;
            if (dados[meio].Palavra == funcProc.Palavra)
                achou = true;
            else
            {
                if (funcProc.Matricula < dados[meio].Matricula)
                    fim = meio - 1;
                else
                    inicio = meio + 1;
            }

        }

        if (!achou)
            meio = inicio;

        return achou;
    }*/

}
