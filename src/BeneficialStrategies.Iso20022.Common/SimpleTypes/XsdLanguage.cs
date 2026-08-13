// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:language — a natural language identifier, per RFC 3066/BCP 47.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:language</c>. Lexical space: <c>[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*</c>
/// (e.g. <c>"en"</c>, <c>"en-US"</c>, <c>"fr-CA"</c>).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("language_ID")]
[Description(@"W3C XML Schema xs:language — a natural language identifier, per RFC 3066/BCP 47.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdLanguage>))]
public readonly struct XsdLanguage : IIsoSimpleValue<string>, IEquatable<XsdLanguage>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdLanguage(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdLanguage), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdLanguage result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdLanguage"/>.</summary>
    public static implicit operator XsdLanguage(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdLanguage v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdLanguage other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdLanguage other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdLanguage a, XsdLanguage b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdLanguage a, XsdLanguage b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdLanguage a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdLanguage a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdLanguage b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdLanguage b) => a != b.Value;
}
