// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies an alphanumeric string with a length of 7 characters and a fixed value of 'REFUSED'.</summary>
[DataContract]
[Serializable]
[IsoId("_06pitjg0EeKfZIj_SwVRwA")]
[Description(@"Specifies an alphanumeric string with a length of 7 characters and a fixed value of 'REFUSED'.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Refused7Text>))]
public readonly struct Refused7Text : IIsoSimpleValue<string>, IEquatable<Refused7Text>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^REFUSED$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Refused7Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Refused7Text), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Refused7Text result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator Refused7Text(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Refused7Text t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Refused7Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Refused7Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Refused7Text a, Refused7Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Refused7Text a, Refused7Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Refused7Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Refused7Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Refused7Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Refused7Text b) => a != b.Value;
}
