// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a numeric string with a maximum length of 15 digits and may be prefixed with a plus sign.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YY7X0dp-Ed-ak6NoX_4Aeg_1835339329")]
[Description(@"Specifies a numeric string with a maximum length of 15 digits and may be prefixed with a plus sign.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max15PlusSignedNumericText>))]
public readonly struct Max15PlusSignedNumericText : IIsoSimpleValue<string>, IEquatable<Max15PlusSignedNumericText>
{
    /// <summary>ISO 20022 minimum length constraint (digits 0-9).</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint (optional '+' then 1-15 digits).</summary>
    public const int MaxLength = 16;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given numeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when the value does not match pattern <c>[\+]{0,1}[0-9]{1,15}</c>.
    /// </exception>
    public Max15PlusSignedNumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < 1)
            throw Iso20022FormatException.ForTooShort(typeof(Max15PlusSignedNumericText), value, 1);
        if (value.Length > 16)
            throw Iso20022FormatException.ForTooLong(typeof(Max15PlusSignedNumericText), value, 16);
        int start = value[0] == '+' ? 1 : 0;
        if (value.Length - start < 1 || value.Length - start > 15)
            throw new Iso20022FormatException(typeof(Max15PlusSignedNumericText), value,
                @"[\+]{0,1}[0-9]{1,15}");
        foreach (var c in value.AsSpan(start))
            if (c < '0' || c > '9')
                throw Iso20022FormatException.ForInvalidCharacter(
                    typeof(Max15PlusSignedNumericText), value, "optional '+' then 1-15 digits");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max15PlusSignedNumericText result)
    {
        if (value is not null && value.Length >= 1 && value.Length <= 16)
        {
            int start = value[0] == '+' ? 1 : 0;
            if (value.Length - start >= 1 && value.Length - start <= 15)
            {
                bool valid = true;
                foreach (var c in value.AsSpan(start))
                    if (c < '0' || c > '9')
                    { valid = false; break; }
                if (valid)
                { result = new(value); return true; }
            }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Max15PlusSignedNumericText"/>.</summary>
    public static implicit operator Max15PlusSignedNumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Max15PlusSignedNumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max15PlusSignedNumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max15PlusSignedNumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Max15PlusSignedNumericText a, Max15PlusSignedNumericText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max15PlusSignedNumericText a, Max15PlusSignedNumericText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max15PlusSignedNumericText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max15PlusSignedNumericText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max15PlusSignedNumericText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max15PlusSignedNumericText b) => a != b.Value;
}
