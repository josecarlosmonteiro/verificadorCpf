using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validadorCpf
{
    class Validate
    {
        string cpf;
        
        public Validate(string cpf)
        {
            this.cpf = cpf;
        }

        //Se o resto de um dos cálculos for 10, recebe 0, pois é seu módulo
        public int rest(int x)
        {
            if (x == 10)
            {
                return 0;
            }
            else
            {
                return x;
            }
        }

        public void verification(List<int> numero)
        {
            //Dígitos verificadores para comparação no teste final
            int digito1 = numero[9];
            int digito2 = numero[10];
            Console.WriteLine("DV: -" + digito1 + digito2);

            //Soma dos múltiplos dos 9 primeiros dígitos
            int soma = 0;
            int mult = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += numero[i] * mult;
                mult--;
            }
            //O primeiro dígito é dado pela diferença de 11 e o resto da soma dividida por 11
            int result1 = 11 - (soma % 11);
            //Caso o dígito seja 10, recebe zero como seu módulo
            result1 = this.rest(result1);

            //Reset da soma e alteração do parâmetro de multiplicação dos dígitos
            soma = 0;
            mult = 11;

            //Nova soma das multiplicações
            for (int i = 0; i < 9; i++)
            {
                soma += numero[i] * mult;
                mult--;
            }

            //Incremento do dígito encontrado na primeira operação
            soma += 2 * result1;
            int result2 = 11 - (soma % 11);

            //Teste do segundo dígito verificador
            result2 = this.rest(result2);

            Console.WriteLine("Verificaçã concluída!");

            //Caso os dígitos encontrados nas operações sejam iguais aos informados na entrada
            if (result1 == digito1 && result2 == digito2)
            {
                this.veredito(true);
            }
            else
            { 
                this.veredito(false);
            }
        }

        //Mensagem final na tela
        public void veredito(bool resp)
        {
            if (resp)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CPF aceito!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CPF rejeitado!");
            }
            Console.ResetColor();
        }
    }
}
