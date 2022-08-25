using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi
{
    abstract public class Animal:IDisposable
    {
        TimeSpan age ;
        string kind=string.Empty;

        public int satiety = 100;
        public int thirst = 100;

        void move()
        {

        }
        void sleep()
        { 
        
        }
        bool tame()
        {
            if(this is Pet)return false;
            else return true;
        }

        public void Increment_satiety()
        {
            if(satiety>0)satiety--;
        }
        public void Increment_thirst()
        {
            if(thirst>0)thirst--;
        }
        public string? Death()
        {
            return null;
        }

        public void Dispose()
        {
           
        }

        ~Animal()
        {

        }
    }

    public interface Ipet
    {
        public void feed();
        public void play();
        public void drink();
        public string make_a_noise();
       

    }

   abstract public class Pet : Animal, Ipet
    {
        public string Nickname=string.Empty;
        public int courage = 100;
       

        public void drink()
        {
            if(thirst<100)thirst++;
        }

        public void feed()
        {
            if(satiety<100)satiety++;           
        }

        public void Increment_courage()
        {
            if(courage>0)courage--;
        }
        public void play()
        {
           if(courage<100) courage++;
        }
       
        public string make_a_noise()
        {
            return "Я абстрактная сущьность. прими таблетки и вызови санитаров";
        }

        

       public Pet(string Nickname) => this.Nickname = Nickname;

    }

    public class Cat : Pet
    {
        public Cat(string Nickname) : base(Nickname)
        {
        }

        string make_a_noise()
        {
            return "MEW";
        }
           
    }
    class Dog : Pet
    {
        public Dog(string Nickname) : base(Nickname)
        {
        }

        string make_a_noise()
        {
            return "ГАВ-ГАВ";
        }
    }
    class Fish : Pet
    {
        public Fish(string Nickname) : base(Nickname)
        {
        }

        string make_a_noise()
        {
         return string.Empty;
        }

        }
    class mutant: Pet
    {
        public void play()
        {
            courage++;
        }
        public void drink()
        {
           thirst++;
        }

        public void feed()
        {
            satiety++;
        }
        public mutant(string Nickname) : base(Nickname)
        {
        }

        string make_a_noise()
        {
            return "fggsdfsdfhhsa";
        }

    }
}


