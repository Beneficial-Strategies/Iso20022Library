// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Domain identifier for NACE (Nomenclature of Economic Activities which is the European statistical classification of economic activities).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VHNvASrVEeWVAsq7ECcp5g")]
[Description(@"Domain identifier for NACE (Nomenclature of Economic Activities which is the European statistical classification of economic activities).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<NACEDomainIdentifier>))]
public readonly struct NACEDomainIdentifier : IIsoSimpleValue<string>, IEquatable<NACEDomainIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-U]{1,1}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public NACEDomainIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(NACEDomainIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out NACEDomainIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="NACEDomainIdentifier"/>.</summary>
    public static implicit operator NACEDomainIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(NACEDomainIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(NACEDomainIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NACEDomainIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(NACEDomainIdentifier a, NACEDomainIdentifier b) => a.Equals(b);
    public static bool operator !=(NACEDomainIdentifier a, NACEDomainIdentifier b) => !a.Equals(b);
    public static bool operator ==(NACEDomainIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(NACEDomainIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, NACEDomainIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, NACEDomainIdentifier b) => a != b.Value;
}
