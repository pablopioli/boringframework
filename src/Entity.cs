using System;
using System.Collections;

namespace Boring
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Guid Id { get; set; } = GuidComb.NewComb();
        public virtual int Version { get; set; }
        public virtual IDictionary DynamicProperties { get; set; } = new System.Collections.Generic.Dictionary<object, object>();

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            var businessEntity = obj as Entity;

            if (businessEntity == null)
            {
                return false;
            }

            return Id == businessEntity.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public virtual bool Equals(Entity other)
        {
            if (other is null)
            {
                return false;
            }

            return Id == other.Id;
        }
    }
}
