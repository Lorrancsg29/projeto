using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Veiculos
    {
        public string placa;
        public string marca;
        public string modelo;
        public int ano;
        public int valorHora;
        public string combustivel;
        public int limitePortaMala;
        public string categoria;

        public Veiculos(string placa, string marca, string modelo, int ano, int valorHora, string combustivel, int limitePortaMala, string categoria)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.valorHora = valorHora;
            this.combustivel = combustivel;
            this.limitePortaMala = limitePortaMala;
            this.categoria = categoria;
        }
        
    }   
        
       


}
