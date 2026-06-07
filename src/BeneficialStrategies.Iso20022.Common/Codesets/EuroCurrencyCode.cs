// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code allocated to the Euro currency, as described in the latest edition of the international standard ISO 4217.
/// </summary>
/// <remarks>
/// The only valid value for this type is <c>"EUR"</c>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_VwZPatp-Ed-ak6NoX_4Aeg_1509105390")]
[Description(@"Code allocated to the Euro currency, as described in the latest edition of the international standard ISO 4217.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<EuroCurrencyCode>))]
public readonly struct EuroCurrencyCode : IIsoExternalCode, IEquatable<EuroCurrencyCode>
{
    /// <summary>ISO 20022 format constraint — the only valid value is <c>"EUR"</c>.</summary>
    public const string Pattern = @"^EUR$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given currency code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public EuroCurrencyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(EuroCurrencyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out EuroCurrencyCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="EuroCurrencyCode"/>.</summary>
    public static implicit operator EuroCurrencyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(EuroCurrencyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(EuroCurrencyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is EuroCurrencyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(EuroCurrencyCode a, EuroCurrencyCode b) => a.Equals(b);
    public static bool operator !=(EuroCurrencyCode a, EuroCurrencyCode b) => !a.Equals(b);
    public static bool operator ==(EuroCurrencyCode a, string? b) => a.Value == b;
    public static bool operator !=(EuroCurrencyCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, EuroCurrencyCode b) => a == b.Value;
    public static bool operator !=(string? a, EuroCurrencyCode b) => a != b.Value;
}
