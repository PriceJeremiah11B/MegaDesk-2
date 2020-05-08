using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Jason_Chantry
{
    class DeskQuote
    {
        public string customer { get; set; }
        public List<Desk> desks
        {
            get; private set;
        }
        public DeskQuote()
        {
            desks = new List<Desk>();
        }
        public float total
        {
            get
            {
                float total = (float)0.0;
                foreach (var desk in desks)
                {
                    total += desk.price;
                }
                return total;
            }
        }
        public void addDesk(Desk desk)
        {
            this.desks.Add(desk);
        }
        public void removeDesk(int index)
        {
            this.desks.RemoveAt(index);
        }
        public void removeDesk(Desk desk)
        {
            this.desks.Remove(desk);
        }
    }
}
