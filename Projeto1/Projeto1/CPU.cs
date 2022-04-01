using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class CPU : Hardware
    {
        private double Clock;
        private string Modelo;

        public CPU(int id, string descricao, double valor, string fabricante,
            double clock, string modelo) : base(id, descricao, valor, fabricante)
        {
            Clock = clock;
            Modelo = modelo;
        }

        public override string getDetalhesHardware()
        {
            return $"Detalhes do Hardware: Id: {getId()}, Descricao: {getDescricao()}, " +
                $"Valor: {getValor()}, Fabricante: {getFabricante()}, Clock: {Clock}, " +
                $"Modelo: {Modelo}";
        }
    }
}
