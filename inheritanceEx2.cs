using System;

namespace innterEx2
{
    interface ICarnivore
    {
        bool IsHungry { get; }
        Animal Hunt();
        void Eat(Animal victim);
    }

    public abstract class Animal
    {
        public abstract void Sleep();
    }
    public class Antelope : Animal
    {
        public override void  Sleep() { }
    }

    public class Lion : Animal,ICarnivore
    {
        public Lion()
        {
            hungry = true;
        }

        private bool hungry;
        public bool IsHungry
        {
            get
            {
                return hungry;
            }
        }

        public Animal Hunt()
        {
            return new Antelope();
        }

        public void Eat(Animal prey)
        {
            Console.WriteLine("Lion is no longer hungry");
        }
         
        public override void Sleep()
        {

        }
        
        public void JoinPride()
        {

        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion aLion = new Lion();
            Antelope a = new Antelope();

            if (aLion.IsHungry)
            {
                Animal victim = aLion.Hunt();
                if (victim != null)
                {
                    aLion.Eat(victim);
                }
            }

            aLion.JoinPride();
            aLion.Sleep();
            Console.ReadKey();
        }
    }
}
