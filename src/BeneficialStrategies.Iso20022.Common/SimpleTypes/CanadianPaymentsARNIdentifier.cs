// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Canadian Payments Association Routing Number. Identifies Canadian financial institutions on the Canadian national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXIoF9p-Ed-ak6NoX_4Aeg_-870707956")]
[Description(@"Canadian Payments Association Routing Number. Identifies Canadian financial institutions on the Canadian national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<CanadianPaymentsARNIdentifier>))]
public readonly struct CanadianPaymentsARNIdentifier : IIsoSimpleValue<string>, IEquatable<CanadianPaymentsARNIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^CA[0-9]{9,9}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public CanadianPaymentsARNIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CanadianPaymentsARNIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out CanadianPaymentsARNIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CanadianPaymentsARNIdentifier"/>.</summary>
    public static implicit operator CanadianPaymentsARNIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(CanadianPaymentsARNIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CanadianPaymentsARNIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CanadianPaymentsARNIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(CanadianPaymentsARNIdentifier a, CanadianPaymentsARNIdentifier b)  => a.Equals(b);
    public static bool operator !=(CanadianPaymentsARNIdentifier a, CanadianPaymentsARNIdentifier b)  => !a.Equals(b);
    public static bool operator ==(CanadianPaymentsARNIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(CanadianPaymentsARNIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, CanadianPaymentsARNIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, CanadianPaymentsARNIdentifier b)  => a != b.Value;
}
