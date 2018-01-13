using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS.Model
{
    public class SoldApple: IApple, IHistory
    {
        private double _price;
        public string Kind { get; set; }
        public AppleColor Color { get; set; }

        public double Price
        {
            get { return _price; }
            set
            {
                //if(!_price.Equals(0)) SaveHistory();
                _price = value;
            }
        }

        public void SaveHistory()
        {
            Console.WriteLine($"Save SoldApple History. New Price: {Price}");
        }
    }
}
