using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DI
{
    public class ClassB:IclassInterface
    {
        IclassInterface classinstance;
        
        public ClassB(IclassInterface classinstance)
        {
            this.classinstance = classinstance;
        }

        public void funcA()
        {
            this.classinstance.funcA();
        }
        public void funcB()
        {
            this.classinstance.funcA();
        }
    }
}
