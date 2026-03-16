// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.CompilerServices;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Immutable ordered collection with structural equality. Extends
/// <see cref="ImmutableValueList{T}"/> and is the standard collection type used in
/// generated ISO 20022 message components for simple (primitive) element lists.
/// </summary>
/// <remarks>
/// Prefer collection expressions to construct instances: <c>[]</c> or <c>[ item1, item2 ]</c>.
/// </remarks>
[CollectionBuilder(typeof(SimpleValueListFactory), nameof(SimpleValueListFactory.Create))]
public sealed class SimpleValueList<T> : ImmutableValueList<T>
{
    /// <summary>Creates an empty list.</summary>
    public SimpleValueList() { }

    /// <summary>Creates a list by copying elements from <paramref name="items"/>.</summary>
    public SimpleValueList(ReadOnlySpan<T> items)
        : base(items) { }

    /// <summary>Creates a list by copying elements from <paramref name="items"/>.</summary>
    public SimpleValueList(IEnumerable<T> items)
        : base(items) { }

    /// <summary>
    /// Not supported — <see cref="SimpleValueList{T}"/> is immutable.
    /// Use collection expressions (<c>[ item1, item2 ]</c>) to construct instances.
    /// </summary>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    public void Add(T item) =>
        throw new NotSupportedException(
            $"{nameof(SimpleValueList<T>)} is immutable. Use collection expressions [] to construct."
        );
}

/// <summary>Factory required by <see cref="CollectionBuilderAttribute"/> on <see cref="SimpleValueList{T}"/>.</summary>
public static class SimpleValueListFactory
{
    /// <summary>Creates a <see cref="SimpleValueList{T}"/> from a span.</summary>
    public static SimpleValueList<T> Create<T>(ReadOnlySpan<T> items) => new(items);
}
