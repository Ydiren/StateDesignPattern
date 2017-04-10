using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Base class for domain objects that provides basic 
    /// functionality across all objects.
    /// </summary>
    public class DomainObject
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public DomainObject()
        {
        }

        public DomainObject(string name)
        {
            Name = name;
        }
    }
}
