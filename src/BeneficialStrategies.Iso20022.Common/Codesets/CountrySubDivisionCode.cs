// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify a name of a unit resulting from the division of a country, dependency, or other area of special geopolitical interest contained in ISO 3166-1, on the basis of country names obtained from the United Nations (ISO 3166-2: Country subdivision code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8oowMkDhEeWt96EosbOZ-w")]
[Description(@"Code to identify a name of a unit resulting from the division of a country, dependency, or other area of special geopolitical interest contained in ISO 3166-1, on the basis of country names obtained from the United Nations (ISO 3166-2: Country subdivision code).")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<CountrySubDivisionCode>))]
public readonly struct CountrySubDivisionCode : IIsoExternalCode, IEquatable<CountrySubDivisionCode>
{
    /// <summary>ISO 20022 format constraint for this type (ISO 3166-2: CC-SSS).</summary>
    public const string Pattern = @"^[A-Z]{2}-[0-9A-Z]{1,3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given subdivision code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public CountrySubDivisionCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CountrySubDivisionCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out CountrySubDivisionCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CountrySubDivisionCode"/>.</summary>
    public static implicit operator CountrySubDivisionCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(CountrySubDivisionCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CountrySubDivisionCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CountrySubDivisionCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(CountrySubDivisionCode a, CountrySubDivisionCode b) => a.Equals(b);
    public static bool operator !=(CountrySubDivisionCode a, CountrySubDivisionCode b) => !a.Equals(b);
    public static bool operator ==(CountrySubDivisionCode a, string? b) => a.Value == b;
    public static bool operator !=(CountrySubDivisionCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, CountrySubDivisionCode b) => a == b.Value;
    public static bool operator !=(string? a, CountrySubDivisionCode b) => a != b.Value;
}
