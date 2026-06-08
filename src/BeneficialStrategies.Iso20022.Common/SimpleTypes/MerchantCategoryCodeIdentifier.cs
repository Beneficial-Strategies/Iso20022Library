// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies the merchant category code, using the ISO 18245 defined for the assignment of Merchant Category Codes (MCC) in retail financial services.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I15MoXFsEemaN4ndAVY1ZQ")]
[Description(@"Specifies the merchant category code, using the ISO 18245 defined for the assignment of Merchant Category Codes (MCC) in retail financial services.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<MerchantCategoryCodeIdentifier>))]
public readonly struct MerchantCategoryCodeIdentifier : IIsoSimpleValue<string>, IEquatable<MerchantCategoryCodeIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[0-9]{4,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public MerchantCategoryCodeIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(MerchantCategoryCodeIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out MerchantCategoryCodeIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="MerchantCategoryCodeIdentifier"/>.</summary>
    public static implicit operator MerchantCategoryCodeIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(MerchantCategoryCodeIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(MerchantCategoryCodeIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is MerchantCategoryCodeIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(MerchantCategoryCodeIdentifier a, MerchantCategoryCodeIdentifier b)  => a.Equals(b);
    public static bool operator !=(MerchantCategoryCodeIdentifier a, MerchantCategoryCodeIdentifier b)  => !a.Equals(b);
    public static bool operator ==(MerchantCategoryCodeIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(MerchantCategoryCodeIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, MerchantCategoryCodeIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, MerchantCategoryCodeIdentifier b)  => a != b.Value;
}
