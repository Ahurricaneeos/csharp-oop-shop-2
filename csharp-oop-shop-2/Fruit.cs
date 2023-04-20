using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Fruit : Product
    {
        protected string fruitType;
        protected int fruitPieces;

        public Fruit(string name, string description, double price, int iva, string fruitType, int fruitPieces) : base(name, description, price, iva)
        {
            this.fruitType = fruitType;
            this.fruitPieces = fruitPieces;
        }

        public string GetFruitType() { return this.fruitType; }
        public int GetFruitPieces() {  return this.fruitPieces; }

        public void AddFruit()
        {
            if (fruitPieces >= 5)
            {
                Console.WriteLine("Il sacchetto è pieno");
            }
            else
            {
                fruitPieces++;
                Console.WriteLine("Il frutto è stato aggiunto");
            }
        }

        public void EatFruit()
        {
            if (fruitPieces <= 0)
            {
                Console.WriteLine("Non ci sono più frutti");
            }
            else 
            { 
                fruitPieces--;
                Console.WriteLine("Hai mangiato un frutto");
            }
        }

        public override string GetProductString()
        {
          string rappStr = base.GetProductString();
          rappStr += "Tipo di frutto: " + this.fruitType;
          rappStr += "Quantità: " + this.fruitPieces;

          return rappStr;
        }
    }
}
