using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Pessoa
    {
            public string Nome { get; set; }

            public string Sexo { get; set; }

            public DateTime DataNascimento { get; set; }

            public Pessoa(string nome, string sexo, DateTime dataNascimento)
            {
                Nome = nome;
                Sexo = sexo;
                DataNascimento = dataNascimento;
            }

        public string imprimeTempoVidaRestante()
            {
                DateTime hoje = DateTime.Now;
                double tempoRestante = 0;
                int idadeAtual = hoje.Year - DataNascimento.Year;

                if (Sexo == "Masculino")
                    tempoRestante = 73 - idadeAtual;
                else
                    tempoRestante = 80 - idadeAtual;

                return $"Sua vida restante e de {tempoRestante} anos";
            }
        }
    }
