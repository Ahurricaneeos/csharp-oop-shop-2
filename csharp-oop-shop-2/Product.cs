﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_oop_shop_2
{
    public class Product
    {
        // Attributes
        private int code;
        private string name;
        private string descripion;
        private double price;
        private int iva;

        // Costructor
        public Product(string name, string description, double price, int iva)
        {
            int codice = new Random().Next(0, 99999999);
            this.code = codice;
            this.name = name;
            this.descripion = description;
            this.price = price;
            this.iva = iva;
        }
        // Getters
        public int GetCodice() { return code; }
        public string GetNome() { return name; }
        public string GetDescrizione() { return descripion; }
        public double GetPrezzo() { return price; }
        public int GetIva() { return iva; }

        // Setters

        public void SetNome(string name) { this.name = name; }
        public void SetIva(int iva) { this.iva = iva; }
        public void SetDescrizione(string description) { this.descripion = description; }
        public void SetPrezzo(double price) { this.price = price; }

        // Methods
        private string PricePlusIva()
        {
            double ivaOnPrice = price + (price * iva / 100);
            string Iva = ivaOnPrice.ToString();
            return Iva;
        }

        public string GetProductString()
        {
            string rapprStr = "Codice prodotto: " + this.code + "\n";
            rapprStr += "Nome: " + this.name + "\n";
            rapprStr += "Descrizione: " + this.descripion + " ";
            rapprStr += "Prezzo: " + this.PricePlusIva() + "\n";
            return rapprStr;
        }
    }
}