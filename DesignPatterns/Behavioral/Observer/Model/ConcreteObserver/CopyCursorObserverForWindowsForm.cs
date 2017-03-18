using DesignPatterns.Behavioral.Observer.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Model.ConcreteObserver
{
    public class CopyCursorObserverForWindowsForm : ICopyCursorObserver
    {
        public void UpdatePercentageCursor(int percentage)
        {
            throw new NotImplementedException();
        }
    }
}
