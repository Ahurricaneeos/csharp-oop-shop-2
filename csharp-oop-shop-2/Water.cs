using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Water : Product
    {
        private double liters;
        private int ph;
        private string spring;

        public Water(string name, string description, double price, int iva, double liters, int ph, string spring) : base(name, description, price, iva)
        {
            SetLiters(liters);
            this.ph = ph;
            this.spring = spring;
        }

        public double GetLiters() { return liters; }
        public int GetPh() { return ph; }
        public string GetSpring() { return spring; }

        public void SetLiters(double litri)
        {
            if (litri < 0)
            {
                this.liters = 0;
            }
            else if (liters > 1.5)
            {
                this.liters = 1.5;
            }
            else
            {
                this.liters = litri;
            }
        }
        public void SetPh(int ph)
        {
            if (ph < 0)
            {
                ph = 0;
            }
            else if (ph > 7)
            {
                ph = 7;
            }
            else
            {
                this.ph = ph;
            }
        }
        public void SetSpring(string spring)
        {
            this.spring = spring;
        }

        // Metodi
        public void drinkWater()
        {
            this.liters = this.liters - 0.3;
        }

        public void refillBottle(double instertedWater)
        {
            if (instertedWater < 0)
            {
                Console.WriteLine("Non c'è acqua");
            }
            else if (instertedWater > 0 && instertedWater <= 1.5 && this.liters + instertedWater < 1.5)
            {
                this.liters += instertedWater;
            }
            else
            {
                Console.WriteLine("C'è troppa acqua");
            }
        }
        public void emptyBottle()
        {
            this.liters = 0;
        }


        public override string GetProductString()
        {
            string rappStr = base.GetProductString();
            rappStr += "Litri: " + this.liters;
            rappStr += "Ph: " + this.ph;
            rappStr += "La sorgente è: " + this.spring;

            return rappStr;
        }
    }
}

