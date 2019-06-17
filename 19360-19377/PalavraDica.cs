using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class PalavraDica
    {
        private string palavraUsada;
        private string dicaUsada;


        const int tamanhoPalavra = 15;
        const int tamanhoDica = 100;

        const int inicioPalavra = 0;
        const int inicioDica = inicioPalavra + tamanhoPalavra;

        public PalavraDica(string linha) // são lidos e divididos em strings a palavra e sua respectiva dica
        {
            palavraUsada = linha.Substring(inicioPalavra, tamanhoPalavra);
            
            dicaUsada = linha.Substring(inicioDica);
        }

        public PalavraDica(string pala, string dic)
        {
        palavraUsada = pala;
        dicaUsada = dic;

        }

    public string PalavraUsada { get => palavraUsada; set => palavraUsada = value; } // acessam as palavras utilizadas
     public string DicaUsada { get => dicaUsada; set => dicaUsada = value; }  //sem os gets e os sets, as strings
                                                                                 //poderiam ser modificadas fora da classe

    public override String ToString()
    {
        return palavraUsada.ToString().PadLeft(tamanhoPalavra, ' ') + "  " +
                dicaUsada.ToString().PadLeft(tamanhoDica, ' ');

    }

    public String ParaArquivo()
    {
        return $"{palavraUsada.PadRight(15,' ')}{dicaUsada.PadRight(100,' ')}" ;
    }



}


