// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Base interface for all ISO 20022 primitive value wrappers — <c>readonly struct</c> types
/// that wrap a single CLR value and enforce ISO 20022 format constraints at construction time.
/// </summary>
/// <typeparam name="T">
/// The underlying CLR value type: <see cref="string"/> for text codes and identifiers,
/// <see cref="decimal"/> for numeric types, <see langword="byte"/>[] for binary/cryptographic
/// material, <see cref="System.Uri"/> for URI types, etc.
/// </typeparam>
/// <remarks>
/// <b>Serialization contract:</b> implementing this interface is what registers a type for
/// correct treatment by both serializers — no per-type XML attribute is required.
/// <list type="bullet">
///   <item><b>XML</b> — <see cref="Serialization.Iso20022XmlSerializer"/> detects
///     <c>IIsoSimpleValue&lt;T&gt;</c> in <c>IsLeafType</c> and dispatches to the appropriate
///     leaf formatter/parser for <typeparamref name="T"/>.</item>
///   <item><b>JSON</b> — each implementing struct carries
///     <c>[JsonConverter(typeof(Iso20022SimpleValueJsonConverter&lt;TStruct,T&gt;))]</c>.</item>
/// </list>
/// Implementing types must expose a public <c>(<typeparamref name="T"/> value)</c> constructor
/// that validates the value against the ISO 20022 constraint and throws
/// <see cref="Iso20022FormatException"/> on failure.
/// </remarks>
public interface IIsoSimpleValue<T>
{
    /// <summary>The validated underlying value.</summary>
    T Value { get; }
}
