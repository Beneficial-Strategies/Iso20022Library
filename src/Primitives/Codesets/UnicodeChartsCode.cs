// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codelist containing the names of the UNICODE code block name as specified on http://unicode.org/Public/UNIDATA/Blocks.txt.
/// </summary>
/// <remarks>
/// Valid values are Unicode block names such as <c>"Basic Latin"</c>, <c>"Latin Extended-A"</c>, etc.
/// The ISO 20022 specification provides no length or character-class constraint beyond non-empty.
/// Consult http://unicode.org/Public/UNIDATA/Blocks.txt for the authoritative value list.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YghNkNp-Ed-ak6NoX_4Aeg_728068642")]
[Description(@"Codelist containing the names of the UNICODE code block name as specified on http://unicode.org/Public/UNIDATA/Blocks.txt.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<UnicodeChartsCode>))]
public readonly struct UnicodeChartsCode : IIsoExternalCode, IEquatable<UnicodeChartsCode>
{
    /// <summary>ISO 20022 format constraint — non-empty string (no length or character-class restriction is specified by the spec).</summary>
    public const string Pattern = @"^.+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given Unicode block name.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public UnicodeChartsCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(UnicodeChartsCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out UnicodeChartsCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="UnicodeChartsCode"/>.</summary>
    public static implicit operator UnicodeChartsCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(UnicodeChartsCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(UnicodeChartsCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is UnicodeChartsCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(UnicodeChartsCode a, UnicodeChartsCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(UnicodeChartsCode a, UnicodeChartsCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(UnicodeChartsCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(UnicodeChartsCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, UnicodeChartsCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, UnicodeChartsCode b) => a != b.Value;
}
