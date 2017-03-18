using DesignPatterns.Behavioral.Observer.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class CopyProcessor
    {
        public IList<ICopyCursorObserver> _observerList;

        public CopyProcessor()
        {
            _observerList = new List<ICopyCursorObserver>();
        }

        public void Attach(ICopyCursorObserver observer)
        {
            _observerList.Add(observer);
        }

        public void Detach(ICopyCursorObserver observer)
        {
            _observerList.Remove(observer);
        }

        public void ProcessCopy(string directoryPath)
        {
            //Find files

            for(var counter =1; counter <= 100; counter++)
            {
                //Copy file
                NotifyScreen(counter);
            }
        }

        private void NotifyScreen(int percentage)
        {
            foreach(var observer in _observerList)
            {
                observer.UpdatePercentageCursor(percentage);
            }
        }
    }
}
