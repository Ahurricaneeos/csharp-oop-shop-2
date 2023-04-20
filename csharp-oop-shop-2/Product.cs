using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_oop_shop_composizione
{
    public class Product
    {
        // Attributes
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;

        // Costructor
        public Product(string nome, string descrizione, double prezzo, int iva)
        {
            int codice = new Random().Next(0, 99999999);
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        // Getters
        public int GetCodice() { return codice; }
        public string GetNome() { return nome; }
        public string GetDescrizione() { return descrizione; }
        public double GetPrezzo() { return prezzo; }
        public int GetIva() { return iva; }

        // Setters

        public void SetNome(string nome) { this.nome = nome; }
        public void SetIva(int iva) { this.iva = iva; }
        public void SetDescrizione(string descrizione) { this.descrizione = descrizione; }
        public void SetPrezzo(double prezzo) { this.prezzo = prezzo; }

        // Methods
        private string PrezzoPlusIva()
        {
            double ivaSulPrezzo = prezzo + (prezzo * iva / 100);
            string Iva = ivaSulPrezzo.ToString();
            return Iva;
        }

        public string GetProductString()
        {
            string rapprStr = "Codice prodotto: " + this.codice + "\n";
            rapprStr += "Nome: " + this.nome + "\n";
            rapprStr += "Descrizione: " + this.descrizione + " ";
            rapprStr += "Prezzo: " + this.PrezzoPlusIva() + "\n";
            return rapprStr;
        }
    }
}