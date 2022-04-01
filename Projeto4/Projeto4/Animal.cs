using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    public abstract class Animal : AcoesAnimal
    {
        public ClasseAnimal classe { get; set; }

        public Alimentacao alimentacao { get; set; }

        public Habitat habitat { get; set; }

        public virtual void Locomover()
        {
            Console.WriteLine("Animal andando");
        }

        public virtual void Alimentar()
        {
            Console.WriteLine("Animal comendo");
        }

    }
}
