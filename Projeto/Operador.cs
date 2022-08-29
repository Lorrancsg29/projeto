using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    [System.Serializable]
    class Operador : Usuario, IUsuario
    {
        public int matricula;
        public string nome;

        public Operador( int login, int senha, int matricula, string nome)
        {
            this.login = login;
            this.senha = senha;
            this.matricula = matricula;
            this.nome = nome;
        }

        public void Exibir()
        {
            Console.WriteLine("Bem vindo "+nome);
            Console.WriteLine("Login: "+login);
            Console.WriteLine("Senha:"+senha);
            Console.WriteLine("Matricula: "+matricula);
        }
    }
}
