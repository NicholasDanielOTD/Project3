

using System.Collections;
using System.Collections.Generic;
using Project3.Entity;

public class Entities : IEnumerable {

    private readonly List<Entity> _entities = new List<Entity>();

    public Entities() {

    }
        public Entity this[int index] => _entities[index];
        public bool IsFixedSize => false;
        public bool IsReadOnly => false;
        public void Add(Entity value) => _entities.Add(value);
        public void Clear() => _entities.Clear();
        public bool Contains(Entity value) => _entities.Contains(value);
        public int IndexOf(Entity value) => _entities.IndexOf(value);
        public void Insert(int index, Entity value) => _entities.Insert(index, value);
        public void Remove(Entity value) => _entities.Remove(value);
        public void RemoveAt(int index) => _entities.RemoveAt(index);
        public IEnumerator GetEnumerator() => _entities.GetEnumerator();


}