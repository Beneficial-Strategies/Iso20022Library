#if NET462
namespace System.Collections.Generic;

/// <summary>Represents a read-only set of elements.</summary>
public interface IReadOnlySet<T> : IReadOnlyCollection<T>
{
    /// <summary>Determines whether the set contains the specified element.</summary>
    bool Contains(T item);

    /// <summary>Determines whether the set is a proper subset of another sequence.</summary>
    bool IsProperSubsetOf(IEnumerable<T> other);

    /// <summary>Determines whether the set is a proper superset of another sequence.</summary>
    bool IsProperSupersetOf(IEnumerable<T> other);

    /// <summary>Determines whether the set is a subset of another sequence.</summary>
    bool IsSubsetOf(IEnumerable<T> other);

    /// <summary>Determines whether the set is a superset of another sequence.</summary>
    bool IsSupersetOf(IEnumerable<T> other);

    /// <summary>Determines whether the set overlaps another sequence.</summary>
    bool Overlaps(IEnumerable<T> other);

    /// <summary>Determines whether the set and another sequence contain the same elements.</summary>
    bool SetEquals(IEnumerable<T> other);
}
#endif
