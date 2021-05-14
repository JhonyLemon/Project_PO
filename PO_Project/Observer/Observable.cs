using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    public class Observable : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in observers)
            {
                if (observer is MainForm)
                {
                    (observer as MainForm).Update();
                }
                else if(observer is AddElementForm)
                {
                    (observer as AddElementForm).Update();
                }
                else if (observer is EditElementForm)
                {
                    (observer as EditElementForm).Update();
                }
            }
        }
    }
}
