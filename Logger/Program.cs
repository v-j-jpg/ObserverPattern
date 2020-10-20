using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        static Random ran = new Random();

        public static  void InfoSystem(Poruka p)
        {
            p.Naziv = $"SYSTEM #{ran.Next(20)}";
            p.Text = DateTime.Now.ToString(); 
            p.vrstaP = (VrstePoruka)ran.Next(2);
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Unesite poruku: \n");
                 string poruka= Console.ReadLine();

                Poruka por = new Poruka(poruka,VrstePoruka.INFO);

                por.Register(new SMSObserver());
                por.Register(new WCFObserver());
                por.Register(new EmailObserver());

                Poruka sistem = new Poruka();
                sistem.Register(new SMSObserver());
                sistem.Register(new WCFObserver());
                sistem.Register(new EmailObserver());

                for (int i = 0; i < 10; i++)
                {
                    
                    InfoSystem(sistem);

                    sistem.NotifyObservers();
                    
                    Thread.Sleep(800);
                }
                por.NotifyObservers();



            }
        }
    }
}
