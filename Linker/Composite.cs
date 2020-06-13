using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Linker
{
    public class Composite : IComponent
    {
        private List<IComponent> Components = new List<IComponent>();
        public Composite(string _Name) => Name = _Name;
        public string Name { get; }
        public void AddComponent(IComponent component) =>
            Components.Add(component);
        public void RemoveAtComponent(int id) =>
            Components.RemoveAt(id);
        public IEnumerator<IComponent> GetEnumerator() =>
            Components.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
        public IEnumerable<IComponent> GetList() =>
            GetList(this);
        public IEnumerable<IComponent> GetList(IComponent component)
        {
            var result = new List<IComponent>();
            foreach (var i in component)
                result.AddRange(i.Count() == 1 ? i : GetList(i));
            return result;
        }
    }
}

