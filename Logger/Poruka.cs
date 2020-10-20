using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
  public  class Poruka
    {

       public List<WritterOb> observers = new List<WritterOb>();

        int brojac = 0;
        public string Naziv { get; set; }
        public string Text { get; set; }

        public  VrstePoruka vrstaP { get; set; }
        public Poruka(string text,VrstePoruka vrste)
        {
            Naziv = $"Poruka #{brojac++}";
            Text = text;
            vrstaP = vrste;
        }

        public Poruka()
        {
          
        }

        public void Register(WritterOb observer)
        {
            observers.Add(observer);
        }

        /// 
        /// <param name="observer"></param>
        public void Unregister(WritterOb observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (WritterOb o in observers)
            {
                o.Notify(this);
            }
        }

        public override string ToString()
        {
            return vrstaP+":"+Naziv+":"+Text;
        }
    }
}
