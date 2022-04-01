using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Memoria : Hardware
    {
        private int Frequencia;
        private int Capacidade;
        private string Tipo;

        public Memoria(int id, string descricao, double valor, string fabricante,
            int frequencia, int capacidade, string tipo) : base(id, descricao, valor, fabricante)
        {
            Frequencia = frequencia;
            Capacidade = capacidade;
            Tipo = tipo;
        }

        public override string getDetalhesHardware()
        {
            return $"Detalhes do Hardware: Id: {getId()}, Descricao: {getDescricao()}, " +
                $"Valor: {getValor()}, Fabricante: {getFabricante()}, Frequencia: {Frequencia}, " +
                $"Capacidade: {Capacidade}, Tipo: {Tipo}";
        }
    }
}
