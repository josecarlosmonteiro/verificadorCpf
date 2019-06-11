using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validadorCpf
{
    class FormatNumber
    {
        //Método de formatação da string CPF de entrada
        public string formatar(string entrada)
        {
            entrada = entrada.Replace("-", "").Replace(".", ""); //remove pontos e vírgulas
            return entrada;
        }

        //Método para retornar uma array onde cada posição é um número do CPF indicado
        public List<int> breakString(string entrada)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < entrada.Length; i++)
            {
                //Pegar o caractere atual, converter em inteiro e adicionar à array
                lista.Add(int.Parse(entrada.Substring(i, 1)));
            }
            return lista;
        }
    }
}
