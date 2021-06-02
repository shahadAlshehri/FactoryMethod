using System;
using System.Runtime.Serialization;

namespace factoryD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IAvocadoSupply product;
            product = c.FactoryMethod(5);
            Console.WriteLine(product.getAvocado());
            product = c.FactoryMethod(1);
            Console.WriteLine(product.getAvocado());
            product = c.FactoryMethod(12);
            Console.WriteLine(product.getAvocado());


        }
    }
    public interface IAvocadoSupply 
    {
        string getAvocado();
    }

    public class SpainProduction : IAvocadoSupply
    {
        public string  getAvocado()
        {
            return "Avocado from Spain";
        }


    } //1-4 spain 5-11 s.a 
    public class SouthAfricaProduction : IAvocadoSupply
    {
        public string getAvocado()
        {
            return "Avocado from South Africa";
        }


    }
    public class nullProduct :IAvocadoSupply
    {           
            public string getAvocado()
                {
                     return "No production this month ";
                 }


    }

    public class Creator
    {
        public IAvocadoSupply FactoryMethod(int month)
        {
         
                if (month <= 4 && month>=1)
                {
                    return new SpainProduction();
                } else if (month >= 5 && month <= 11)
                {
                    return new SouthAfricaProduction();
                }
                     return  new nullProduct();
            }
          
    }
    }

    
      
