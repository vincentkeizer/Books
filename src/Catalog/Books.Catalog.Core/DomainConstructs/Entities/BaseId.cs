using System;
using System.Diagnostics;
using Books.Catalog.Core.Assertions;

namespace Books.Catalog.Core.DomainConstructs.Entities
{
    [DebuggerDisplay("BaseId = {DebuggerDisplayText()}")]
    public abstract record BaseId
    {
        protected BaseId(Guid value)
        {
            Guard.IsNotNull(value, nameof(value));
            Guard.IsNotDefault(value, nameof(value));
            Value = value;
        }

        public Guid Value { get; }
        
        public override string ToString() => Value.ToString();

        public string DebuggerDisplayText() => $"{this.GetType().Name}: { ToString() }";
    }
}