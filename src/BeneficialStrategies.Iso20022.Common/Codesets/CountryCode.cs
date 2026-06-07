// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTfEctp-Ed-ak6NoX_4Aeg_-804722522")]
[Description(@"Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<CountryCode>))]
public readonly struct CountryCode : IIsoExternalCode, IEquatable<CountryCode>
{
    /// <summary>ISO 20022 format constraint for this type (ISO 3166-1 alpha-2).</summary>
    public const string Pattern = @"^[A-Z]{2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given country code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public CountryCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CountryCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out CountryCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CountryCode"/>.</summary>
    public static implicit operator CountryCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(CountryCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CountryCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CountryCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(CountryCode a, CountryCode b) => a.Equals(b);
    public static bool operator !=(CountryCode a, CountryCode b) => !a.Equals(b);
    public static bool operator ==(CountryCode a, string? b) => a.Value == b;
    public static bool operator !=(CountryCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, CountryCode b) => a == b.Value;
    public static bool operator !=(string? a, CountryCode b) => a != b.Value;
}
