// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier providing additional system specific information about the entry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYn109p-Ed-ak6NoX_4Aeg_376711767")]
[Description(@"Identifier providing additional system specific information about the entry.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<EntryTypeIdentifier>))]
public readonly struct EntryTypeIdentifier : IIsoSimpleValue<string>, IEquatable<EntryTypeIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^([BEOVW][0-9]{2}|DUM)$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public EntryTypeIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(EntryTypeIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out EntryTypeIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="EntryTypeIdentifier"/>.</summary>
    public static implicit operator EntryTypeIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(EntryTypeIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(EntryTypeIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is EntryTypeIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(EntryTypeIdentifier a, EntryTypeIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(EntryTypeIdentifier a, EntryTypeIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(EntryTypeIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(EntryTypeIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, EntryTypeIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, EntryTypeIdentifier b) => a != b.Value;
}
