using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKWorkSale.Utiliteses
{
    internal class Position
    {
        private string Article;
        public string Manufactured;
        public double price;
        public int quantity;
        public string Kod;
        public Position(string Article, string Manufactured, double price, int quantity) {
            this.Article = Article;
            this.Manufactured = Manufactured;
            this.price = price;
            this.quantity = quantity;
            this.Kod = this.Article + this.Manufactured;
        }   
    }
}
