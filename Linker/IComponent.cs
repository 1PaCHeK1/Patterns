using System.Collections.Generic;

namespace Linker
{
    public interface IComponent : IEnumerable<IComponent>
    {
        string Name { get; }
        void AddComponent(IComponent component);
        void RemoveAtComponent(int id);
        IEnumerable<IComponent> GetList() => 
            GetList(this);
        protected IEnumerable<IComponent> GetList(IComponent component);
    }
}