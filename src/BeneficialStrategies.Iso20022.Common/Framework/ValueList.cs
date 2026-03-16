// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.CompilerServices;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Immutable ordered collection with structural equality. Extends
/// <see cref="ImmutableValueList{T}"/> and is the standard collection type used in
/// generated ISO 20022 message components.
/// </summary>
/// <remarks>
/// Prefer collection expressions to construct instances: <c>[]</c> or <c>[ item1, item2 ]</c>.
/// </remarks>
[CollectionBuilder(typeof(ValueListFactory), nameof(ValueListFactory.Create))]
public sealed class ValueList<T> : ImmutableValueList<T>
{
    /// <summary>Creates an empty list.</summary>
    public ValueList() { }

    /// <summary>Creates a list by copying elements from <paramref name="items"/>.</summary>
    public ValueList(ReadOnlySpan<T> items)
        : base(items) { }

    /// <summary>Creates a list by copying elements from <paramref name="items"/>.</summary>
    public ValueList(IEnumerable<T> items)
        : base(items) { }

    /// <summary>
    /// Not supported — <see cref="ValueList{T}"/> is immutable.
    /// Use collection expressions (<c>[ item1, item2 ]</c>) to construct instances.
    /// </summary>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    public void Add(T item) =>
        throw new NotSupportedException(
            $"{nameof(ValueList<T>)} is immutable. Use collection expressions [] to construct."
        );
}

/// <summary>Factory required by <see cref="CollectionBuilderAttribute"/> on <see cref="ValueList{T}"/>.</summary>
public static class ValueListFactory
{
    /// <summary>Creates a <see cref="ValueList{T}"/> from a span.</summary>
    public static ValueList<T> Create<T>(ReadOnlySpan<T> items) => new(items);
}
