using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projeto
{
    enum Menu { Login = 1, NovoUsuario, NovoVeiculo, sair }
    class Program
    {
        static List<IUsuario> usuarios = new List<IUsuario>();
        static List<Veiculos> veiculo = new List<Veiculos>();
        static void Main(string[] args)
        {
            CarregarUsuarios();
            CarregarVeiculo();

            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Bem Vindos, selecione a opção desejada");
                Console.WriteLine("1-Login\n2-Novo Usuário\n3-Cadastrar novo Veiculo\n4-Sair"); //finalizar o menu
                int opcao = int.Parse(Console.ReadLine());
                Menu OpMenu = (Menu)opcao;


                switch (OpMenu)
                {
                    case Menu.Login:

                        Console.WriteLine("Informe o login:");
                        int loginAcesso = int.Parse(Console.ReadLine());

                        if (loginAcesso > 11) // Corrigir forma de acesso
                        {
                            foreach (IUsuario cliente in usuarios)
                            {
                                cliente.Exibir();
                            }
                        }
                        else
                        {
                            foreach (IUsuario operador in usuarios)
                            {
                                operador.Exibir();//quero que apareça só o do operador
                            }
                        }

                        break;

                    case Menu.NovoUsuario:
                        Console.WriteLine("Selecione a opção desejada:");
                        Console.WriteLine("1-Cadastro de cliente\n2-Cadastro de Operador");
                        int opcaoOp = int.Parse(Console.ReadLine());

                        if (opcaoOp == 1)
                        {
                            Console.WriteLine("Cadastrando de clientes");
                            Console.WriteLine("login: ");
                            int login = int.Parse(Console.ReadLine());
                            Console.WriteLine("senha: ");
                            int senha = int.Parse(Console.ReadLine());
                            Console.WriteLine("ID:");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nome: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("CPF:");
                            int cpf = int.Parse(Console.ReadLine());
                            Console.WriteLine("Aniversario:");
                            int aniversario = int.Parse(Console.ReadLine());
                            Console.WriteLine("CEP: ");
                            int cep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Logradouro:");
                            string logradouro = Console.ReadLine();
                            Console.WriteLine("Numero:");
                            int numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Complemento:");
                            int complemento = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cidade:");
                            string cidade = Console.ReadLine();
                            Console.WriteLine("Estado:");
                            string estado = Console.ReadLine();

                            Cliente cl = new Cliente(login, senha, id, nome, cpf, aniversario, cep, logradouro, numero, complemento, cidade, estado);
                            usuarios.Add(cl);
                            SalvarUsuarios();

                        }
                        else
                        {
                            Console.WriteLine("Informe o login:");
                            int loginOp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe a senha:");
                            int senhaOp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informa a matricula ");
                            int matriculaOp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o nome:");
                            string nomeOp = Console.ReadLine();

                            Operador op = new Operador(loginOp, senhaOp, matriculaOp, nomeOp);
                            usuarios.Add(op);
                            SalvarUsuarios();

                        }

                        break;

                    case Menu.NovoVeiculo:
                        Console.WriteLine("Cadastro de novo veiculo:");
                        Console.WriteLine("Informe a placa:");
                        string placa = Console.ReadLine();
                        Console.WriteLine("Informe a Marca:");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Informe o modelo:");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Informe o ano:");
                        int ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor por hora:");
                        int ValorHora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tipo de combustivel:");
                        string combustivel = Console.ReadLine();
                        Console.WriteLine("Informe o limite do porta malas:");
                        int limitePortaMala = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a categoria:");
                        string categoria = Console.ReadLine();

                        Veiculos ve = new Veiculos(placa, marca, modelo, ano, ValorHora, combustivel, limitePortaMala, categoria);
                        veiculo.Add(ve);
                        SalvarVeiculos();

                        break;

                    case Menu.sair:
                        escolheuSair = true;
                        break;
                    default:
                        break;
                }



            }
        }

        static void SalvarUsuarios()
        {
            FileStream stream = new FileStream("usuarios.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, usuarios);

            stream.Close();

        }

        static void CarregarUsuarios()
        {
            FileStream stream = new FileStream("usuarios.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();


            try
            {
                usuarios = (List<IUsuario>)encoder.Deserialize(stream);

                if (usuarios == null)
                {
                    usuarios = new List<IUsuario>();
                }
            }
            catch (Exception)
            {
                usuarios = new List<IUsuario>();

            }

            stream.Close();
        }
        static void SalvarVeiculos()
        {
            FileStream stream = new FileStream("veiculos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, usuarios);

            stream.Close();

        }
        static void CarregarVeiculo()
        {
            FileStream stream = new FileStream("veiculos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();


            try
            {
                usuarios = (List<IUsuario>)encoder.Deserialize(stream);

                if (usuarios == null)
                {
                    usuarios = new List<IUsuario>();
                }
            }
            catch (Exception)
            {
                usuarios = new List<IUsuario>();

            }

            stream.Close();
        }
    }
}
