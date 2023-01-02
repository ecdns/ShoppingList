using System;

namespace shopping
{
    internal class Produit
    {
        private int id;
        private string name;
        private int price;

        public Produit(int id, string _name, int _price)
        {
            this.id = id;
            this.name = _name;
            this.price = _price;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string _name)
        {
            this.name = _name;
        }
        public int GetPrice()
        {
            return this.price;
        }
        public void SetPrice(int _price)
        {
            this.price = _price;
        }

        public string AfficherProduit()
        {
            return this.name + " à " + this.price + "€ l'unité";
        }
    }
}
