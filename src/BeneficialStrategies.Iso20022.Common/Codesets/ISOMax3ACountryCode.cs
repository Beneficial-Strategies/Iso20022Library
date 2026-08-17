// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 or Alpha-3 code). The code is checked against the list of country names coded with three alphabetic characters, defined in the standard.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [A-Z]{2,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_99o6wZlbEeu76rs9yGlfEg")]
[Description(@"Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 or Alpha-3 code). The code is checked against the list of country names coded with three alphabetic characters, defined in the standard.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISOMax3ACountryCode>))]
public readonly struct ISOMax3ACountryCode : IIsoExternalCode, IEquatable<ISOMax3ACountryCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[A-Z]{2,3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISOMax3ACountryCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISOMax3ACountryCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISOMax3ACountryCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISOMax3ACountryCode"/>.</summary>
    public static implicit operator ISOMax3ACountryCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISOMax3ACountryCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISOMax3ACountryCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISOMax3ACountryCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISOMax3ACountryCode a, ISOMax3ACountryCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISOMax3ACountryCode a, ISOMax3ACountryCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISOMax3ACountryCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOMax3ACountryCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISOMax3ACountryCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISOMax3ACountryCode b) => a != b.Value;
}
