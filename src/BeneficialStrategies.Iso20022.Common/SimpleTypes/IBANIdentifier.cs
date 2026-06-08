// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// An identifier used internationally by financial institutions to uniquely identify the account of a customer at a financial institution as described in the latest edition of the international standard ISO 13616.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW1tI9p-Ed-ak6NoX_4Aeg_34949374")]
[Description(@"An identifier used internationally by financial institutions to uniquely identify the account of a customer at a financial institution as described in the latest edition of the international standard ISO 13616.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<IBANIdentifier>))]
public readonly struct IBANIdentifier : IIsoSimpleValue<string>, IEquatable<IBANIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-zA-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public IBANIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(IBANIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out IBANIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="IBANIdentifier"/>.</summary>
    public static implicit operator IBANIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(IBANIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(IBANIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IBANIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(IBANIdentifier a, IBANIdentifier b)  => a.Equals(b);
    public static bool operator !=(IBANIdentifier a, IBANIdentifier b)  => !a.Equals(b);
    public static bool operator ==(IBANIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(IBANIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, IBANIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, IBANIdentifier b)  => a != b.Value;
}
