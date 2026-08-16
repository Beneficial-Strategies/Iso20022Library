// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:ID — an identifier that must be unique among all xs:ID-typed values in the
/// containing XML document.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:ID</c>, defined as a restriction of <c>xs:NCName</c> — same
/// lexical space as <see cref="XsdNCName"/> (see that type's remarks for the ASCII-simplification
/// caveat). The document-wide uniqueness constraint that gives xs:ID its name is a
/// document-scoped, cross-element constraint that can't be enforced by a single value type in
/// isolation — this struct validates the lexical shape only.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("ID_ID")]
[Description(@"W3C XML Schema xs:ID — an identifier that must be unique among all xs:ID-typed values in the containing XML document.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdID>))]
public readonly struct XsdID : IIsoSimpleValue<string>, IEquatable<XsdID>
{
    /// <summary>Same lexical space as <see cref="XsdNCName"/> — see <see cref="XsdNCName.Pattern"/>.</summary>
    public const string Pattern = XsdNCName.Pattern;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdID(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdID), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdID result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdID"/>.</summary>
    public static implicit operator XsdID(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdID v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdID other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdID other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdID a, XsdID b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdID a, XsdID b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdID a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdID a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdID b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdID b) => a != b.Value;
}
