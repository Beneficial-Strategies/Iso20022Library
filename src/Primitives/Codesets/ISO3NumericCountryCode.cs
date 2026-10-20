// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Numeric-3 code). The code is checked against the list of country names coded with three digit characters, defined in the standard.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [0-9]{3,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_pcTHILupEeKYZNWWmvhGmg")]
[Description(@"Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Numeric-3 code). The code is checked against the list of country names coded with three digit characters, defined in the standard.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISO3NumericCountryCode>))]
public readonly struct ISO3NumericCountryCode : IIsoExternalCode, IEquatable<ISO3NumericCountryCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[0-9]{3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISO3NumericCountryCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO3NumericCountryCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISO3NumericCountryCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO3NumericCountryCode"/>.</summary>
    public static implicit operator ISO3NumericCountryCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISO3NumericCountryCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO3NumericCountryCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO3NumericCountryCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISO3NumericCountryCode a, ISO3NumericCountryCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISO3NumericCountryCode a, ISO3NumericCountryCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISO3NumericCountryCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISO3NumericCountryCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISO3NumericCountryCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISO3NumericCountryCode b) => a != b.Value;
}
