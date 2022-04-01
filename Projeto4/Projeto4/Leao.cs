using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    public class Leao : Animal
    {
        public Leao()
        {
            classe = ClasseAnimal.Mamifero;
            alimentacao = Alimentacao.Carnivoro;
            habitat = Habitat.Terrestre;
        }

        public override void Locomover()
        {
            Console.WriteLine("Andar");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentar com Carne");
        }
    }
}
