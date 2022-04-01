using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class DiscoRigido : Hardware
    {
        private int Capacidade;
        private int Velocidade;
        private string Tipo;

        public DiscoRigido(int id, string descricao, double valor, string fabricante,
            int capacidade, int velocidade, string tipo) : base(id, descricao, valor, fabricante)
        {
            Capacidade = capacidade;
            Velocidade = velocidade;
            Tipo = tipo;
        }

        public override string getDetalhesHardware()
        {
            return $"Detalhes do Hardware: Id: {getId()}, Descricao: {getDescricao()}, " +
                $"Valor: {getValor()}, Fabricante: {getFabricante()}, Capacidade: {Capacidade}, " +
                $"Velocidade: {Velocidade}, Tipo: {Tipo}";
        }
    }
}
