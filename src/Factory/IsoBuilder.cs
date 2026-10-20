// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Linq.Expressions;
using System.Reflection;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>
/// Sets the members of an object a factory made for an interface, by naming them with a lambda: the interface itself has no setters.
/// </summary>
/// <remarks>
/// The members are checked at compile time (<c>x =&gt; x.Identification</c>), and the value has the member's own type, so the
/// conversions that work for a record (<c>"MSG-1"</c> to a <c>Max35Text</c>) work here. Use it through
/// <see cref="IsoDataFactory.Make{T}"/>; it is meant for tests and samples, where an object is written out by hand.
/// </remarks>
/// <typeparam name="T">The interface being built.</typeparam>
public sealed class IsoBuilder<T>
    where T : class
{
    private readonly object _instance;

    internal IsoBuilder(object instance) => _instance = instance;

    /// <summary>Names a member to set; <see cref="Member{TValue}.To"/> gives it its value.</summary>
    /// <remarks>Two steps, so that the value is converted to the member's type as it is for a record: with the value in the same call the
    /// compiler would try to infer the member's type from it.</remarks>
    public Member<TValue> Set<TValue>(Expression<Func<T, TValue>> member)
    {
        if (member is null)
            throw new System.ArgumentNullException(nameof(member));
        var name = (member.Body is UnaryExpression { Operand: MemberExpression converted } ? converted : member.Body as MemberExpression)?.Member.Name
            ?? throw new ArgumentException("Name a member of the interface, such as x => x.Identification.", nameof(member));
        var property = _instance.GetType().GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
        if (property is null || !property.CanWrite)
            throw new InvalidOperationException($"{_instance.GetType().Name} has no settable member '{name}'.");
        return new Member<TValue>(this, _instance, property);
    }

    /// <summary>A member that has been named and waits for its value.</summary>
    public readonly struct Member<TValue>
    {
        private readonly IsoBuilder<T> _builder;
        private readonly object _instance;
        private readonly PropertyInfo _property;

        internal Member(IsoBuilder<T> builder, object instance, PropertyInfo property) =>
            (_builder, _instance, _property) = (builder, instance, property);

        /// <summary>Sets the member.</summary>
        /// <returns>The builder, to chain.</returns>
        public IsoBuilder<T> To(TValue value)
        {
            _property.SetValue(_instance, value);
            return _builder;
        }
    }

    internal T Result => (T)_instance;
}
