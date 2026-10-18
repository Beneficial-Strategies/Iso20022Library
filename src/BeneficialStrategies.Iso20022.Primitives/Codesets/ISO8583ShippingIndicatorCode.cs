// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code identifying shipping method.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [0-9]{2,2}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_uCkKMWaLEfCX7uJiAWHfoQ")]
[Description(@"A code identifying shipping method.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISO8583ShippingIndicatorCode>))]
public readonly struct ISO8583ShippingIndicatorCode : IIsoExternalCode, IEquatable<ISO8583ShippingIndicatorCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[0-9]{2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISO8583ShippingIndicatorCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO8583ShippingIndicatorCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISO8583ShippingIndicatorCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO8583ShippingIndicatorCode"/>.</summary>
    public static implicit operator ISO8583ShippingIndicatorCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISO8583ShippingIndicatorCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO8583ShippingIndicatorCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO8583ShippingIndicatorCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISO8583ShippingIndicatorCode a, ISO8583ShippingIndicatorCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISO8583ShippingIndicatorCode a, ISO8583ShippingIndicatorCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISO8583ShippingIndicatorCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISO8583ShippingIndicatorCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISO8583ShippingIndicatorCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISO8583ShippingIndicatorCode b) => a != b.Value;
}
