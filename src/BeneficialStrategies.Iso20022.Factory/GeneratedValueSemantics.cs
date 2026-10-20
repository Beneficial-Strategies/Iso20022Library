// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;
using System.ComponentModel;
using System.Text;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>
/// Called by the classes the factory builds, for the parts of value semantics that are not worth emitting in full.
/// Not for use in your own code.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class GeneratedValueSemantics
{
    private static readonly ConcurrentDictionary<Type, PropertyInfo[]> Members = new();

    /// <summary>Adds one member's hash to the running hash.</summary>
    public static int Combine(int hash, object? member) =>
        unchecked(hash * 31 + (member?.GetHashCode() ?? 0));

    /// <summary>The text of an object: its type and its members.</summary>
    public static string Describe(object value)
    {
        var type = value.GetType();
        var properties = Members.GetOrAdd(
            type,
            t => t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
        );
        var text = new StringBuilder(type.Name).Append(" { ");
        for (var i = 0; i < properties.Length; i++)
        {
            if (i > 0)
                text.Append(", ");
            text.Append(properties[i].Name)
                .Append(" = ")
                .Append(Show(properties[i].GetValue(value)));
        }
        return text.Append(" }").ToString();
    }

    private static string Show(object? member) =>
        member switch
        {
            null => "null",
            string s => s,
            System.Collections.IEnumerable items
                => "[" + string.Join(", ", items.Cast<object?>().Select(Show)) + "]",
            _ => member.ToString() ?? "",
        };
}
