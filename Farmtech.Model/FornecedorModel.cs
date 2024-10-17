using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public class FornecedorModel
    {
        public static string Criar(FornecedorEnt fornecedor, FornecedorEnderecoEnt endereco)
        {
            /*Validação de cpf
            if (fornecedor.Cnpj.Length > 11 || fornecedor.Cnpj.Length < 11)
            {
                return "CPF invalido, deve ter 11 caracteres, digite novamente";
            }
            else
            {
                try
                {
                    int[] digitosCnpj = new int[fornecedor.Cnpj.Length];
                    for (int i = 0; i < fornecedor.Cnpj.Length; i++)
                    {
                        digitosCnpj[i] = fornecedor.Cnpj[i] - '0'; // - '0' serve pra pegar o numero literal, sem ele o array recebe em asci                    
                    }
                    //Calculo de validação do cpf
                    // Do primeiro ao nono digito multiplica-se por 10 a 2, sendo o primeiro digito x 10 e o nono x 2
                    //Depois somamos todos os resultado, e dividimos por 11 guardamos o resultado e o resto
                    // Se o resto da divisão for menor que 2, então o primeiro digito apos o traço é igual a 0 (Zero).
                    // Se o resto da divisão for maior ou igual a 2, então o primeiro dígito verificador é igual a 11 menos o resto da divisão(11 - resto).
                    //USAREMOS ESSE PASSO PARA SABER SE O PRIMEIR DIGITO É VALIDO^
                    int[] passo1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] passo2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int soma = 0;
                    int soma2 = 0;

                    for (int i = 0; i < passo1.Length; i++)
                    {
                        soma = soma + (digitosCnpj[i] * passo1[i]);
                    }
                    int divisao = soma / 11;
                    int resto = soma % 11;
                    if (resto < 2 && digitosCpf[9] == 0)
                    {
                        //Segundo passo
                        int resto2;
                        for (int i = 0; i < passo2.Length; i++)
                        {
                            soma2 = soma2 + (digitosCpf[i] * passo2[i]);
                        }
                        resto2 = soma2 % 11;
                        if (resto2 < 2 && digitosCpf[10] == 0)
                        {
                            Console.WriteLine("CPF VALIDO");

                        }
                        else if (resto2 >= 2 && 11 - resto2 == digitosCpf[10])
                        {
                            Console.WriteLine("CPF VALIDO");
                        }
                        else
                        {   //Falha segundo digito
                            return "CPF invalido, tente novamente";
                        }

                    }
                    else if (resto >= 2 && 11 - resto == digitosCpf[9])
                    {
                        // Segundo passo
                        int resto2;
                        for (int i = 0; i < passo2.Length; i++)
                        {
                            soma2 = soma2 + (digitosCpf[i] * passo2[i]);
                        }
                        resto2 = soma2 % 11;
                        if (resto2 < 2 && digitosCpf[10] == 0)
                        {
                            Console.WriteLine("CPF VALIDO");

                        }
                        else if (resto2 >= 2 && 11 - resto2 == digitosCpf[10])
                        {
                            Console.WriteLine("CPF VALIDO");
                        }
                        else
                        {   //Falha segundo digito                            
                            return "CPF invalido, tente novamente";
                        }

                    }
                    else
                    { //Falha no primeiro digito
                        return "CPF invalido, tente novamente";

                    }
                    //Apos refazemos o calculo anterior com os 10 digitos, multipliclando de 11 a 2
                    //Somamos tudo e dividimos por 11 guardamos o resultado e o resto
                    //Se o resto da divisão for menor que 2, então o dígito é igual a 0 (Zero).
                    //Se o resto da divisão for maior ou igual a 2, então o dígito é igual a 11 menos o resto da divisão(11 - resto).
                    //11 - 6 = 5   logo 5 é o nosso segundo dígito verificador.
                    //Depois 
                }
                catch (Exception ex) { Console.WriteLine("Erro: " + ex.Message); }
                //Validação de cpf
            */
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            string res = fornecedorDAO.Criar(fornecedor, endereco);
            return res;

        }
     
        public string Excluir(String cnpj)
        {
            FornecedorDAO fornecedorDAO=new FornecedorDAO();
            string res = fornecedorDAO.Excluir(cnpj);
            return res;     
        }
        public FornecedorEnt BuscarFornecedor(String cnpj) { 
            FornecedorEnt fornecedorEnt = new FornecedorEnt();
            
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorEnt = fornecedorDAO.BuscarFornecedor(cnpj);
            return fornecedorEnt;
        }
        public List<FornecedorEnt> BuscarFornecedores()
        {
            List<FornecedorEnt> fornecedores = new List<FornecedorEnt>();
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedores = fornecedorDAO.BuscarFornecedores();
            return fornecedores;
        }
        public FornecedorEnderecoEnt BuscarEndereco(String cnpj)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            FornecedorEnderecoEnt enderecoEnt = new FornecedorEnderecoEnt();
            enderecoEnt = fornecedorDAO.BuscarEndereco(cnpj);
            return enderecoEnt;
        }
        public string Atualizar(FornecedorEnt fornecedorEnt, FornecedorEnderecoEnt enderecoEnt)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            String res = fornecedorDAO.Atualizar(fornecedorEnt, enderecoEnt);
            return res; 
        }
    }
}
