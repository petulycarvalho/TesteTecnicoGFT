using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    public class Lagarto : Animal
    {
        public Lagarto()
        {
            classe = ClasseAnimal.Reptil;
            alimentacao = Alimentacao.Onivoro;
            habitat = Habitat.MultiHabitat;
        }

        public override void Locomover()
        {
            Console.WriteLine("Andar ou Nadar");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentar com mix de Carne e Vegetais");
        }
    }
}
