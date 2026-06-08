// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Entity Legal Forms is a code allocated to a party as described in ISO 20275 Financial services - Entity legal forms (ELF).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I7cpkUoxEemire9PJV2erw")]
[Description(@"Entity Legal Forms is a code allocated to a party as described in ISO 20275 Financial services - Entity legal forms (ELF).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ELFIdentifier>))]
public readonly struct ELFIdentifier : IIsoSimpleValue<string>, IEquatable<ELFIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public ELFIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ELFIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ELFIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ELFIdentifier"/>.</summary>
    public static implicit operator ELFIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ELFIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ELFIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ELFIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ELFIdentifier a, ELFIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ELFIdentifier a, ELFIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ELFIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ELFIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ELFIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ELFIdentifier b) => a != b.Value;
}
