using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmtech.Entidades
{
    public class ClientEnt
    {
        private string cpf;
        private string nome;
        private string telefone;
        private string email;
        private DateTime dataNasc;
        private char genero;        
        
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public char Genero { get => genero; set => genero = value; }
    }
    
 }
