// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:token — a whitespace-collapsed string.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:token</c> — a restriction of <see cref="XsdNormalizedString"/>
/// with the <c>whiteSpace</c> facet set to <c>collapse</c>: in addition to forbidding literal
/// <c>\t</c>/<c>\n</c>/<c>\r</c>, leading and trailing spaces are forbidden and no internal run
/// of more than one space is permitted.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("token_ID")]
[Description(@"W3C XML Schema xs:token — a whitespace-collapsed string (no tab/newline/carriage-return, no leading or trailing space, no internal run of multiple spaces).")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdToken>))]
public readonly struct XsdToken : IIsoSimpleValue<string>, IEquatable<XsdToken>
{
    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when <paramref name="value"/> contains a tab, newline, or carriage return; has a
    /// leading or trailing space; or contains a run of more than one consecutive space.
    /// </exception>
    public XsdToken(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!IsValid(value))
            throw new Iso20022FormatException(
                typeof(XsdToken), value,
                "xs:token — no tab/newline/carriage-return, no leading or trailing space, no internal run of multiple spaces");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:token.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdToken result)
    {
        if (value is not null && IsValid(value))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    private static bool IsValid(string value) =>
        !Regex.IsMatch(value, @"[\t\n\r]")
        && !value.StartsWith(' ')
        && !value.EndsWith(' ')
        && !value.Contains("  ", StringComparison.Ordinal);

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdToken"/>.</summary>
    public static implicit operator XsdToken(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdToken v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdToken other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdToken other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdToken a, XsdToken b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdToken a, XsdToken b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdToken a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdToken a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdToken b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdToken b) => a != b.Value;
}
