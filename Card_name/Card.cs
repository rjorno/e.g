using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_name
{
    enum E_Color { red, black };
    class Card : IComparable
    {
        private E_Color color;
        private int number;
        public Card(int number = 0, E_Color color = 0) { this.number = number; this.color = color; }
        public E_Color property_color
        {
            set { color = value; }
            get { return color; }
        }
        public int set_get_number
        {
            set
            {
                if (value >= 2 && value <= 14)
                    number = value;
            }
            get
            {
                return number;
            }
        }
        public string CardName
        {
            get
            {
                if (number >= 2 && number <= 10)
                    return number.ToString();
                switch (number)
                {
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    case 14:
                        return "Ace";
                    default:
                        return "not exists card";

                }
            }
        }
        public override string ToString()
        {
            return "Number card is:" + number + " Color card is:" + color;
        }

        public int CompareTo(object obj)
        {
            //Card f = obj as Card;
            return number.CompareTo(((Card)(obj)).number);
            // return number.CompareTo(f);
            //return color.CompareTo(f);
        }
    }
    class CardStock
    {
        public CardStock()
        {
            List<Card> lst = new List<Card>();
            for (int i = 2; i < 15; i++)
            {
                Card a = new Card(i, E_Color.red);
                lst.Add(a);
                Card b = new Card(i, E_Color.black);
                lst.Add(b);
            }
           

        }
        
}
}

