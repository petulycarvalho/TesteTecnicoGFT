using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    public class Papagaio : Animal
    {
        public Papagaio()
        {
            classe = ClasseAnimal.Ave;
            alimentacao = Alimentacao.Herbivoro;
            habitat = Habitat.MultiHabitat;
        }

        public override void Locomover()
        {
            Console.WriteLine("Voar");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentar com Vegetais");
        }
    }
}
