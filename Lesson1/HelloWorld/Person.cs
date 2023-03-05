using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // internal - виден внутри сборки
    internal class Person
    {
        // Внутри класса 
        private string _name;

        // свойства = методы
        public string Name
        {
            get { return _name; }
            // set - передаваемый параметр
            set { _name = value; }
        }

        public Person(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }
    }
}
