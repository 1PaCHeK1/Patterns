using System.Collections.Generic;

namespace Linker
{
    internal class ComponentIterator
    {
        private List<IComponent> Components;
        public ComponentIterator(IEnumerable<IComponent> _Components) =>
            Components = new List<IComponent>(_Components);
        public ComponentIterator(IComponent _Component) =>
            Components = new List<IComponent>() { _Component };
        public void Add(IComponent _Component) => 
            Components.Add(_Component);
    }
}