using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validadorCpf;

namespace validadorCpf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especifique um cpf (com ou sem caracteres especiais)
            string cpf = "111.998.184-40";

            //Instância do objeto guardando o cpf
            Validate teste = new Validate(cpf);

            //Instância de objeto para formatação da string
            FormatNumber number = new FormatNumber();

            Console.WriteLine("Entrada original: " + cpf);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            //formatar -> remove "." e "-" do CPF indicado
            //breakString -> recebe uma string e a "quebra" em uma array de inteiros
            //verification -> calcula o resultado com base numa array de inteiros
            teste.verification(number.breakString(number.formatar(cpf)));
        }
    }
}
