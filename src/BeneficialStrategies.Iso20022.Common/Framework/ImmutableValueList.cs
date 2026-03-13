// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections;
using System.Runtime.CompilerServices;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// An immutable, ordered collection that provides structural (element-by-element) equality,
/// making it safe to use as a property on immutable C# records.
/// </summary>
/// <remarks>
/// <para>
/// Standard .NET collection types (<see cref="List{T}"/>, arrays, <see cref="IReadOnlyList{T}"/>)
/// all use reference equality, which silently breaks auto-generated record equality when a record
/// contains collection properties. This type fixes that by overriding <see cref="Equals"/> with
/// <see cref="Enumerable.SequenceEqual{T}(IEnumerable{T}, IEnumerable{T})"/>.
/// </para>
/// <para>
/// Use C# 12 collection expressions to construct instances:
/// <code>
/// ImmutableValueList&lt;string&gt; empty = [];
/// ImmutableValueList&lt;string&gt; items = ["a", "b", "c"];
/// </code>
/// </para>
/// </remarks>
/// <typeparam name="T">The element type.</typeparam>
[CollectionBuilder(typeof(ImmutableValueListFactory), nameof(ImmutableValueListFactory.Create))]
public class ImmutableValueList<T> : IReadOnlyList<T>, IEquatable<ImmutableValueList<T>>
{
    private protected readonly T[] _items;

    /// <summary>Creates an empty list.</summary>
    public ImmutableValueList() => _items = [];

    /// <summary>Creates a list by copying elements from <paramref name="items"/>.</summary>
    public ImmutableValueList(ReadOnlySpan<T> items) => _items = items.ToArray();

    /// <summary>Creates a list by copying elements from <paramref name="items"/>.</summary>
    public ImmutableValueList(IEnumerable<T> items) => _items = items.ToArray();

    /// <inheritdoc/>
    public T this[int index] => _items[index];

    /// <inheritdoc/>
    public int Count => _items.Length;

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_items).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="other"/> contains the same elements
    /// in the same order, using the default equality comparer for <typeparamref name="T"/>.
    /// </summary>
    public bool Equals(ImmutableValueList<T>? other) =>
        other is not null && _items.SequenceEqual(other._items);

    /// <inheritdoc/>
    public override bool Equals(object? obj) => Equals(obj as ImmutableValueList<T>);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var item in _items)
            hash.Add(item);
        return hash.ToHashCode();
    }

    /// <summary>Structural equality.</summary>
    public static bool operator ==(ImmutableValueList<T>? left, ImmutableValueList<T>? right) =>
        left?.Equals(right) ?? right is null;

    /// <summary>Structural inequality.</summary>
    public static bool operator !=(ImmutableValueList<T>? left, ImmutableValueList<T>? right) =>
        !(left == right);
}

/// <summary>
/// Factory required by <see cref="CollectionBuilderAttribute"/> on <see cref="ImmutableValueList{T}"/>.
/// </summary>
public static class ImmutableValueListFactory
{
    /// <summary>Creates an <see cref="ImmutableValueList{T}"/> from a span.</summary>
    public static ImmutableValueList<T> Create<T>(ReadOnlySpan<T> items) => new(items);
}
