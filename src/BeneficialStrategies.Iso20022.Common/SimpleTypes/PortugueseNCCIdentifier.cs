// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Portuguese National Clearing Code. Identifies Portuguese financial institutions on the Portuguese national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXIoE9p-Ed-ak6NoX_4Aeg_-870707992")]
[Description(@"Portuguese National Clearing Code. Identifies Portuguese financial institutions on the Portuguese national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<PortugueseNCCIdentifier>))]
public readonly struct PortugueseNCCIdentifier : IIsoSimpleValue<string>, IEquatable<PortugueseNCCIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^PT[0-9]{8,8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public PortugueseNCCIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(PortugueseNCCIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out PortugueseNCCIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="PortugueseNCCIdentifier"/>.</summary>
    public static implicit operator PortugueseNCCIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(PortugueseNCCIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(PortugueseNCCIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is PortugueseNCCIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(PortugueseNCCIdentifier a, PortugueseNCCIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(PortugueseNCCIdentifier a, PortugueseNCCIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(PortugueseNCCIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(PortugueseNCCIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, PortugueseNCCIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, PortugueseNCCIdentifier b) => a != b.Value;
}
