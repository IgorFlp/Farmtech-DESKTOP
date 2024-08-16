using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmtech.Entidades
{
    public class UsuarioEnt
    {
        private int id;
        private string nome;
        private string login;
        private string senha;
        private string cargo;
        
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
    
 }
