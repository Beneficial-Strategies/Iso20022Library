// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:IDREFS — a whitespace-separated list of one or more xs:IDREF values.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:IDREFS</c> — a list type over <c>xs:IDREF</c>. Each
/// whitespace-separated token has the same lexical shape as <see cref="XsdIDREF"/>/
/// <see cref="XsdNCName"/> (see <see cref="XsdNCName"/>'s remarks for the ASCII-simplification
/// caveat).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("IDREFS_ID")]
[Description(@"W3C XML Schema xs:IDREFS — a whitespace-separated list of one or more xs:IDREF values.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdIDREFS>))]
public readonly struct XsdIDREFS : IIsoSimpleValue<string>, IEquatable<XsdIDREFS>
{
    /// <summary>One or more whitespace-separated xs:NCName-shaped tokens (see type remarks).</summary>
    public const string Pattern = @"^[a-zA-Z_][a-zA-Z0-9_.\-]*(\s+[a-zA-Z_][a-zA-Z0-9_.\-]*)*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdIDREFS(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdIDREFS), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdIDREFS result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdIDREFS"/>.</summary>
    public static implicit operator XsdIDREFS(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdIDREFS v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdIDREFS other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdIDREFS other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdIDREFS a, XsdIDREFS b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdIDREFS a, XsdIDREFS b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdIDREFS a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdIDREFS a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdIDREFS b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdIDREFS b) => a != b.Value;
}
