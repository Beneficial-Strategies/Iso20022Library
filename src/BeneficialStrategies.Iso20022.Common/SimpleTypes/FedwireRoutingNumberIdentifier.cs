// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Fedwire Routing Number. Identifies financial institutions in the US on the FedWire system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3FNp-Ed-ak6NoX_4Aeg_-870708084")]
[Description(@"Fedwire Routing Number. Identifies financial institutions in the US on the FedWire system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<FedwireRoutingNumberIdentifier>))]
public readonly struct FedwireRoutingNumberIdentifier : IIsoSimpleValue<string>, IEquatable<FedwireRoutingNumberIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^FW[0-9]{9,9}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public FedwireRoutingNumberIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(FedwireRoutingNumberIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out FedwireRoutingNumberIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="FedwireRoutingNumberIdentifier"/>.</summary>
    public static implicit operator FedwireRoutingNumberIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(FedwireRoutingNumberIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(FedwireRoutingNumberIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is FedwireRoutingNumberIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(FedwireRoutingNumberIdentifier a, FedwireRoutingNumberIdentifier b) => a.Equals(b);
    public static bool operator !=(FedwireRoutingNumberIdentifier a, FedwireRoutingNumberIdentifier b) => !a.Equals(b);
    public static bool operator ==(FedwireRoutingNumberIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(FedwireRoutingNumberIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, FedwireRoutingNumberIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, FedwireRoutingNumberIdentifier b) => a != b.Value;
}
