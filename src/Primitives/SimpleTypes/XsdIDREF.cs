// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:IDREF — a reference to an xs:ID value elsewhere in the containing XML
/// document.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:IDREF</c>, defined as a restriction of <c>xs:NCName</c> —
/// same lexical space as <see cref="XsdID"/>/<see cref="XsdNCName"/> (see <see cref="XsdNCName"/>'s
/// remarks for the ASCII-simplification caveat). The "must reference an existing xs:ID in this
/// document" constraint is document-scoped and can't be enforced by a single value type in
/// isolation — this struct validates the lexical shape only.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("IDREF_ID")]
[Description(@"W3C XML Schema xs:IDREF — a reference to an xs:ID value elsewhere in the containing XML document.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdIDREF>))]
public readonly struct XsdIDREF : IIsoSimpleValue<string>, IEquatable<XsdIDREF>
{
    /// <summary>Same lexical space as <see cref="XsdNCName"/> — see <see cref="XsdNCName.Pattern"/>.</summary>
    public const string Pattern = XsdNCName.Pattern;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdIDREF(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdIDREF), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdIDREF result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdIDREF"/>.</summary>
    public static implicit operator XsdIDREF(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdIDREF v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdIDREF other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdIDREF other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdIDREF a, XsdIDREF b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdIDREF a, XsdIDREF b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdIDREF a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdIDREF a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdIDREF b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdIDREF b) => a != b.Value;
}
