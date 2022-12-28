using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del tamagotchi
            Tamagotchi tama = new Tamagotchi("Pepito");

            // Mostrar la felicidad inicial del tamagotchi
            Console.WriteLine(tama.Happiness);  // 100

            // Hacer que pase el tiempo y ver cómo cambian los valores
            tama.TimePasses();
            Console.WriteLine(tama.Hunger);  // 10
            Console.WriteLine(tama.Happiness);  // 95
            Console.WriteLine(tama.Sickness);  // 5

            // Darle de comer al tamagotchi y ver cómo cambia su hambre
            tama.Feed();
            Console.WriteLine(tama.Hunger);  // 0
        }
    }

    class Tamagotchi
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Sickness { get; set; }

        public Tamagotchi(string name)
        {
            this.Name = name;
            this.Hunger = 0;
            this.Happiness = 100;
            this.Sickness = 0;
        }

        public void Feed()
        {
            if (this.Hunger > 0)
            {
                this.Hunger -= 10;
            }
        }

        public void Play()
        {
            if (this.Happiness < 100)
            {
                this.Happiness += 10;
            }
        }

        public void GiveMedicine()
        {
            if (this.Sickness > 0)
            {
                this.Sickness -= 10;
            }
        }

        public void TimePasses()
        {
            this.Hunger += 10;
            this.Happiness -= 5;
            this.Sickness += 5;
        }
    }

    

}
