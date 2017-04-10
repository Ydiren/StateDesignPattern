namespace StateDesignPattern
{
    class DomainObject
    {
        public string Name { get; set; }

        public DomainObject()
        {
        }

        public DomainObject(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}