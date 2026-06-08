// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Polish National Clearing Code Identifier. Identifies Polish financial institutions on the Polish national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYn10dp-Ed-ak6NoX_4Aeg_1035690794")]
[Description(@"Polish National Clearing Code Identifier. Identifies Polish financial institutions on the Polish national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<PolishNationalClearingCodeIdentifier>))]
public readonly struct PolishNationalClearingCodeIdentifier : IIsoSimpleValue<string>, IEquatable<PolishNationalClearingCodeIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^PL[0-9]{8,8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public PolishNationalClearingCodeIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(PolishNationalClearingCodeIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out PolishNationalClearingCodeIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="PolishNationalClearingCodeIdentifier"/>.</summary>
    public static implicit operator PolishNationalClearingCodeIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(PolishNationalClearingCodeIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(PolishNationalClearingCodeIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is PolishNationalClearingCodeIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(PolishNationalClearingCodeIdentifier a, PolishNationalClearingCodeIdentifier b) => a.Equals(b);
    public static bool operator !=(PolishNationalClearingCodeIdentifier a, PolishNationalClearingCodeIdentifier b) => !a.Equals(b);
    public static bool operator ==(PolishNationalClearingCodeIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(PolishNationalClearingCodeIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, PolishNationalClearingCodeIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, PolishNationalClearingCodeIdentifier b) => a != b.Value;
}
