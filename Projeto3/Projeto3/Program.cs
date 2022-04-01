using System;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Petuly", "Feminino", new DateTime(1996, 9, 26));

            Console.WriteLine(pessoa.imprimeTempoVidaRestante());
            
        }
    }
}
