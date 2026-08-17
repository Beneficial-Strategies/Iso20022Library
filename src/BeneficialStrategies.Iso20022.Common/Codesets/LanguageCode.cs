// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a language.
/// </summary>
/// <remarks>
/// No length/pattern facet published by MCP for this type (only a &quot;ValidationByTable&quot; constraint referencing an external table) — external verification attempted, none found; kept permissive (non-empty string) per CLAUDE.md guidance rather than guessing a structure. Its siblings ISO2ALanguageCode (2-letter) and ISOMax3ALanguageCode (2-3 letter) DO carry explicit ISO 639 patterns.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_adsE5Np-Ed-ak6NoX_4Aeg_2082946596")]
[Description(@"Specifies a language.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<LanguageCode>))]
public readonly struct LanguageCode : IIsoExternalCode, IEquatable<LanguageCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public LanguageCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(LanguageCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out LanguageCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="LanguageCode"/>.</summary>
    public static implicit operator LanguageCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(LanguageCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(LanguageCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is LanguageCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(LanguageCode a, LanguageCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(LanguageCode a, LanguageCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(LanguageCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(LanguageCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, LanguageCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, LanguageCode b) => a != b.Value;
}
