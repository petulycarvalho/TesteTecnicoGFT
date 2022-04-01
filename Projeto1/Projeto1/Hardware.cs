using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public abstract class Hardware
    {
        private int Id;
        private string Descricao;
        private double Valor;
        private string Fabricante;

        public Hardware(int id, string descricao, double valor, string fabricante)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Fabricante = fabricante;
        }

        public abstract string getDetalhesHardware();

        public int getId()
        {
            return Id;
        }

        public string getDescricao()
        {
            return Descricao;
        }

        public double getValor()
        {
            return Valor;
        }

        public string getFabricante()
        {
            return Fabricante;
        }
    }
}
