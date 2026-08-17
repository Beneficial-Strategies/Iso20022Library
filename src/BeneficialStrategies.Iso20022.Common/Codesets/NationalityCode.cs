// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the country where a person was born or is naturalised.
/// </summary>
/// <remarks>
/// No length/pattern facet published by MCP for this type (only a &quot;ValidationByTable&quot; constraint referencing an external table) — external verification attempted, none found; kept permissive (non-empty string) per CLAUDE.md guidance rather than guessing a structure.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_aNJugNp-Ed-ak6NoX_4Aeg_-626382599")]
[Description(@"Specifies the country where a person was born or is naturalised.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<NationalityCode>))]
public readonly struct NationalityCode : IIsoExternalCode, IEquatable<NationalityCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public NationalityCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(NationalityCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out NationalityCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="NationalityCode"/>.</summary>
    public static implicit operator NationalityCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(NationalityCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(NationalityCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NationalityCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(NationalityCode a, NationalityCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(NationalityCode a, NationalityCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(NationalityCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(NationalityCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, NationalityCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, NationalityCode b) => a != b.Value;
}
