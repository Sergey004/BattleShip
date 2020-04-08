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
            TransportShip ship = new TransportShip();
            string res = ship.Move(3000);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
    public class BaseShip
    {
        public BaseShip()
        {
            //Console.WriteLine("Вызван конструктер родительского класса");
        }

        private int _counter;

        protected int _speed;

        public virtual string Move(int distance)
        {
            _counter++;
            string result = string.Format("Пройдено километров: {0}", distance);
            return result;
        }
    }

    public class AnotherBaseShip
    { 

    }
    public class TransportShip : BaseShip
    {
        public override string Move(int distance)
        {
            string result = base.Move(distance);
            result += string.Format("Транспортный корабаль преодалел километров: {0}", distance);
            return result;
        }
        public TransportShip()
        {
            //Console.WriteLine("Вызван коструктер дочернего класса");
        }

       public void Start()
       {

       }
     }
    
}
