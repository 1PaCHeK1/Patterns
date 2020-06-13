using System;
using System.Collections;
using System.Collections.Generic;

namespace Linker
{
    public class Leaf : IComponent
    {
        public string Name { get; }
        public Leaf(string _Name) => Name = _Name;
        public IEnumerator<IComponent> GetEnumerator() =>
            GetList(this).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
        public IEnumerable<IComponent> GetList() =>
            GetList(this);
        public IEnumerable<IComponent> GetList(IComponent component) =>
            new List<IComponent>() { component };
        public IComponent GetChild(int id) => 
            throw new NotImplementedException();
        public void AddComponent(IComponent component) =>
            throw new NotImplementedException();
        public void RemoveAtComponent(int id) => 
            throw new NotImplementedException();
    }
}