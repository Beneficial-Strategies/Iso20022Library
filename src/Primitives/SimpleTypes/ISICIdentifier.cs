// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier of economic activities by ISIC (United Nations International Standard Industrial Classification of all Economic Activities).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d8h_EI5_EemzmeK8_tPygg")]
[Description(@"Identifier of economic activities by ISIC (United Nations International Standard Industrial Classification of all Economic Activities).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ISICIdentifier>))]
public readonly struct ISICIdentifier : IIsoSimpleValue<string>, IEquatable<ISICIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-U]{1,1}[0-9]{0,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public ISICIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISICIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISICIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISICIdentifier"/>.</summary>
    public static implicit operator ISICIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ISICIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISICIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISICIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISICIdentifier a, ISICIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISICIdentifier a, ISICIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISICIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISICIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISICIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISICIdentifier b) => a != b.Value;
}
