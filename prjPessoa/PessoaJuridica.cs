using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPessoa
{
    class PessoaJuridica:Pessoa
    {
            public string CNPJ {get; set;}
            public PessoaJuridica(string Nome, string Endereço,
                string CNPJ)
                :base(Nome, Endereço)
            {
                       this.CNPJ = CNPJ;
        }
        public override bool validar()
        {
            char[] digitos = CNPJ.ToString().ToCharArray();
            int peso = 5, soma = 0;
            int div1 = 0, div2 = 0, resto = 0;

            for (int i = 0; i < 12; i++)
            {
                if (peso < 2) peso = 9;
                soma += peso * Convert.ToInt16(
                digitos[i].ToString());
                peso--;
            }
            resto = soma % 11;
            if (resto < 2) div1 = 0; else div1 = 11 - resto;

            if (div1 != Convert.ToInt16(
    digitos[12].ToString())) return false;
            soma = 0; peso = 6;
            for (int i = 0; i < 13; i++)
            {
                if (peso < 2) peso = 9;
                soma += peso * Convert.ToInt16(
                digitos[i].ToString());
                peso--;
            }
            resto = soma % 11;
            if (resto < 2) div2 = 0; else div2 = 11 - resto;

            if (div2 != Convert.ToInt16(
                digitos[13].ToString())) return false;
            return true;
        }
    }
}
      


