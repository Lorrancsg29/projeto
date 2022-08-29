using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    [System.Serializable]
    class Cliente : Usuario, IUsuario
    {
        public int id;
        public string nome;
        public int cpf;
        public int aniversario;
        public int cep;
        public string logradouro;
        public int numeroCasa;
        public int complemento;
        public string cidade;
        public string estado;

        public Cliente(int login, int senha, int id, string nome, int cpf, int aniversario, int cep, string logradouro, int numeroCasa, int complemento, string cidade, string estado)
        {
            this.login = login;
            this.senha = senha;
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.aniversario = aniversario;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numeroCasa = numeroCasa;
            this.complemento = complemento;
            this.cidade = cidade;
            this.estado = estado;
        }

        public void Exibir()
        {
            Console.WriteLine("Bem vindo "+ nome);
            Console.WriteLine("Login: "+ login);
            Console.WriteLine("Senha: "+senha);
            Console.WriteLine("ID: "+senha);
            Console.WriteLine("CPF: "+cpf);
            Console.WriteLine("Aniversario: "+aniversario);
            Console.WriteLine("CEP: "+cep);
            Console.WriteLine("Endereço:");
            Console.WriteLine("Rua: "+logradouro);
            Console.WriteLine("Numero:"+numeroCasa);
            Console.WriteLine("Complemento:"+complemento);
            Console.WriteLine("Cidade:"+cidade);
            Console.WriteLine("Estado:"+ estado);
            Console.WriteLine("========================================");
        }
    }
}
