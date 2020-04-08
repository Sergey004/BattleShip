using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatleShip
{
    class Program
    {

        static void Main(string[] args)
        {
            BaseShip ship = GetShip(ShipType.FightShip);
            string result = ship.Fight();
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static BaseShip GetShip(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.FightShip:
                    return new FightShip();
                case ShipType.TransportShip:
                    return new TransportShip();
                default:
                    throw new Exception("Неизвестный корабль");
            }
        }
    }
    public class BaseShip
    {
        private int _counter;

        protected int _speed;

        public virtual string Move(int distance)
        {
            _counter++;
            string result = string.Format("Пройдено километров: {0}", distance);
            return result;
        }
        public virtual string Fight()
        {
            return "Произошол бой";
        }
        public enum ShipType
        {
            TranspotrShip = 1,
            FightShip = 2,
        }
    }
    public class FightShip : BaseShip
    {
        public override string Move(int distance)
        {
            double time = (double)distance / 2000;
            return string.Format("Пройдено километров:{0} за время {1}", distance, time);
        }
        public override string Fight()
        {
            return "Противник уничтожен. ";
        }

        public override string ToString()
        {
            return "Боевой корабль";
        }
     }
    public class TransportShip : BaseShip
    {
        public override string Move(int distance)
        {
            double time = (double)distance / 2000;
            return string.Format("Пройдено километров:{0} за время {1}", distance, time);
        }
        public override string Fight()
        {
            return "Транспотрный корабль не может вступить в бой!";
        }

        public override string ToString()
        {
            return "Транспотрный корабль";
        }
    
    }

}
