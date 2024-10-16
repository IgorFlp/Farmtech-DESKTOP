using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public class ClienteModel
    {
        public static string Criar(ClienteEnt cliente, ClienteEnderecoEnt endereco)
        {
            //Validação de cpf
            if (cliente.Cpf.Length > 11 || cliente.Cpf.Length < 11)
            {
                return "CPF invalido, deve ter 11 caracteres, digite novamente";
            }
            else
            {
                try
                {
                    int[] digitosCpf = new int[cliente.Cpf.Length];
                    for (int i = 0; i < cliente.Cpf.Length; i++)
                    {
                        digitosCpf[i] = cliente.Cpf[i] - '0'; // - '0' serve pra pegar o numero literal, sem ele o array recebe em asci                    
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
                        soma = soma + (digitosCpf[i] * passo1[i]);
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
                ClienteDAO clienteDAO = new ClienteDAO();
                string res = clienteDAO.Criar(cliente, endereco);
                return res;
            }
        }
        public string Excluir(String cpf)
        {
            ClienteDAO clienteDAO=new ClienteDAO();
            string res = clienteDAO.Excluir(cpf);
            return res;        
            
        }
        public ClienteEnt BuscarCliente(String cpf) { 
            ClienteEnt clienteEnt = new ClienteEnt();
            

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteEnt = clienteDAO.BuscarCliente(cpf);
            return clienteEnt;
        }
        public ClienteEnderecoEnt BuscarEndereco(String cpf)
        {
            ClienteDAO  clienteDAO = new ClienteDAO();
            ClienteEnderecoEnt enderecoEnt = new ClienteEnderecoEnt();
            enderecoEnt = clienteDAO.BuscarEndereco(cpf);
            return enderecoEnt; 
        }
        public string Atualizar(ClienteEnt clienteEnt, ClienteEnderecoEnt enderecoEnt)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            String res = clienteDAO.Atualizar(clienteEnt, enderecoEnt);
            return res; 
        }
    }
}
